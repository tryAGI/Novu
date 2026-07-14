
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        public global::Novu.AgentBehaviorDto? Behavior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Production bridge URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bridgeUrl")]
        public string? BridgeUrl { get; set; }

        /// <summary>
        /// Development bridge URL (set by npx novu dev)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devBridgeUrl")]
        public string? DevBridgeUrl { get; set; }

        /// <summary>
        /// Whether the dev bridge override is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devBridgeActive")]
        public bool? DevBridgeActive { get; set; }

        /// <summary>
        /// Whether the agent brain is self-hosted (bridge) or managed by a third-party provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AgentResponseDtoRuntimeJsonConverter))]
        public global::Novu.AgentResponseDtoRuntime? Runtime { get; set; }

        /// <summary>
        /// Discovery scope of the agent. Always `public` today; reserved for the upcoming private-agents feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AgentResponseDtoVisibilityJsonConverter))]
        public global::Novu.AgentResponseDtoVisibility? Visibility { get; set; }

        /// <summary>
        /// Present when runtime is "managed". Contains provider and external identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRuntime")]
        public global::Novu.ManagedRuntimeResponseDto? ManagedRuntime { get; set; }

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
        /// Mongo user id of the user who created the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationSummaryDto>? Integrations { get; set; }

        /// <summary>
        /// Cloud only. `true` when the agent falls outside the organization plan agent limit (by creation order among active agents — inactive agents do not consume slots). Only plan limits produce this flag — system-capped organizations (enterprise/unlimited tiers) are never over-limit. Over-limit agents are still stored but will not respond to inbound messages until the plan is upgraded or older agents are deactivated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceedsPlanLimit")]
        public bool? ExceedsPlanLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="identifier"></param>
        /// <param name="active"></param>
        /// <param name="environmentId"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="behavior"></param>
        /// <param name="bridgeUrl">
        /// Production bridge URL
        /// </param>
        /// <param name="devBridgeUrl">
        /// Development bridge URL (set by npx novu dev)
        /// </param>
        /// <param name="devBridgeActive">
        /// Whether the dev bridge override is active
        /// </param>
        /// <param name="runtime">
        /// Whether the agent brain is self-hosted (bridge) or managed by a third-party provider
        /// </param>
        /// <param name="visibility">
        /// Discovery scope of the agent. Always `public` today; reserved for the upcoming private-agents feature.
        /// </param>
        /// <param name="managedRuntime">
        /// Present when runtime is "managed". Contains provider and external identifiers.
        /// </param>
        /// <param name="createdBy">
        /// Mongo user id of the user who created the agent
        /// </param>
        /// <param name="integrations"></param>
        /// <param name="exceedsPlanLimit">
        /// Cloud only. `true` when the agent falls outside the organization plan agent limit (by creation order among active agents — inactive agents do not consume slots). Only plan limits produce this flag — system-capped organizations (enterprise/unlimited tiers) are never over-limit. Over-limit agents are still stored but will not respond to inbound messages until the plan is upgraded or older agents are deactivated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentResponseDto(
            string id,
            string name,
            string identifier,
            bool active,
            string environmentId,
            string organizationId,
            string createdAt,
            string updatedAt,
            string? description,
            global::Novu.AgentBehaviorDto? behavior,
            string? bridgeUrl,
            string? devBridgeUrl,
            bool? devBridgeActive,
            global::Novu.AgentResponseDtoRuntime? runtime,
            global::Novu.AgentResponseDtoVisibility? visibility,
            global::Novu.ManagedRuntimeResponseDto? managedRuntime,
            string? createdBy,
            global::System.Collections.Generic.IList<global::Novu.AgentIntegrationSummaryDto>? integrations,
            bool? exceedsPlanLimit)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Description = description;
            this.Behavior = behavior;
            this.Active = active;
            this.BridgeUrl = bridgeUrl;
            this.DevBridgeUrl = devBridgeUrl;
            this.DevBridgeActive = devBridgeActive;
            this.Runtime = runtime;
            this.Visibility = visibility;
            this.ManagedRuntime = managedRuntime;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Integrations = integrations;
            this.ExceedsPlanLimit = exceedsPlanLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDto" /> class.
        /// </summary>
        public AgentResponseDto()
        {
        }

    }
}