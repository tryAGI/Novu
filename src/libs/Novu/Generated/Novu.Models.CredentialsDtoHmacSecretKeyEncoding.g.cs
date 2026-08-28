
#nullable enable

namespace Novu
{
    /// <summary>
    /// Email webhook: how `secretKey` is interpreted when signing webhook calls. `text` signs with the raw UTF-8 bytes; `base64`/`hex` decode it to binary first (e.g. for AWS KMS).
    /// </summary>
    public enum CredentialsDtoHmacSecretKeyEncoding
    {
        /// <summary>
        /// how `secretKey` is interpreted when signing webhook calls. `text` signs with the raw UTF-8 bytes; `base64`/`hex` decode it to binary first (e.g. for AWS KMS).
        /// </summary>
        Base64,
        /// <summary>
        /// how `secretKey` is interpreted when signing webhook calls. `text` signs with the raw UTF-8 bytes; `base64`/`hex` decode it to binary first (e.g. for AWS KMS).
        /// </summary>
        Hex,
        /// <summary>
        /// how `secretKey` is interpreted when signing webhook calls. `text` signs with the raw UTF-8 bytes; `base64`/`hex` decode it to binary first (e.g. for AWS KMS).
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialsDtoHmacSecretKeyEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialsDtoHmacSecretKeyEncoding value)
        {
            return value switch
            {
                CredentialsDtoHmacSecretKeyEncoding.Base64 => "base64",
                CredentialsDtoHmacSecretKeyEncoding.Hex => "hex",
                CredentialsDtoHmacSecretKeyEncoding.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialsDtoHmacSecretKeyEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CredentialsDtoHmacSecretKeyEncoding.Base64,
                "hex" => CredentialsDtoHmacSecretKeyEncoding.Hex,
                "text" => CredentialsDtoHmacSecretKeyEncoding.Text,
                _ => null,
            };
        }
    }
}