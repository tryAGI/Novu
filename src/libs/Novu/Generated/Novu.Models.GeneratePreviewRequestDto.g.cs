
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePreviewRequestDto
    {
        /// <summary>
        /// Optional control values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlValues")]
        public object? ControlValues { get; set; }

        /// <summary>
        /// Optional payload for preview generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewPayload")]
        public global::Novu.PreviewPayloadDto? PreviewPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewRequestDto" /> class.
        /// </summary>
        /// <param name="controlValues">
        /// Optional control values
        /// </param>
        /// <param name="previewPayload">
        /// Optional payload for preview generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePreviewRequestDto(
            object? controlValues,
            global::Novu.PreviewPayloadDto? previewPayload)
        {
            this.ControlValues = controlValues;
            this.PreviewPayload = previewPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewRequestDto" /> class.
        /// </summary>
        public GeneratePreviewRequestDto()
        {
        }
    }
}