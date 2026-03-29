
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageMarkAsRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>> MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markAs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageMarkAsRequestDtoMarkAs MarkAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMarkAsRequestDto" /> class.
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="markAs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageMarkAsRequestDto(
            global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>> messageId,
            global::Novu.MessageMarkAsRequestDtoMarkAs markAs)
        {
            this.MessageId = messageId;
            this.MarkAs = markAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMarkAsRequestDto" /> class.
        /// </summary>
        public MessageMarkAsRequestDto()
        {
        }
    }
}