
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicPayloadDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TriggerRecipientsTypeEnum Type { get; set; }

        /// <summary>
        /// Optional array of subscriber IDs to exclude from the topic trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicPayloadDto" /> class.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="type"></param>
        /// <param name="exclude">
        /// Optional array of subscriber IDs to exclude from the topic trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicPayloadDto(
            string topicKey,
            global::Novu.TriggerRecipientsTypeEnum type,
            global::System.Collections.Generic.IList<string>? exclude)
        {
            this.TopicKey = topicKey ?? throw new global::System.ArgumentNullException(nameof(topicKey));
            this.Type = type;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicPayloadDto" /> class.
        /// </summary>
        public TopicPayloadDto()
        {
        }
    }
}