
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManagedRuntimeDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ManagedRuntimeDtoProviderIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ManagedRuntimeDtoProviderId ProviderId { get; set; }

        /// <summary>
        /// ID of an existing Novu integration (kind: "agent") that holds the provider API key and provisioned environment. Create the integration first via POST /integrations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// ID of an existing agent on the provider platform. When set, Novu adopts the agent instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalAgentId")]
        public string? ExternalAgentId { get; set; }

        /// <summary>
        /// ID of an existing environment on the provider platform. When set, Novu adopts the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalEnvironmentId")]
        public string? ExternalEnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServers")]
        public global::System.Collections.Generic.IList<string>? McpServers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Novu.AgentSkillInputDto>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedRuntimeDto" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="integrationId">
        /// ID of an existing Novu integration (kind: "agent") that holds the provider API key and provisioned environment. Create the integration first via POST /integrations.
        /// </param>
        /// <param name="externalAgentId">
        /// ID of an existing agent on the provider platform. When set, Novu adopts the agent instead of creating a new one.
        /// </param>
        /// <param name="externalEnvironmentId">
        /// ID of an existing environment on the provider platform. When set, Novu adopts the environment.
        /// </param>
        /// <param name="model"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="tools"></param>
        /// <param name="mcpServers"></param>
        /// <param name="skills"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedRuntimeDto(
            global::Novu.ManagedRuntimeDtoProviderId providerId,
            string integrationId,
            string? externalAgentId,
            string? externalEnvironmentId,
            string? model,
            string? systemPrompt,
            global::System.Collections.Generic.IList<string>? tools,
            global::System.Collections.Generic.IList<string>? mcpServers,
            global::System.Collections.Generic.IList<global::Novu.AgentSkillInputDto>? skills)
        {
            this.ProviderId = providerId;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ExternalAgentId = externalAgentId;
            this.ExternalEnvironmentId = externalEnvironmentId;
            this.Model = model;
            this.SystemPrompt = systemPrompt;
            this.Tools = tools;
            this.McpServers = mcpServers;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedRuntimeDto" /> class.
        /// </summary>
        public ManagedRuntimeDto()
        {
        }

    }
}