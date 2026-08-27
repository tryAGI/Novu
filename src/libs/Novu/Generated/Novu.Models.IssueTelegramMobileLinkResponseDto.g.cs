
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssueTelegramMobileLinkResponseDto
    {
        /// <summary>
        /// Opaque, single-use token identifying this Telegram mobile-setup session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Absolute URL the user can open on a mobile device to complete Telegram setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// ISO-8601 timestamp at which the token expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTelegramMobileLinkResponseDto" /> class.
        /// </summary>
        /// <param name="token">
        /// Opaque, single-use token identifying this Telegram mobile-setup session
        /// </param>
        /// <param name="url">
        /// Absolute URL the user can open on a mobile device to complete Telegram setup
        /// </param>
        /// <param name="expiresAt">
        /// ISO-8601 timestamp at which the token expires
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueTelegramMobileLinkResponseDto(
            string token,
            string url,
            string expiresAt)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTelegramMobileLinkResponseDto" /> class.
        /// </summary>
        public IssueTelegramMobileLinkResponseDto()
        {
        }

    }
}