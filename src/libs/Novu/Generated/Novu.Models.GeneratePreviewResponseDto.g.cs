
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePreviewResponseDto
    {
        /// <summary>
        /// Preview payload example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewPayloadExample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreviewPayloadDto PreviewPayloadExample { get; set; }

        /// <summary>
        /// The payload schema that was used to generate the preview payload example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Sample novu-signature header value for HTTP request steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("novuSignature")]
        public string? NovuSignature { get; set; }

        /// <summary>
        /// Preview result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9> Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDto" /> class.
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
        /// <param name="novuSignature">
        /// Sample novu-signature header value for HTTP request steps
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePreviewResponseDto(
            global::Novu.PreviewPayloadDto previewPayloadExample,
            global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9> result,
            object? schema,
            string? novuSignature)
        {
            this.PreviewPayloadExample = previewPayloadExample ?? throw new global::System.ArgumentNullException(nameof(previewPayloadExample));
            this.Schema = schema;
            this.NovuSignature = novuSignature;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDto" /> class.
        /// </summary>
        public GeneratePreviewResponseDto()
        {
        }
    }
}