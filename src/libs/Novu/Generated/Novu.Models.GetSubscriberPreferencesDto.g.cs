
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriberPreferencesDto
    {
        /// <summary>
        /// Global preference settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberGlobalPreferenceDto Global { get; set; }

        /// <summary>
        /// Workflow-specific preference settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto> Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriberPreferencesDto" /> class.
        /// </summary>
        /// <param name="global">
        /// Global preference settings
        /// </param>
        /// <param name="workflows">
        /// Workflow-specific preference settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSubscriberPreferencesDto(
            global::Novu.SubscriberGlobalPreferenceDto global,
            global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto> workflows)
        {
            this.Global = global ?? throw new global::System.ArgumentNullException(nameof(global));
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriberPreferencesDto" /> class.
        /// </summary>
        public GetSubscriberPreferencesDto()
        {
        }
    }
}