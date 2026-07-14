
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignalDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SignalDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SignalDtoType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SignalDtoActionJsonConverter))]
        public global::Novu.SignalDtoAction? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public object? To { get; set; }

        /// <summary>
        /// 
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
        /// <param name="type"></param>
        /// <param name="action"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="workflowId"></param>
        /// <param name="to"></param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalDto(
            global::Novu.SignalDtoType type,
            global::Novu.SignalDtoAction? action,
            string? key,
            object? value,
            string? workflowId,
            object? to,
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