using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DocSpring
{
    /// <summary>
    /// Checks webhook requests' X-DocSpring-Signature header (https://docspring.com/docs/webhooks/verifying-signatures/).
    /// </summary>
    public static class Webhooks
    {
        /// <summary>The number of seconds a webhook request's signature stays valid (VerifyWebhookSignature)</summary>
        public const long DefaultToleranceSeconds = 300;

        /// <summary>
        /// Checks a webhook request's X-DocSpring-Signature header. Returns true when one of its v1 signatures is the
        /// HMAC-SHA256 of "{t}.{payload}" with the webhook's secret, and its timestamp t is at most toleranceSeconds
        /// from now. Returns false for anything else, including a missing or malformed header.
        /// </summary>
        /// <param name="payload">The request body exactly as it was received, not parsed JSON.</param>
        /// <param name="signatureHeader">The X-DocSpring-Signature header.</param>
        /// <param name="secret">The webhook's signing secret.</param>
        /// <param name="toleranceSeconds">How many seconds old (or early) the timestamp can be. 5 minutes by default.</param>
        /// <param name="now">The current Unix time in seconds, for tests. The system clock by default.</param>
        public static bool VerifyWebhookSignature(
            string payload,
            string signatureHeader,
            string secret,
            long toleranceSeconds = DefaultToleranceSeconds,
            long? now = null)
        {
            if (payload == null || signatureHeader == null || string.IsNullOrEmpty(secret)) return false;

            string timestamp = null;
            var signatures = new List<string>();
            foreach (var part in signatureHeader.Split(','))
            {
                var pair = part.Trim().Split(new[] { '=' }, 2);
                var value = pair.Length == 2 ? pair[1] : "";
                if (pair[0] == "t" && timestamp == null)
                {
                    timestamp = value;
                }
                else if (pair[0] == "v1" && value.Length > 0)
                {
                    signatures.Add(value);
                }
            }
            if (!IsDigits(timestamp) || signatures.Count == 0) return false;
            if (!long.TryParse(timestamp, out var seconds)) return false;

            var current = now ?? DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if ((current > seconds ? current - seconds : seconds - current) > toleranceSeconds) return false;

            string expected;
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(timestamp + "." + payload));
                expected = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
            var valid = false;
            foreach (var signature in signatures)
            {
                if (ConstantTimeEquals(signature, expected)) valid = true;
            }
            return valid;
        }

        private static bool IsDigits(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            foreach (var character in value)
            {
                if (character < '0' || character > '9') return false;
            }
            return true;
        }

        // Constant time, so a timing attack can't find a valid signature byte by byte. (netstandard2.0 has no
        // CryptographicOperations.FixedTimeEquals.)
        private static bool ConstantTimeEquals(string actual, string expected)
        {
            if (actual.Length != expected.Length) return false;
            var difference = 0;
            for (var i = 0; i < actual.Length; i++)
            {
                difference |= actual[i] ^ expected[i];
            }
            return difference == 0;
        }
    }
}
