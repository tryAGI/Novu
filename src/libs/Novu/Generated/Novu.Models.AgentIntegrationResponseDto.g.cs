
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentIntegrationResponseDto
    {
        /// <summary>
        /// Agent–integration link document id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.AgentIntegrationResponseIntegrationDto Integration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Set when the agent–integration link received its first inbound webhook delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedAt")]
        public object? ConnectedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Cloud only. `true` when this channel type (provider) falls outside the organization plan active-channel limit (by connection order). Active channels are counted per channel type, so multiple integrations of the same provider (e.g. several Slack workspaces) count as a single active channel. Over-limit channels keep their configuration but the agent will not respond on them until the plan is upgraded or older channel types are disconnected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceedsPlanLimit")]
        public bool? ExceedsPlanLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Agent–integration link document id.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="integration"></param>
        /// <param name="environmentId"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="connectedAt">
        /// Set when the agent–integration link received its first inbound webhook delivery.
        /// </param>
        /// <param name="exceedsPlanLimit">
        /// Cloud only. `true` when this channel type (provider) falls outside the organization plan active-channel limit (by connection order). Active channels are counted per channel type, so multiple integrations of the same provider (e.g. several Slack workspaces) count as a single active channel. Over-limit channels keep their configuration but the agent will not respond on them until the plan is upgraded or older channel types are disconnected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentIntegrationResponseDto(
            string id,
            string agentId,
            global::Novu.AgentIntegrationResponseIntegrationDto integration,
            string environmentId,
            string organizationId,
            string createdAt,
            string updatedAt,
            object? connectedAt,
            bool? exceedsPlanLimit)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ConnectedAt = connectedAt;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.ExceedsPlanLimit = exceedsPlanLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationResponseDto" /> class.
        /// </summary>
        public AgentIntegrationResponseDto()
        {
        }

    }
}