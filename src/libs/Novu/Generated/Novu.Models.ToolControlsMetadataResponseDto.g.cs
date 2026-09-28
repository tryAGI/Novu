
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolControlsMetadataResponseDto
    {
        /// <summary>
        /// JSON Schema for data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSchema")]
        public object? DataSchema { get; set; }

        /// <summary>
        /// UI Schema for rendering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiSchema")]
        public global::Novu.UiSchema? UiSchema { get; set; }

        /// <summary>
        /// Control values specific to Tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::Novu.ToolControlDto? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolControlsMetadataResponseDto" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// JSON Schema for data
        /// </param>
        /// <param name="uiSchema">
        /// UI Schema for rendering
        /// </param>
        /// <param name="values">
        /// Control values specific to Tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolControlsMetadataResponseDto(
            object? dataSchema,
            global::Novu.UiSchema? uiSchema,
            global::Novu.ToolControlDto? values)
        {
            this.DataSchema = dataSchema;
            this.UiSchema = uiSchema;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolControlsMetadataResponseDto" /> class.
        /// </summary>
        public ToolControlsMetadataResponseDto()
        {
        }

    }
}