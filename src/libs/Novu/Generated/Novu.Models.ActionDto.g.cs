
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionDto
    {
        /// <summary>
        /// Label for the action button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Redirect configuration for the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Novu.RedirectDto? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDto" /> class.
        /// </summary>
        /// <param name="label">
        /// Label for the action button.
        /// </param>
        /// <param name="redirect">
        /// Redirect configuration for the action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionDto(
            string? label,
            global::Novu.RedirectDto? redirect)
        {
            this.Label = label;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDto" /> class.
        /// </summary>
        public ActionDto()
        {
        }
    }
}