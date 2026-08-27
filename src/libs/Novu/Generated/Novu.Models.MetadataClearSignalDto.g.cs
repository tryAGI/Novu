
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetadataClearSignalDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MetadataClearSignalDtoTypeJsonConverter))]
        public global::Novu.MetadataClearSignalDtoType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MetadataClearSignalDtoActionJsonConverter))]
        public global::Novu.MetadataClearSignalDtoAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataClearSignalDto" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataClearSignalDto(
            global::Novu.MetadataClearSignalDtoType type,
            global::Novu.MetadataClearSignalDtoAction action)
        {
            this.Type = type;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataClearSignalDto" /> class.
        /// </summary>
        public MetadataClearSignalDto()
        {
        }

    }
}