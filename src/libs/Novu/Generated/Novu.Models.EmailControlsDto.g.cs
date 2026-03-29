
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailControlsDto
    {
        /// <summary>
        /// Body of the layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Editor type of the layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.EmailControlsDtoEditorType EditorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailControlsDto" /> class.
        /// </summary>
        /// <param name="body">
        /// Body of the layout.
        /// </param>
        /// <param name="editorType">
        /// Editor type of the layout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailControlsDto(
            string body,
            global::Novu.EmailControlsDtoEditorType editorType)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.EditorType = editorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailControlsDto" /> class.
        /// </summary>
        public EmailControlsDto()
        {
        }
    }
}