
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RedirectDto
    {
        /// <summary>
        /// URL for redirection. Must be a valid URL or start with / or {{ variable }}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Target window for the redirection.<br/>
        /// Default Value: _self
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.RedirectDtoTargetJsonConverter))]
        public global::Novu.RedirectDtoTarget? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectDto" /> class.
        /// </summary>
        /// <param name="url">
        /// URL for redirection. Must be a valid URL or start with / or {{ variable }}.
        /// </param>
        /// <param name="target">
        /// Target window for the redirection.<br/>
        /// Default Value: _self
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedirectDto(
            string? url,
            global::Novu.RedirectDtoTarget? target)
        {
            this.Url = url;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectDto" /> class.
        /// </summary>
        public RedirectDto()
        {
        }
    }
}