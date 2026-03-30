
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InboxNotificationDto
    {
        /// <summary>
        /// Unique identifier of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Transaction identifier of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// Subject of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Body content of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Subscriber this notification was sent to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.InboxSubscriberResponseDto To { get; set; }

        /// <summary>
        /// Whether the notification has been read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRead")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRead { get; set; }

        /// <summary>
        /// Whether the notification has been seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSeen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSeen { get; set; }

        /// <summary>
        /// Whether the notification has been archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isArchived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsArchived { get; set; }

        /// <summary>
        /// Whether the notification is snoozed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSnoozed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSnoozed { get; set; }

        /// <summary>
        /// ISO timestamp when the notification will be unsnoozed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoozedUntil")]
        public string? SnoozedUntil { get; set; }

        /// <summary>
        /// Timestamps when the notification was delivered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveredAt")]
        public global::System.Collections.Generic.IList<string>? DeliveredAt { get; set; }

        /// <summary>
        /// ISO timestamp when the notification was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO timestamp when the notification was read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readAt")]
        public string? ReadAt { get; set; }

        /// <summary>
        /// ISO timestamp when the notification was first seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSeenAt")]
        public string? FirstSeenAt { get; set; }

        /// <summary>
        /// ISO timestamp when the notification was archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedAt")]
        public string? ArchivedAt { get; set; }

        /// <summary>
        /// Avatar URL for the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Primary action button for the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryAction")]
        public global::Novu.InboxActionDto? PrimaryAction { get; set; }

        /// <summary>
        /// Secondary action button for the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryAction")]
        public global::Novu.InboxActionDto? SecondaryAction { get; set; }

        /// <summary>
        /// Channel type through which the message is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChannelTypeEnum ChannelType { get; set; }

        /// <summary>
        /// Tags associated with the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom data payload of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Redirect configuration for the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Novu.RedirectDto? Redirect { get; set; }

        /// <summary>
        /// Workflow associated with the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Novu.NotificationWorkflowDto? Workflow { get; set; }

        /// <summary>
        /// Severity of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SeverityLevelEnum Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxNotificationDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the notification
        /// </param>
        /// <param name="transactionId">
        /// Transaction identifier of the notification
        /// </param>
        /// <param name="body">
        /// Body content of the notification
        /// </param>
        /// <param name="to">
        /// Subscriber this notification was sent to
        /// </param>
        /// <param name="isRead">
        /// Whether the notification has been read
        /// </param>
        /// <param name="isSeen">
        /// Whether the notification has been seen
        /// </param>
        /// <param name="isArchived">
        /// Whether the notification has been archived
        /// </param>
        /// <param name="isSnoozed">
        /// Whether the notification is snoozed
        /// </param>
        /// <param name="createdAt">
        /// ISO timestamp when the notification was created
        /// </param>
        /// <param name="channelType">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
        /// <param name="subject">
        /// Subject of the notification
        /// </param>
        /// <param name="snoozedUntil">
        /// ISO timestamp when the notification will be unsnoozed
        /// </param>
        /// <param name="deliveredAt">
        /// Timestamps when the notification was delivered
        /// </param>
        /// <param name="readAt">
        /// ISO timestamp when the notification was read
        /// </param>
        /// <param name="firstSeenAt">
        /// ISO timestamp when the notification was first seen
        /// </param>
        /// <param name="archivedAt">
        /// ISO timestamp when the notification was archived
        /// </param>
        /// <param name="avatar">
        /// Avatar URL for the notification
        /// </param>
        /// <param name="primaryAction">
        /// Primary action button for the notification
        /// </param>
        /// <param name="secondaryAction">
        /// Secondary action button for the notification
        /// </param>
        /// <param name="tags">
        /// Tags associated with the notification
        /// </param>
        /// <param name="data">
        /// Custom data payload of the notification
        /// </param>
        /// <param name="redirect">
        /// Redirect configuration for the notification
        /// </param>
        /// <param name="workflow">
        /// Workflow associated with the notification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxNotificationDto(
            string id,
            string transactionId,
            string body,
            global::Novu.InboxSubscriberResponseDto to,
            bool isRead,
            bool isSeen,
            bool isArchived,
            bool isSnoozed,
            string createdAt,
            global::Novu.ChannelTypeEnum channelType,
            global::Novu.SeverityLevelEnum severity,
            string? subject,
            string? snoozedUntil,
            global::System.Collections.Generic.IList<string>? deliveredAt,
            string? readAt,
            string? firstSeenAt,
            string? archivedAt,
            string? avatar,
            global::Novu.InboxActionDto? primaryAction,
            global::Novu.InboxActionDto? secondaryAction,
            global::System.Collections.Generic.IList<string>? tags,
            object? data,
            global::Novu.RedirectDto? redirect,
            global::Novu.NotificationWorkflowDto? workflow)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.Subject = subject;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.IsRead = isRead;
            this.IsSeen = isSeen;
            this.IsArchived = isArchived;
            this.IsSnoozed = isSnoozed;
            this.SnoozedUntil = snoozedUntil;
            this.DeliveredAt = deliveredAt;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ReadAt = readAt;
            this.FirstSeenAt = firstSeenAt;
            this.ArchivedAt = archivedAt;
            this.Avatar = avatar;
            this.PrimaryAction = primaryAction;
            this.SecondaryAction = secondaryAction;
            this.ChannelType = channelType;
            this.Tags = tags;
            this.Data = data;
            this.Redirect = redirect;
            this.Workflow = workflow;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxNotificationDto" /> class.
        /// </summary>
        public InboxNotificationDto()
        {
        }
    }
}