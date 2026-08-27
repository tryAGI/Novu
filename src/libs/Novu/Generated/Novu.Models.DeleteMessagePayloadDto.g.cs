
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteMessagePayloadDto
    {
        /// <summary>
        /// Platform message id to delete. Removes the rendered message only — history is preserved.<br/>
        /// Example: 1712345678.123456
        /// </summary>
        /// <example>1712345678.123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessagePayloadDto" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Platform message id to delete. Removes the rendered message only — history is preserved.<br/>
        /// Example: 1712345678.123456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMessagePayloadDto(
            string messageId)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessagePayloadDto" /> class.
        /// </summary>
        public DeleteMessagePayloadDto()
        {
        }

    }
}