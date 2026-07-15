
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataDeleteSignalDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MetadataDeleteSignalDtoTypeJsonConverter))]
        public global::Novu.MetadataDeleteSignalDtoType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MetadataDeleteSignalDtoActionJsonConverter))]
        public global::Novu.MetadataDeleteSignalDtoAction Action { get; set; }

        /// <summary>
        /// Metadata key to remove.<br/>
        /// Example: crm:ticketId
        /// </summary>
        /// <example>crm:ticketId</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataDeleteSignalDto" /> class.
        /// </summary>
        /// <param name="key">
        /// Metadata key to remove.<br/>
        /// Example: crm:ticketId
        /// </param>
        /// <param name="type"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataDeleteSignalDto(
            string key,
            global::Novu.MetadataDeleteSignalDtoType type,
            global::Novu.MetadataDeleteSignalDtoAction action)
        {
            this.Type = type;
            this.Action = action;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataDeleteSignalDto" /> class.
        /// </summary>
        public MetadataDeleteSignalDto()
        {
        }

    }
}