
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowWebhookTriggerDto
    {
        /// <summary>
        /// Trigger type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TriggerTypeEnumJsonConverter))]
        public global::Novu.TriggerTypeEnum Type { get; set; }

        /// <summary>
        /// Trigger identifier used when firing the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Payload variables declared on the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerVariableDto> Variables { get; set; }

        /// <summary>
        /// Subscriber variables declared on the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberVariables")]
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookSubscriberVariableDto>? SubscriberVariables { get; set; }

        /// <summary>
        /// Reserved variables declared on the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservedVariables")]
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookReservedVariableDto>? ReservedVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWebhookTriggerDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Trigger identifier used when firing the workflow
        /// </param>
        /// <param name="variables">
        /// Payload variables declared on the trigger
        /// </param>
        /// <param name="type">
        /// Trigger type
        /// </param>
        /// <param name="subscriberVariables">
        /// Subscriber variables declared on the trigger
        /// </param>
        /// <param name="reservedVariables">
        /// Reserved variables declared on the trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowWebhookTriggerDto(
            string identifier,
            global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerVariableDto> variables,
            global::Novu.TriggerTypeEnum type,
            global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookSubscriberVariableDto>? subscriberVariables,
            global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookReservedVariableDto>? reservedVariables)
        {
            this.Type = type;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.SubscriberVariables = subscriberVariables;
            this.ReservedVariables = reservedVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWebhookTriggerDto" /> class.
        /// </summary>
        public WorkflowWebhookTriggerDto()
        {
        }

    }
}