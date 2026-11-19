
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSubscriberTokenResponseDto
    {
        /// <summary>
        /// Novu-signed login token for the subscriber. Exchange it in the browser for an Inbox session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// When the token expires, in ISO 8601.<br/>
        /// Example: 2025-01-01T00:10:00.000Z
        /// </summary>
        /// <example>2025-01-01T00:10:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriberTokenResponseDto" /> class.
        /// </summary>
        /// <param name="token">
        /// Novu-signed login token for the subscriber. Exchange it in the browser for an Inbox session.
        /// </param>
        /// <param name="expiresAt">
        /// When the token expires, in ISO 8601.<br/>
        /// Example: 2025-01-01T00:10:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubscriberTokenResponseDto(
            string token,
            global::System.DateTime expiresAt)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriberTokenResponseDto" /> class.
        /// </summary>
        public CreateSubscriberTokenResponseDto()
        {
        }

    }
}