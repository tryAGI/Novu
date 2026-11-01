
#nullable enable

namespace Novu
{
    /// <summary>
    /// Twilio: `apiKey` authenticates with `apiKey` (API Key SID) and `secretKey` (API Key Secret) on behalf of `accountSid`. When omitted, `token` (Auth Token) is used.
    /// </summary>
    public enum CredentialsDtoAuthMethod
    {
        /// <summary>
        /// `apiKey` authenticates with `apiKey` (API Key SID) and `secretKey` (API Key Secret) on behalf of `accountSid`. When omitted, `token` (Auth Token) is used.
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialsDtoAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialsDtoAuthMethod value)
        {
            return value switch
            {
                CredentialsDtoAuthMethod.ApiKey => "apiKey",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialsDtoAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "apiKey" => CredentialsDtoAuthMethod.ApiKey,
                _ => null,
            };
        }
    }
}