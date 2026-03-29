
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePreviewResponseDtoResultVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter))]
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public global::Novu.ChatRenderOutput? Preview { get; set; }

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
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant7" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="preview"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePreviewResponseDtoResultVariant7(
            global::Novu.GeneratePreviewResponseDtoResultVariant7Type? type,
            global::Novu.ChatRenderOutput? preview,
            global::Novu.PreviewErrorDto? error)
        {
            this.Type = type;
            this.Preview = preview;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant7" /> class.
        /// </summary>
        public GeneratePreviewResponseDtoResultVariant7()
        {
        }
    }
}