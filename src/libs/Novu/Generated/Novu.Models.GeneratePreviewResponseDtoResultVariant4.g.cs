
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePreviewResponseDtoResultVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter))]
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public global::Novu.InAppRenderOutput? Preview { get; set; }

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
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="preview"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePreviewResponseDtoResultVariant4(
            global::Novu.GeneratePreviewResponseDtoResultVariant4Type? type,
            global::Novu.InAppRenderOutput? preview,
            global::Novu.PreviewErrorDto? error)
        {
            this.Type = type;
            this.Preview = preview;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePreviewResponseDtoResultVariant4" /> class.
        /// </summary>
        public GeneratePreviewResponseDtoResultVariant4()
        {
        }
    }
}