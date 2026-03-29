
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelayControlsMetadataResponseDto
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
        /// Control values specific to Delay
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DelayControlDto Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayControlsMetadataResponseDto" /> class.
        /// </summary>
        /// <param name="values">
        /// Control values specific to Delay
        /// </param>
        /// <param name="dataSchema">
        /// JSON Schema for data
        /// </param>
        /// <param name="uiSchema">
        /// UI Schema for rendering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelayControlsMetadataResponseDto(
            global::Novu.DelayControlDto values,
            object? dataSchema,
            global::Novu.UiSchema? uiSchema)
        {
            this.DataSchema = dataSchema;
            this.UiSchema = uiSchema;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayControlsMetadataResponseDto" /> class.
        /// </summary>
        public DelayControlsMetadataResponseDto()
        {
        }
    }
}