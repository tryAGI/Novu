
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePreviewResponseDtoResultVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter))]
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public global::Novu.SmsRenderOutput? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Novu.PreviewErrorDto? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant5" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="preview"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePreviewResponseDtoResultVariant5(
            global::Novu.GeneratePreviewResponseDtoResultVariant5Type? type,
            global::Novu.SmsRenderOutput? preview,
            global::Novu.PreviewErrorDto? error)
        {
            this.Type = type;
            this.Preview = preview;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant5" /> class.
        /// </summary>
        public GeneratePreviewResponseDtoResultVariant5()
        {
        }
    }
}