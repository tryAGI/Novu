
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateLayoutPreviewResponseDtoResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter))]
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public global::Novu.EmailLayoutRenderOutput? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLayoutPreviewResponseDtoResult" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="preview"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateLayoutPreviewResponseDtoResult(
            global::Novu.GenerateLayoutPreviewResponseDtoResultType? type,
            global::Novu.EmailLayoutRenderOutput? preview)
        {
            this.Type = type;
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLayoutPreviewResponseDtoResult" /> class.
        /// </summary>
        public GenerateLayoutPreviewResponseDtoResult()
        {
        }
    }
}