
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerEventRequestDto
    {
        /// <summary>
        /// The trigger identifier of the workflow you wish to send. This identifier can be found on the workflow page.<br/>
        /// Example: workflow_identifier
        /// </summary>
        /// <example>workflow_identifier</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// The payload object is used to pass additional custom information that could be <br/>
        ///     used to render the workflow, or perform routing rules based on it. <br/>
        ///       This data will also be available when fetching the notifications feed from the API to display certain parts of the UI.<br/>
        /// Example: {"comment_id":"string","post":{"text":"string"}}
        /// </summary>
        /// <example>{"comment_id":"string","post":{"text":"string"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// This could be used to override provider specific configurations<br/>
        /// Example: {"fcm":{"data":{"key":"value"}}}
        /// </summary>
        /// <example>{"fcm":{"data":{"key":"value"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::Novu.TriggerOverrides? Overrides { get; set; }

        /// <summary>
        /// The recipients list of people who will receive the notification. Maximum number of recipients can be 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto> To { get; set; }

        /// <summary>
        /// A unique identifier for deduplication. If the same **transactionId** is sent again, <br/>
        ///       the trigger is ignored. Useful to prevent duplicate notifications. The retention period depends on your billing tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// It is used to display the Avatar of the provided actor's subscriber id or actor object.<br/>
        ///     If a new actor object is provided, we will create a new subscriber in our system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>))]
        public global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? Actor { get; set; }

        /// <summary>
        /// It is used to specify a tenant context during trigger event.<br/>
        ///     Existing tenants will be updated with the provided details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>))]
        public global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventRequestDto" /> class.
        /// </summary>
        /// <param name="workflowId">
        /// The trigger identifier of the workflow you wish to send. This identifier can be found on the workflow page.<br/>
        /// Example: workflow_identifier
        /// </param>
        /// <param name="to">
        /// The recipients list of people who will receive the notification. Maximum number of recipients can be 100.
        /// </param>
        /// <param name="payload">
        /// The payload object is used to pass additional custom information that could be <br/>
        ///     used to render the workflow, or perform routing rules based on it. <br/>
        ///       This data will also be available when fetching the notifications feed from the API to display certain parts of the UI.<br/>
        /// Example: {"comment_id":"string","post":{"text":"string"}}
        /// </param>
        /// <param name="overrides">
        /// This could be used to override provider specific configurations<br/>
        /// Example: {"fcm":{"data":{"key":"value"}}}
        /// </param>
        /// <param name="transactionId">
        /// A unique identifier for deduplication. If the same **transactionId** is sent again, <br/>
        ///       the trigger is ignored. Useful to prevent duplicate notifications. The retention period depends on your billing tier.
        /// </param>
        /// <param name="actor">
        /// It is used to display the Avatar of the provided actor's subscriber id or actor object.<br/>
        ///     If a new actor object is provided, we will create a new subscriber in our system
        /// </param>
        /// <param name="tenant">
        /// It is used to specify a tenant context during trigger event.<br/>
        ///     Existing tenants will be updated with the provided details.
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerEventRequestDto(
            string workflowId,
            global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto> to,
            object? payload,
            global::Novu.TriggerOverrides? overrides,
            string? transactionId,
            global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? actor,
            global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? tenant,
            object? context)
        {
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Payload = payload;
            this.Overrides = overrides;
            this.To = to;
            this.TransactionId = transactionId;
            this.Actor = actor;
            this.Tenant = tenant;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventRequestDto" /> class.
        /// </summary>
        public TriggerEventRequestDto()
        {
        }
    }
}