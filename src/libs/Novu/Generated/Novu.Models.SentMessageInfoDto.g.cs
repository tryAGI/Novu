
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentMessageInfoDto
    {
        /// <summary>
        /// Platform-native message id of the delivered or edited message (e.g. Slack `ts`, Teams activity id).<br/>
        /// Example: 1712345678.123456
        /// </summary>
        /// <example>1712345678.123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Platform-native thread / conversation id where the message was delivered.<br/>
        /// Example: C0123456789
        /// </summary>
        /// <example>C0123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platformThreadId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlatformThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentMessageInfoDto" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Platform-native message id of the delivered or edited message (e.g. Slack `ts`, Teams activity id).<br/>
        /// Example: 1712345678.123456
        /// </param>
        /// <param name="platformThreadId">
        /// Platform-native thread / conversation id where the message was delivered.<br/>
        /// Example: C0123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentMessageInfoDto(
            string messageId,
            string platformThreadId)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.PlatformThreadId = platformThreadId ?? throw new global::System.ArgumentNullException(nameof(platformThreadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentMessageInfoDto" /> class.
        /// </summary>
        public SentMessageInfoDto()
        {
        }

    }
}