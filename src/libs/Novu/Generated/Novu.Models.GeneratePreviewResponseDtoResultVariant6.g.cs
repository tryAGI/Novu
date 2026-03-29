
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePreviewResponseDtoResultVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter))]
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public global::Novu.PushRenderOutput? Preview { get; set; }

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
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant6" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="preview"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePreviewResponseDtoResultVariant6(
            global::Novu.GeneratePreviewResponseDtoResultVariant6Type? type,
            global::Novu.PushRenderOutput? preview,
            global::Novu.PreviewErrorDto? error)
        {
            this.Type = type;
            this.Preview = preview;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant6" /> class.
        /// </summary>
        public GeneratePreviewResponseDtoResultVariant6()
        {
        }
    }
}