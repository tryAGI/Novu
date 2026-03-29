
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotificationFeedItemDto
    {
        /// <summary>
        /// Unique identifier for the notification.<br/>
        /// Example: 615c1f2f9b0c5b001f8e4e3b
        /// </summary>
        /// <example>615c1f2f9b0c5b001f8e4e3b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier for the template used to generate the notification.<br/>
        /// Example: template_12345
        /// </summary>
        /// <example>template_12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Identifier for the environment where the notification is sent.<br/>
        /// Example: env_67890
        /// </summary>
        /// <example>env_67890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Identifier for the message template used.<br/>
        /// Example: message_template_54321
        /// </summary>
        /// <example>message_template_54321</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_messageTemplateId")]
        public string? MessageTemplateId { get; set; }

        /// <summary>
        /// Identifier for the organization sending the notification.<br/>
        /// Example: org_98765
        /// </summary>
        /// <example>org_98765</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Unique identifier for the notification instance.<br/>
        /// Example: notification_123456
        /// </summary>
        /// <example>notification_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_notificationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationId { get; set; }

        /// <summary>
        /// Unique identifier for the subscriber receiving the notification.<br/>
        /// Example: subscriber_112233
        /// </summary>
        /// <example>subscriber_112233</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Identifier for the feed associated with the notification.<br/>
        /// Example: feed_445566
        /// </summary>
        /// <example>feed_445566</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_feedId")]
        public string? FeedId { get; set; }

        /// <summary>
        /// Identifier for the job that triggered the notification.<br/>
        /// Example: job_778899
        /// </summary>
        /// <example>job_778899</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_jobId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Timestamp indicating when the notification was created.<br/>
        /// Example: 2024-12-10T10:10:59.639Z
        /// </summary>
        /// <example>2024-12-10T10:10:59.639Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the notification was last updated.<br/>
        /// Example: 2024-12-10T10:10:59.639Z
        /// </summary>
        /// <example>2024-12-10T10:10:59.639Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Actor details related to the notification, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::Novu.ActorFeedItemDto? Actor { get; set; }

        /// <summary>
        /// Subscriber details associated with this notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.SubscriberFeedResponseDto? Subscriber { get; set; }

        /// <summary>
        /// Unique identifier for the transaction associated with the notification.<br/>
        /// Example: transaction_123456
        /// </summary>
        /// <example>transaction_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// Identifier for the template used, if applicable.<br/>
        /// Example: template_abcdef
        /// </summary>
        /// <example>template_abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateIdentifier")]
        public string? TemplateIdentifier { get; set; }

        /// <summary>
        /// Identifier for the provider that sends the notification.<br/>
        /// Example: provider_xyz
        /// </summary>
        /// <example>provider_xyz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// The main content of the notification.<br/>
        /// Example: This is a test notification content.
        /// </summary>
        /// <example>This is a test notification content.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The subject line for email notifications, if applicable.<br/>
        /// Example: Test Notification Subject
        /// </summary>
        /// <example>Test Notification Subject</example>
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
        /// Indicates whether the notification has been read by the subscriber.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Indicates whether the notification has been seen by the subscriber.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Seen { get; set; }

        /// <summary>
        /// Indicates whether the notification has been archived by the subscriber.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Device tokens for push notifications, if applicable.<br/>
        /// Example: [token1, token2]
        /// </summary>
        /// <example>[token1, token2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceTokens")]
        public global::System.Collections.Generic.IList<string>? DeviceTokens { get; set; }

        /// <summary>
        /// Call-to-action information associated with the notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageCTA Cta { get; set; }

        /// <summary>
        /// Current status of the notification.<br/>
        /// Example: sent
        /// </summary>
        /// <example>sent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.NotificationFeedItemDtoStatus Status { get; set; }

        /// <summary>
        /// The payload that was used to send the notification trigger.<br/>
        /// Example: {"key":"value"}
        /// </summary>
        /// <example>{"key":"value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// The data sent with the notification.<br/>
        /// Example: {"key":"value"}
        /// </summary>
        /// <example>{"key":"value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Provider-specific overrides used when triggering the notification.<br/>
        /// Example: {"overrideKey":"overrideValue"}
        /// </summary>
        /// <example>{"overrideKey":"overrideValue"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public object? Overrides { get; set; }

        /// <summary>
        /// Tags associated with the workflow that triggered the notification.<br/>
        /// Example: [tag1, tag2]
        /// </summary>
        /// <example>[tag1, tag2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationFeedItemDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the notification.<br/>
        /// Example: 615c1f2f9b0c5b001f8e4e3b
        /// </param>
        /// <param name="templateId">
        /// Identifier for the template used to generate the notification.<br/>
        /// Example: template_12345
        /// </param>
        /// <param name="environmentId">
        /// Identifier for the environment where the notification is sent.<br/>
        /// Example: env_67890
        /// </param>
        /// <param name="organizationId">
        /// Identifier for the organization sending the notification.<br/>
        /// Example: org_98765
        /// </param>
        /// <param name="notificationId">
        /// Unique identifier for the notification instance.<br/>
        /// Example: notification_123456
        /// </param>
        /// <param name="subscriberId">
        /// Unique identifier for the subscriber receiving the notification.<br/>
        /// Example: subscriber_112233
        /// </param>
        /// <param name="jobId">
        /// Identifier for the job that triggered the notification.<br/>
        /// Example: job_778899
        /// </param>
        /// <param name="transactionId">
        /// Unique identifier for the transaction associated with the notification.<br/>
        /// Example: transaction_123456
        /// </param>
        /// <param name="content">
        /// The main content of the notification.<br/>
        /// Example: This is a test notification content.
        /// </param>
        /// <param name="channel">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="read">
        /// Indicates whether the notification has been read by the subscriber.<br/>
        /// Example: false
        /// </param>
        /// <param name="seen">
        /// Indicates whether the notification has been seen by the subscriber.<br/>
        /// Example: true
        /// </param>
        /// <param name="archived">
        /// Indicates whether the notification has been archived by the subscriber.<br/>
        /// Example: false
        /// </param>
        /// <param name="cta">
        /// Call-to-action information associated with the notification.
        /// </param>
        /// <param name="status">
        /// Current status of the notification.<br/>
        /// Example: sent
        /// </param>
        /// <param name="messageTemplateId">
        /// Identifier for the message template used.<br/>
        /// Example: message_template_54321
        /// </param>
        /// <param name="feedId">
        /// Identifier for the feed associated with the notification.<br/>
        /// Example: feed_445566
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the notification was created.<br/>
        /// Example: 2024-12-10T10:10:59.639Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp indicating when the notification was last updated.<br/>
        /// Example: 2024-12-10T10:10:59.639Z
        /// </param>
        /// <param name="actor">
        /// Actor details related to the notification, if applicable.
        /// </param>
        /// <param name="subscriber">
        /// Subscriber details associated with this notification.
        /// </param>
        /// <param name="templateIdentifier">
        /// Identifier for the template used, if applicable.<br/>
        /// Example: template_abcdef
        /// </param>
        /// <param name="providerId">
        /// Identifier for the provider that sends the notification.<br/>
        /// Example: provider_xyz
        /// </param>
        /// <param name="subject">
        /// The subject line for email notifications, if applicable.<br/>
        /// Example: Test Notification Subject
        /// </param>
        /// <param name="deviceTokens">
        /// Device tokens for push notifications, if applicable.<br/>
        /// Example: [token1, token2]
        /// </param>
        /// <param name="payload">
        /// The payload that was used to send the notification trigger.<br/>
        /// Example: {"key":"value"}
        /// </param>
        /// <param name="data">
        /// The data sent with the notification.<br/>
        /// Example: {"key":"value"}
        /// </param>
        /// <param name="overrides">
        /// Provider-specific overrides used when triggering the notification.<br/>
        /// Example: {"overrideKey":"overrideValue"}
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow that triggered the notification.<br/>
        /// Example: [tag1, tag2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationFeedItemDto(
            string id,
            string templateId,
            string environmentId,
            string organizationId,
            string notificationId,
            string subscriberId,
            string jobId,
            string transactionId,
            string content,
            global::Novu.ChannelTypeEnum channel,
            bool read,
            bool seen,
            bool archived,
            global::Novu.MessageCTA cta,
            global::Novu.NotificationFeedItemDtoStatus status,
            string? messageTemplateId,
            string? feedId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::Novu.ActorFeedItemDto? actor,
            global::Novu.SubscriberFeedResponseDto? subscriber,
            string? templateIdentifier,
            string? providerId,
            string? subject,
            global::System.Collections.Generic.IList<string>? deviceTokens,
            object? payload,
            object? data,
            object? overrides,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.MessageTemplateId = messageTemplateId;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.NotificationId = notificationId ?? throw new global::System.ArgumentNullException(nameof(notificationId));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.FeedId = feedId;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Actor = actor;
            this.Subscriber = subscriber;
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.TemplateIdentifier = templateIdentifier;
            this.ProviderId = providerId;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Subject = subject;
            this.Channel = channel;
            this.Read = read;
            this.Seen = seen;
            this.Archived = archived;
            this.DeviceTokens = deviceTokens;
            this.Cta = cta ?? throw new global::System.ArgumentNullException(nameof(cta));
            this.Status = status;
            this.Payload = payload;
            this.Data = data;
            this.Overrides = overrides;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationFeedItemDto" /> class.
        /// </summary>
        public NotificationFeedItemDto()
        {
        }
    }
}