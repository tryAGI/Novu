
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageResponseDto
    {
        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Template ID associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Environment ID where the message is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Message template ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_messageTemplateId")]
        public string? MessageTemplateId { get; set; }

        /// <summary>
        /// Organization ID associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Notification ID associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_notificationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationId { get; set; }

        /// <summary>
        /// Subscriber ID associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Subscriber details, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.SubscriberResponseDto? Subscriber { get; set; }

        /// <summary>
        /// Workflow template associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Novu.WorkflowResponse? Template { get; set; }

        /// <summary>
        /// Identifier for the message template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateIdentifier")]
        public string? TemplateIdentifier { get; set; }

        /// <summary>
        /// Creation date of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Array of delivery dates for the message, if the message has multiple delivery dates, for example after being snoozed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveredAt")]
        public global::System.Collections.Generic.IList<string>? DeliveredAt { get; set; }

        /// <summary>
        /// Last seen date of the message, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSeenDate")]
        public string? LastSeenDate { get; set; }

        /// <summary>
        /// Last read date of the message, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastReadDate")]
        public string? LastReadDate { get; set; }

        /// <summary>
        /// Content of the message, can be an email block or a string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>))]
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Content { get; set; }

        /// <summary>
        /// Transaction ID associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// Subject of the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Channel type through which the message is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChannelTypeEnum Channel { get; set; }

        /// <summary>
        /// Indicates if the message has been read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Indicates if the message has been seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Seen { get; set; }

        /// <summary>
        /// Date when the message will be unsnoozed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoozedUntil")]
        public string? SnoozedUntil { get; set; }

        /// <summary>
        /// Email address associated with the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number associated with the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Direct webhook URL for the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directWebhookUrl")]
        public string? DirectWebhookUrl { get; set; }

        /// <summary>
        /// Provider ID associated with the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Device tokens associated with the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceTokens")]
        public global::System.Collections.Generic.IList<string>? DeviceTokens { get; set; }

        /// <summary>
        /// Title of the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Call to action associated with the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageCTA Cta { get; set; }

        /// <summary>
        /// Feed ID associated with the message, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_feedId")]
        public string? FeedId { get; set; }

        /// <summary>
        /// Status of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MessageStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageStatusEnum Status { get; set; }

        /// <summary>
        /// Error ID if the message has an error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorId")]
        public string? ErrorId { get; set; }

        /// <summary>
        /// Error text if the message has an error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorText")]
        public string? ErrorText { get; set; }

        /// <summary>
        /// The payload that was used to send the notification trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Provider specific overrides used when triggering the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public object? Overrides { get; set; }

        /// <summary>
        /// Context (single or multi) in which the message was sent<br/>
        /// Example: [tenant:org-123, region:us-east-1]
        /// </summary>
        /// <example>[tenant:org-123, region:us-east-1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponseDto" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// Environment ID where the message is sent
        /// </param>
        /// <param name="organizationId">
        /// Organization ID associated with the message
        /// </param>
        /// <param name="notificationId">
        /// Notification ID associated with the message
        /// </param>
        /// <param name="subscriberId">
        /// Subscriber ID associated with the message
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the message
        /// </param>
        /// <param name="transactionId">
        /// Transaction ID associated with the message
        /// </param>
        /// <param name="channel">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="read">
        /// Indicates if the message has been read
        /// </param>
        /// <param name="seen">
        /// Indicates if the message has been seen
        /// </param>
        /// <param name="cta">
        /// Call to action associated with the message
        /// </param>
        /// <param name="status">
        /// Status of the message
        /// </param>
        /// <param name="id">
        /// Unique identifier for the message
        /// </param>
        /// <param name="templateId">
        /// Template ID associated with the message
        /// </param>
        /// <param name="messageTemplateId">
        /// Message template ID
        /// </param>
        /// <param name="subscriber">
        /// Subscriber details, if available
        /// </param>
        /// <param name="template">
        /// Workflow template associated with the message
        /// </param>
        /// <param name="templateIdentifier">
        /// Identifier for the message template
        /// </param>
        /// <param name="deliveredAt">
        /// Array of delivery dates for the message, if the message has multiple delivery dates, for example after being snoozed
        /// </param>
        /// <param name="lastSeenDate">
        /// Last seen date of the message, if available
        /// </param>
        /// <param name="lastReadDate">
        /// Last read date of the message, if available
        /// </param>
        /// <param name="content">
        /// Content of the message, can be an email block or a string
        /// </param>
        /// <param name="subject">
        /// Subject of the message, if applicable
        /// </param>
        /// <param name="snoozedUntil">
        /// Date when the message will be unsnoozed
        /// </param>
        /// <param name="email">
        /// Email address associated with the message, if applicable
        /// </param>
        /// <param name="phone">
        /// Phone number associated with the message, if applicable
        /// </param>
        /// <param name="directWebhookUrl">
        /// Direct webhook URL for the message, if applicable
        /// </param>
        /// <param name="providerId">
        /// Provider ID associated with the message, if applicable
        /// </param>
        /// <param name="deviceTokens">
        /// Device tokens associated with the message, if applicable
        /// </param>
        /// <param name="title">
        /// Title of the message, if applicable
        /// </param>
        /// <param name="feedId">
        /// Feed ID associated with the message, if applicable
        /// </param>
        /// <param name="errorId">
        /// Error ID if the message has an error
        /// </param>
        /// <param name="errorText">
        /// Error text if the message has an error
        /// </param>
        /// <param name="payload">
        /// The payload that was used to send the notification trigger
        /// </param>
        /// <param name="overrides">
        /// Provider specific overrides used when triggering the notification
        /// </param>
        /// <param name="contextKeys">
        /// Context (single or multi) in which the message was sent<br/>
        /// Example: [tenant:org-123, region:us-east-1]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageResponseDto(
            string environmentId,
            string organizationId,
            string notificationId,
            string subscriberId,
            string createdAt,
            string transactionId,
            global::Novu.ChannelTypeEnum channel,
            bool read,
            bool seen,
            global::Novu.MessageCTA cta,
            global::Novu.MessageStatusEnum status,
            string? id,
            string? templateId,
            string? messageTemplateId,
            global::Novu.SubscriberResponseDto? subscriber,
            global::Novu.WorkflowResponse? template,
            string? templateIdentifier,
            global::System.Collections.Generic.IList<string>? deliveredAt,
            string? lastSeenDate,
            string? lastReadDate,
            global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? content,
            string? subject,
            string? snoozedUntil,
            string? email,
            string? phone,
            string? directWebhookUrl,
            string? providerId,
            global::System.Collections.Generic.IList<string>? deviceTokens,
            string? title,
            string? feedId,
            string? errorId,
            string? errorText,
            object? payload,
            object? overrides,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.Id = id;
            this.TemplateId = templateId;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.MessageTemplateId = messageTemplateId;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.NotificationId = notificationId ?? throw new global::System.ArgumentNullException(nameof(notificationId));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Subscriber = subscriber;
            this.Template = template;
            this.TemplateIdentifier = templateIdentifier;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DeliveredAt = deliveredAt;
            this.LastSeenDate = lastSeenDate;
            this.LastReadDate = lastReadDate;
            this.Content = content;
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.Subject = subject;
            this.Channel = channel;
            this.Read = read;
            this.Seen = seen;
            this.SnoozedUntil = snoozedUntil;
            this.Email = email;
            this.Phone = phone;
            this.DirectWebhookUrl = directWebhookUrl;
            this.ProviderId = providerId;
            this.DeviceTokens = deviceTokens;
            this.Title = title;
            this.Cta = cta ?? throw new global::System.ArgumentNullException(nameof(cta));
            this.FeedId = feedId;
            this.Status = status;
            this.ErrorId = errorId;
            this.ErrorText = errorText;
            this.Payload = payload;
            this.Overrides = overrides;
            this.ContextKeys = contextKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponseDto" /> class.
        /// </summary>
        public MessageResponseDto()
        {
        }
    }
}