
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatStepUpsertDto
    {
        /// <summary>
        /// Database identifier of the step. Used for updating the step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique identifier for the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepId")]
        public string? StepId { get; set; }

        /// <summary>
        /// Name of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of the step<br/>
        /// Default Value: chat
        /// </summary>
        /// <default>global::Novu.StepTypeEnum.Chat</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.StepTypeEnum Type { get; set; } = global::Novu.StepTypeEnum.Chat;

        /// <summary>
        /// Control values for the Chat step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlValues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>))]
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? ControlValues { get; set; }

        /// <summary>
        /// Per-provider content overrides keyed by providerId. Stored separately from controlValues and merged over the default body at send time. Keys are ChatProviderIdEnum / ToolProviderIdEnum values (e.g. `slack`, `whatsapp-business`, `pagerduty`). Omit to leave unchanged; pass null to delete all provider overrides; pass an object to replace the full set.<br/>
        /// Example: {"slack":{"text":"{{payload.title}}","blocks":[{"type":"divider"}]},"whatsapp-business":{"type":"text","text":{"body":"{{payload.title}}"}},"pagerduty":{"severity":"warning","source":"novu","summary":"{{payload.title}}"}}
        /// </summary>
        /// <example>{"slack":{"text":"{{payload.title}}","blocks":[{"type":"divider"}]},"whatsapp-business":{"type":"text","text":{"body":"{{payload.title}}"}},"pagerduty":{"severity":"warning","source":"novu","summary":"{{payload.title}}"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOverrides")]
        public global::System.Collections.Generic.Dictionary<string, object>? ProviderOverrides { get; set; }

        /// <summary>
        /// Per-integration content overrides keyed by providerId, then by integration identifier. Each entry is merged over the matching providerOverrides entry, only for sends through that integration. Trigger-time overrides still take precedence. Entries whose integration does not exist in the environment are kept but not applied. Omit to leave unchanged; pass null to delete all integration overrides; pass an object to replace the full set.<br/>
        /// Example: {"tool-webhook":{"prod-alerts":{"alert_type":"incident"},"staging-alerts":{"alert_type":"test"}}}
        /// </summary>
        /// <example>{"tool-webhook":{"prod-alerts":{"alert_type":"incident"},"staging-alerts":{"alert_type":"test"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationOverrides")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object>>? IntegrationOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStepUpsertDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the step
        /// </param>
        /// <param name="type">
        /// Type of the step<br/>
        /// Default Value: chat
        /// </param>
        /// <param name="id">
        /// Database identifier of the step. Used for updating the step.
        /// </param>
        /// <param name="stepId">
        /// Unique identifier for the step
        /// </param>
        /// <param name="controlValues">
        /// Control values for the Chat step.
        /// </param>
        /// <param name="providerOverrides">
        /// Per-provider content overrides keyed by providerId. Stored separately from controlValues and merged over the default body at send time. Keys are ChatProviderIdEnum / ToolProviderIdEnum values (e.g. `slack`, `whatsapp-business`, `pagerduty`). Omit to leave unchanged; pass null to delete all provider overrides; pass an object to replace the full set.<br/>
        /// Example: {"slack":{"text":"{{payload.title}}","blocks":[{"type":"divider"}]},"whatsapp-business":{"type":"text","text":{"body":"{{payload.title}}"}},"pagerduty":{"severity":"warning","source":"novu","summary":"{{payload.title}}"}}
        /// </param>
        /// <param name="integrationOverrides">
        /// Per-integration content overrides keyed by providerId, then by integration identifier. Each entry is merged over the matching providerOverrides entry, only for sends through that integration. Trigger-time overrides still take precedence. Entries whose integration does not exist in the environment are kept but not applied. Omit to leave unchanged; pass null to delete all integration overrides; pass an object to replace the full set.<br/>
        /// Example: {"tool-webhook":{"prod-alerts":{"alert_type":"incident"},"staging-alerts":{"alert_type":"test"}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStepUpsertDto(
            string name,
            global::Novu.StepTypeEnum type,
            string? id,
            string? stepId,
            global::Novu.OneOf<global::Novu.ChatControlDto, object>? controlValues,
            global::System.Collections.Generic.Dictionary<string, object>? providerOverrides,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object>>? integrationOverrides)
        {
            this.Id = id;
            this.StepId = stepId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.ControlValues = controlValues;
            this.ProviderOverrides = providerOverrides;
            this.IntegrationOverrides = integrationOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStepUpsertDto" /> class.
        /// </summary>
        public ChatStepUpsertDto()
        {
        }

    }
}