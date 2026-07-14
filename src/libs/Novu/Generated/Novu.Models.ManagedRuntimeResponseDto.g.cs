
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManagedRuntimeResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalAgentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalAgentId { get; set; }

        /// <summary>
        /// The provider-side environment that hosts this agent. Hydrated from the linked integration credentials. Absent when the integration has not been provisioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalEnvironmentId")]
        public string? ExternalEnvironmentId { get; set; }

        /// <summary>
        /// The provider-side workspace id used in console deep links. Defaults to `'default'` (the auto-created Default Workspace). Hydrated from the linked integration credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalWorkspaceId")]
        public string? ExternalWorkspaceId { get; set; }

        /// <summary>
        /// Deep link to the agent in the provider console (e.g. platform.claude.com).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consoleUrl")]
        public string? ConsoleUrl { get; set; }

        /// <summary>
        /// Live tools enabled on the managed-runtime provider for this agent. Sourced from the provider on read; omitted when the provider is temporarily unreachable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Novu.AgentToolDto>? Tools { get; set; }

        /// <summary>
        /// MCP servers enabled on this agent, projected onto the runtime catalog `{ externalId, name, url }` shape. Mongo is the source of truth; the projection matches what the provider sees. Omitted when the provider read fails after a managed-agent write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServers")]
        public global::System.Collections.Generic.IList<global::Novu.AgentMcpServerDto>? McpServers { get; set; }

        /// <summary>
        /// System prompt used when invoking the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedRuntimeResponseDto" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="integrationId"></param>
        /// <param name="externalAgentId"></param>
        /// <param name="externalEnvironmentId">
        /// The provider-side environment that hosts this agent. Hydrated from the linked integration credentials. Absent when the integration has not been provisioned.
        /// </param>
        /// <param name="externalWorkspaceId">
        /// The provider-side workspace id used in console deep links. Defaults to `'default'` (the auto-created Default Workspace). Hydrated from the linked integration credentials.
        /// </param>
        /// <param name="consoleUrl">
        /// Deep link to the agent in the provider console (e.g. platform.claude.com).
        /// </param>
        /// <param name="tools">
        /// Live tools enabled on the managed-runtime provider for this agent. Sourced from the provider on read; omitted when the provider is temporarily unreachable.
        /// </param>
        /// <param name="mcpServers">
        /// MCP servers enabled on this agent, projected onto the runtime catalog `{ externalId, name, url }` shape. Mongo is the source of truth; the projection matches what the provider sees. Omitted when the provider read fails after a managed-agent write.
        /// </param>
        /// <param name="systemPrompt">
        /// System prompt used when invoking the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedRuntimeResponseDto(
            string providerId,
            string integrationId,
            string externalAgentId,
            string? externalEnvironmentId,
            string? externalWorkspaceId,
            string? consoleUrl,
            global::System.Collections.Generic.IList<global::Novu.AgentToolDto>? tools,
            global::System.Collections.Generic.IList<global::Novu.AgentMcpServerDto>? mcpServers,
            string? systemPrompt)
        {
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ExternalAgentId = externalAgentId ?? throw new global::System.ArgumentNullException(nameof(externalAgentId));
            this.ExternalEnvironmentId = externalEnvironmentId;
            this.ExternalWorkspaceId = externalWorkspaceId;
            this.ConsoleUrl = consoleUrl;
            this.Tools = tools;
            this.McpServers = mcpServers;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedRuntimeResponseDto" /> class.
        /// </summary>
        public ManagedRuntimeResponseDto()
        {
        }

    }
}