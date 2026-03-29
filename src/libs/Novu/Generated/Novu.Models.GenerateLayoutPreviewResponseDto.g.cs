
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateLayoutPreviewResponseDto
    {
        /// <summary>
        /// Preview payload example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewPayloadExample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.LayoutPreviewPayloadDto PreviewPayloadExample { get; set; }

        /// <summary>
        /// The payload schema that was used to generate the preview payload example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Preview result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.GenerateLayoutPreviewResponseDtoResult Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLayoutPreviewResponseDto" /> class.
        /// </summary>
        /// <param name="previewPayloadExample">
        /// Preview payload example
        /// </param>
        /// <param name="result">
        /// Preview result
        /// </param>
        /// <param name="schema">
        /// The payload schema that was used to generate the preview payload example
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateLayoutPreviewResponseDto(
            global::Novu.LayoutPreviewPayloadDto previewPayloadExample,
            global::Novu.GenerateLayoutPreviewResponseDtoResult result,
            object? schema)
        {
            this.PreviewPayloadExample = previewPayloadExample ?? throw new global::System.ArgumentNullException(nameof(previewPayloadExample));
            this.Schema = schema;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLayoutPreviewResponseDto" /> class.
        /// </summary>
        public GenerateLayoutPreviewResponseDto()
        {
        }
    }
}