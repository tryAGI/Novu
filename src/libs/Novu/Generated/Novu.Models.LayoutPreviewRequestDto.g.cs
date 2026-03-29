
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutPreviewRequestDto
    {
        /// <summary>
        /// Optional control values for layout preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlValues")]
        public object? ControlValues { get; set; }

        /// <summary>
        /// Optional payload for layout preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewPayload")]
        public global::Novu.LayoutPreviewPayloadDto? PreviewPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutPreviewRequestDto" /> class.
        /// </summary>
        /// <param name="controlValues">
        /// Optional control values for layout preview
        /// </param>
        /// <param name="previewPayload">
        /// Optional payload for layout preview
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutPreviewRequestDto(
            object? controlValues,
            global::Novu.LayoutPreviewPayloadDto? previewPayload)
        {
            this.ControlValues = controlValues;
            this.PreviewPayload = previewPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutPreviewRequestDto" /> class.
        /// </summary>
        public LayoutPreviewRequestDto()
        {
        }
    }
}