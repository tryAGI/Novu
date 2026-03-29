
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailBlockStyles
    {
        /// <summary>
        /// Text alignment for the email block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textAlign")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TextAlignEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TextAlignEnum TextAlign { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBlockStyles" /> class.
        /// </summary>
        /// <param name="textAlign">
        /// Text alignment for the email block
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailBlockStyles(
            global::Novu.TextAlignEnum textAlign)
        {
            this.TextAlign = textAlign;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBlockStyles" /> class.
        /// </summary>
        public EmailBlockStyles()
        {
        }
    }
}