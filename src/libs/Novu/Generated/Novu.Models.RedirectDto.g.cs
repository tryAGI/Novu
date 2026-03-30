
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RedirectDto
    {
        /// <summary>
        /// URL to redirect to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Target attribute for the redirect link
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
        /// URL to redirect to
        /// </param>
        /// <param name="target">
        /// Target attribute for the redirect link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedirectDto(
            string url,
            global::Novu.RedirectDtoTarget? target)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
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