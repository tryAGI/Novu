
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageWebhookResponseDto
    {
        /// <summary>
        /// Database identifier of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Database identifier of the workflow that produced the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Environment identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Organization identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Database identifier of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_notificationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationId { get; set; }

        /// <summary>
        /// Subscriber identifier supplied by the producer. Direct send and Inbox events use the external subscriber identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorSubscriber")]
        public global::Novu.MessageWebhookActorSubscriberDto? ActorSubscriber { get; set; }

        /// <summary>
        /// Workflow identifier used when triggering the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateIdentifier { get; set; }

        /// <summary>
        /// Same as `templateIdentifier`. Included for correlation with workflow events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Step identifier used when correlating with workflow steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepId")]
        public string? StepId { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Archive timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedAt")]
        public string? ArchivedAt { get; set; }

        /// <summary>
        /// Whether the message is archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Trigger transaction identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// Channel the message was sent on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChannelTypeEnum Channel { get; set; }

        /// <summary>
        /// Whether the message has been seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Seen { get; set; }

        /// <summary>
        /// Whether the message has been read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// When set, the Inbox message is snoozed until this timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoozedUntil")]
        public string? SnoozedUntil { get; set; }

        /// <summary>
        /// Delivery timestamps recorded for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveredAt")]
        public global::System.Collections.Generic.IList<string>? DeliveredAt { get; set; }

        /// <summary>
        /// Provider identifier that delivered the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// Last time the message was seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSeenDate")]
        public string? LastSeenDate { get; set; }

        /// <summary>
        /// First time the message was seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSeenDate")]
        public string? FirstSeenDate { get; set; }

        /// <summary>
        /// Last time the message was read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastReadDate")]
        public string? LastReadDate { get; set; }

        /// <summary>
        /// Delivery status stored on the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MessageWebhookStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageWebhookStatusEnum Status { get; set; }

        /// <summary>
        /// Provider or internal error identifier when delivery failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorId")]
        public string? ErrorId { get; set; }

        /// <summary>
        /// Provider or internal error text when delivery failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorText")]
        public string? ErrorText { get; set; }

        /// <summary>
        /// Context keys associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Provider response identifier for the send attempt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerResponseId")]
        public string? ProviderResponseId { get; set; }

        /// <summary>
        /// Device token used for a push send
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceToken")]
        public string? DeviceToken { get; set; }

        /// <summary>
        /// Deprecated, use `channelData`. Chat webhook URL used for the send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelData")]
        public global::Novu.MessageWebhookChannelDataDto? ChannelData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Database identifier of the message
        /// </param>
        /// <param name="templateId">
        /// Database identifier of the workflow that produced the message
        /// </param>
        /// <param name="environmentId">
        /// Environment identifier
        /// </param>
        /// <param name="organizationId">
        /// Organization identifier
        /// </param>
        /// <param name="notificationId">
        /// Database identifier of the notification
        /// </param>
        /// <param name="subscriberId">
        /// Subscriber identifier supplied by the producer. Direct send and Inbox events use the external subscriber identifier.
        /// </param>
        /// <param name="templateIdentifier">
        /// Workflow identifier used when triggering the workflow
        /// </param>
        /// <param name="workflowId">
        /// Same as `templateIdentifier`. Included for correlation with workflow events.
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Last updated timestamp
        /// </param>
        /// <param name="archived">
        /// Whether the message is archived
        /// </param>
        /// <param name="transactionId">
        /// Trigger transaction identifier
        /// </param>
        /// <param name="channel">
        /// Channel the message was sent on
        /// </param>
        /// <param name="seen">
        /// Whether the message has been seen
        /// </param>
        /// <param name="read">
        /// Whether the message has been read
        /// </param>
        /// <param name="providerId">
        /// Provider identifier that delivered the message
        /// </param>
        /// <param name="status">
        /// Delivery status stored on the message
        /// </param>
        /// <param name="actorSubscriber"></param>
        /// <param name="stepId">
        /// Step identifier used when correlating with workflow steps
        /// </param>
        /// <param name="archivedAt">
        /// Archive timestamp
        /// </param>
        /// <param name="snoozedUntil">
        /// When set, the Inbox message is snoozed until this timestamp
        /// </param>
        /// <param name="deliveredAt">
        /// Delivery timestamps recorded for the message
        /// </param>
        /// <param name="lastSeenDate">
        /// Last time the message was seen
        /// </param>
        /// <param name="firstSeenDate">
        /// First time the message was seen
        /// </param>
        /// <param name="lastReadDate">
        /// Last time the message was read
        /// </param>
        /// <param name="errorId">
        /// Provider or internal error identifier when delivery failed
        /// </param>
        /// <param name="errorText">
        /// Provider or internal error text when delivery failed
        /// </param>
        /// <param name="contextKeys">
        /// Context keys associated with the message
        /// </param>
        /// <param name="providerResponseId">
        /// Provider response identifier for the send attempt
        /// </param>
        /// <param name="deviceToken">
        /// Device token used for a push send
        /// </param>
        /// <param name="webhookUrl">
        /// Deprecated, use `channelData`. Chat webhook URL used for the send.
        /// </param>
        /// <param name="channelData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageWebhookResponseDto(
            string id,
            string templateId,
            string environmentId,
            string organizationId,
            string notificationId,
            string subscriberId,
            string templateIdentifier,
            string workflowId,
            string createdAt,
            string updatedAt,
            bool archived,
            string transactionId,
            global::Novu.ChannelTypeEnum channel,
            bool seen,
            bool read,
            string providerId,
            global::Novu.MessageWebhookStatusEnum status,
            global::Novu.MessageWebhookActorSubscriberDto? actorSubscriber,
            string? stepId,
            string? archivedAt,
            string? snoozedUntil,
            global::System.Collections.Generic.IList<string>? deliveredAt,
            string? lastSeenDate,
            string? firstSeenDate,
            string? lastReadDate,
            string? errorId,
            string? errorText,
            global::System.Collections.Generic.IList<string>? contextKeys,
            string? providerResponseId,
            string? deviceToken,
            string? webhookUrl,
            global::Novu.MessageWebhookChannelDataDto? channelData)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.NotificationId = notificationId ?? throw new global::System.ArgumentNullException(nameof(notificationId));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.ActorSubscriber = actorSubscriber;
            this.TemplateIdentifier = templateIdentifier ?? throw new global::System.ArgumentNullException(nameof(templateIdentifier));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.StepId = stepId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.ArchivedAt = archivedAt;
            this.Archived = archived;
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.Channel = channel;
            this.Seen = seen;
            this.Read = read;
            this.SnoozedUntil = snoozedUntil;
            this.DeliveredAt = deliveredAt;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.LastSeenDate = lastSeenDate;
            this.FirstSeenDate = firstSeenDate;
            this.LastReadDate = lastReadDate;
            this.Status = status;
            this.ErrorId = errorId;
            this.ErrorText = errorText;
            this.ContextKeys = contextKeys;
            this.ProviderResponseId = providerResponseId;
            this.DeviceToken = deviceToken;
            this.WebhookUrl = webhookUrl;
            this.ChannelData = channelData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookResponseDto" /> class.
        /// </summary>
        public MessageWebhookResponseDto()
        {
        }

    }
}