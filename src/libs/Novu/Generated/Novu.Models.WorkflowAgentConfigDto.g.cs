
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowAgentConfigDto
    {
        /// <summary>
        /// Public agent identifier used to route this workflow through an agent's connected channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Optional per-provider overrides keyed by providerId (e.g. novu-email-agent). Today only Novu Email replyTo is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>? Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAgentConfigDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Public agent identifier used to route this workflow through an agent's connected channels.
        /// </param>
        /// <param name="providers">
        /// Optional per-provider overrides keyed by providerId (e.g. novu-email-agent). Today only Novu Email replyTo is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowAgentConfigDto(
            string identifier,
            global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>? providers)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Providers = providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAgentConfigDto" /> class.
        /// </summary>
        public WorkflowAgentConfigDto()
        {
        }

    }
}