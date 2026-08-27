
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TriggerSignalDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TriggerSignalDtoTypeJsonConverter))]
        public global::Novu.TriggerSignalDtoType Type { get; set; }

        /// <summary>
        /// Workflow identifier (same string used with `events.trigger`).<br/>
        /// Example: order-shipped
        /// </summary>
        /// <example>order-shipped</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Recipient(s). Accepts a subscriberId string, subscriber object, topic object, or an array of those. When omitted, Novu falls back to the conversation subscriber.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>))]
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? To { get; set; }

        /// <summary>
        /// Arbitrary payload forwarded to the workflow.<br/>
        /// Example: {"orderId":"ORD-42"}
        /// </summary>
        /// <example>{"orderId":"ORD-42"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSignalDto" /> class.
        /// </summary>
        /// <param name="workflowId">
        /// Workflow identifier (same string used with `events.trigger`).<br/>
        /// Example: order-shipped
        /// </param>
        /// <param name="type"></param>
        /// <param name="to">
        /// Recipient(s). Accepts a subscriberId string, subscriber object, topic object, or an array of those. When omitted, Novu falls back to the conversation subscriber.
        /// </param>
        /// <param name="payload">
        /// Arbitrary payload forwarded to the workflow.<br/>
        /// Example: {"orderId":"ORD-42"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerSignalDto(
            string workflowId,
            global::Novu.TriggerSignalDtoType type,
            global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? to,
            object? payload)
        {
            this.Type = type;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.To = to;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSignalDto" /> class.
        /// </summary>
        public TriggerSignalDto()
        {
        }

    }
}