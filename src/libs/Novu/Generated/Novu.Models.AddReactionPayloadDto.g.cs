
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddReactionPayloadDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emojiName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmojiName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReactionPayloadDto" /> class.
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="emojiName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddReactionPayloadDto(
            string messageId,
            string emojiName)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.EmojiName = emojiName ?? throw new global::System.ArgumentNullException(nameof(emojiName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReactionPayloadDto" /> class.
        /// </summary>
        public AddReactionPayloadDto()
        {
        }

    }
}