
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelegramChatEndpointDto
    {
        /// <summary>
        /// Telegram chat ID<br/>
        /// Example: 123456789
        /// </summary>
        /// <example>123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramChatEndpointDto" /> class.
        /// </summary>
        /// <param name="chatId">
        /// Telegram chat ID<br/>
        /// Example: 123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelegramChatEndpointDto(
            string chatId)
        {
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramChatEndpointDto" /> class.
        /// </summary>
        public TelegramChatEndpointDto()
        {
        }

    }
}