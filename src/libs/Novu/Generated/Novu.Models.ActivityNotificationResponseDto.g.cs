
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityNotificationResponseDto
    {
        /// <summary>
        /// Unique identifier of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Environment ID of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Organization ID of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Subscriber ID of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Transaction ID of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// Template ID of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Digested Notification ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_digestedNotificationId")]
        public string? DigestedNotificationId { get; set; }

        /// <summary>
        /// Creation time of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Last updated time of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Novu.StepTypeEnum>? Channels { get; set; }

        /// <summary>
        /// Subscriber of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.ActivityNotificationSubscriberResponseDto? Subscriber { get; set; }

        /// <summary>
        /// Template of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Novu.ActivityNotificationTemplateResponseDto? Template { get; set; }

        /// <summary>
        /// Jobs of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::System.Collections.Generic.IList<global::Novu.ActivityNotificationJobResponseDto>? Jobs { get; set; }

        /// <summary>
        /// Payload of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Tags associated with the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Controls associated with the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public object? Controls { get; set; }

        /// <summary>
        /// To field for subscriber definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public object? To { get; set; }

        /// <summary>
        /// Topics of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Novu.ActivityTopicDto>? Topics { get; set; }

        /// <summary>
        /// Severity of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        public global::Novu.SeverityLevelEnum? Severity { get; set; }

        /// <summary>
        /// Criticality of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        public bool? Critical { get; set; }

        /// <summary>
        /// Context (single or multi) in which the notification was sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationResponseDto" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// Environment ID of the notification
        /// </param>
        /// <param name="organizationId">
        /// Organization ID of the notification
        /// </param>
        /// <param name="subscriberId">
        /// Subscriber ID of the notification
        /// </param>
        /// <param name="transactionId">
        /// Transaction ID of the notification
        /// </param>
        /// <param name="id">
        /// Unique identifier of the notification
        /// </param>
        /// <param name="templateId">
        /// Template ID of the notification
        /// </param>
        /// <param name="digestedNotificationId">
        /// Digested Notification ID
        /// </param>
        /// <param name="createdAt">
        /// Creation time of the notification
        /// </param>
        /// <param name="updatedAt">
        /// Last updated time of the notification
        /// </param>
        /// <param name="channels"></param>
        /// <param name="subscriber">
        /// Subscriber of the notification
        /// </param>
        /// <param name="template">
        /// Template of the notification
        /// </param>
        /// <param name="jobs">
        /// Jobs of the notification
        /// </param>
        /// <param name="payload">
        /// Payload of the notification
        /// </param>
        /// <param name="tags">
        /// Tags associated with the notification
        /// </param>
        /// <param name="controls">
        /// Controls associated with the notification
        /// </param>
        /// <param name="to">
        /// To field for subscriber definition
        /// </param>
        /// <param name="topics">
        /// Topics of the notification
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
        /// <param name="critical">
        /// Criticality of the notification
        /// </param>
        /// <param name="contextKeys">
        /// Context (single or multi) in which the notification was sent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityNotificationResponseDto(
            string environmentId,
            string organizationId,
            string subscriberId,
            string transactionId,
            string? id,
            string? templateId,
            string? digestedNotificationId,
            string? createdAt,
            string? updatedAt,
            global::System.Collections.Generic.IList<global::Novu.StepTypeEnum>? channels,
            global::Novu.ActivityNotificationSubscriberResponseDto? subscriber,
            global::Novu.ActivityNotificationTemplateResponseDto? template,
            global::System.Collections.Generic.IList<global::Novu.ActivityNotificationJobResponseDto>? jobs,
            object? payload,
            global::System.Collections.Generic.IList<string>? tags,
            object? controls,
            object? to,
            global::System.Collections.Generic.IList<global::Novu.ActivityTopicDto>? topics,
            global::Novu.SeverityLevelEnum? severity,
            bool? critical,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.Id = id;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.TemplateId = templateId;
            this.DigestedNotificationId = digestedNotificationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Channels = channels;
            this.Subscriber = subscriber;
            this.Template = template;
            this.Jobs = jobs;
            this.Payload = payload;
            this.Tags = tags;
            this.Controls = controls;
            this.To = to;
            this.Topics = topics;
            this.Severity = severity;
            this.Critical = critical;
            this.ContextKeys = contextKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationResponseDto" /> class.
        /// </summary>
        public ActivityNotificationResponseDto()
        {
        }
    }
}