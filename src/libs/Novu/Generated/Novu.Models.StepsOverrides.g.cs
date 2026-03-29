
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepsOverrides
    {
        /// <summary>
        /// Passing the provider id and the provider specific configurations<br/>
        /// Example: {"sendgrid":{"templateId":"1234567890"}}
        /// </summary>
        /// <example>{"sendgrid":{"templateId":"1234567890"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, object>? Providers { get; set; }

        /// <summary>
        /// Override the or remove the layout for this specific step<br/>
        /// Example: welcome-email-layout
        /// </summary>
        /// <example>welcome-email-layout</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layoutId")]
        public string? LayoutId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepsOverrides" /> class.
        /// </summary>
        /// <param name="providers">
        /// Passing the provider id and the provider specific configurations<br/>
        /// Example: {"sendgrid":{"templateId":"1234567890"}}
        /// </param>
        /// <param name="layoutId">
        /// Override the or remove the layout for this specific step<br/>
        /// Example: welcome-email-layout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepsOverrides(
            global::System.Collections.Generic.Dictionary<string, object>? providers,
            string? layoutId)
        {
            this.Providers = providers;
            this.LayoutId = layoutId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepsOverrides" /> class.
        /// </summary>
        public StepsOverrides()
        {
        }
    }
}