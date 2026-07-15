
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignalDto
    {
        /// <summary>
        /// `metadata` updates conversation state; `trigger` fires a Novu workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SignalDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SignalDtoType Type { get; set; }

        /// <summary>
        /// Required for metadata signals other than the default `set`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SignalDtoActionJsonConverter))]
        public global::Novu.SignalDtoAction? Action { get; set; }

        /// <summary>
        /// Metadata key for `set` / `delete` actions.<br/>
        /// Example: crm:ticketId
        /// </summary>
        /// <example>crm:ticketId</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Value for metadata `set` actions. JSON-serializable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Workflow identifier for `trigger` signals.<br/>
        /// Example: order-shipped
        /// </summary>
        /// <example>order-shipped</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Trigger recipients. SubscriberId string, subscriber/topic object, or array. Falls back to the conversation subscriber when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>))]
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? To { get; set; }

        /// <summary>
        /// Workflow payload for `trigger` signals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalDto" /> class.
        /// </summary>
        /// <param name="type">
        /// `metadata` updates conversation state; `trigger` fires a Novu workflow.
        /// </param>
        /// <param name="action">
        /// Required for metadata signals other than the default `set`.
        /// </param>
        /// <param name="key">
        /// Metadata key for `set` / `delete` actions.<br/>
        /// Example: crm:ticketId
        /// </param>
        /// <param name="value">
        /// Value for metadata `set` actions. JSON-serializable.
        /// </param>
        /// <param name="workflowId">
        /// Workflow identifier for `trigger` signals.<br/>
        /// Example: order-shipped
        /// </param>
        /// <param name="to">
        /// Trigger recipients. SubscriberId string, subscriber/topic object, or array. Falls back to the conversation subscriber when omitted.
        /// </param>
        /// <param name="payload">
        /// Workflow payload for `trigger` signals.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalDto(
            global::Novu.SignalDtoType type,
            global::Novu.SignalDtoAction? action,
            string? key,
            object? value,
            string? workflowId,
            global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? to,
            object? payload)
        {
            this.Type = type;
            this.Action = action;
            this.Key = key;
            this.Value = value;
            this.WorkflowId = workflowId;
            this.To = to;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalDto" /> class.
        /// </summary>
        public SignalDto()
        {
        }

    }
}