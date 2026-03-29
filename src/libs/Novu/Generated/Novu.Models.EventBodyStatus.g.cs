
#nullable enable

namespace Novu
{
    /// <summary>
    /// Status of the event
    /// </summary>
    public enum EventBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Bounced,
        /// <summary>
        /// 
        /// </summary>
        Clicked,
        /// <summary>
        /// 
        /// </summary>
        Complaint,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deferred,
        /// <summary>
        /// 
        /// </summary>
        Delayed,
        /// <summary>
        /// 
        /// </summary>
        Delivered,
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Dropped,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Opened,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Sending,
        /// <summary>
        /// 
        /// </summary>
        Sent,
        /// <summary>
        /// 
        /// </summary>
        Spam,
        /// <summary>
        /// 
        /// </summary>
        Undelivered,
        /// <summary>
        /// 
        /// </summary>
        Unsubscribed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventBodyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventBodyStatus value)
        {
            return value switch
            {
                EventBodyStatus.Accepted => "accepted",
                EventBodyStatus.Blocked => "blocked",
                EventBodyStatus.Bounced => "bounced",
                EventBodyStatus.Clicked => "clicked",
                EventBodyStatus.Complaint => "complaint",
                EventBodyStatus.Created => "created",
                EventBodyStatus.Deferred => "deferred",
                EventBodyStatus.Delayed => "delayed",
                EventBodyStatus.Delivered => "delivered",
                EventBodyStatus.Dismissed => "dismissed",
                EventBodyStatus.Dropped => "dropped",
                EventBodyStatus.Failed => "failed",
                EventBodyStatus.Opened => "opened",
                EventBodyStatus.Queued => "queued",
                EventBodyStatus.Rejected => "rejected",
                EventBodyStatus.Sending => "sending",
                EventBodyStatus.Sent => "sent",
                EventBodyStatus.Spam => "spam",
                EventBodyStatus.Undelivered => "undelivered",
                EventBodyStatus.Unsubscribed => "unsubscribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventBodyStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => EventBodyStatus.Accepted,
                "blocked" => EventBodyStatus.Blocked,
                "bounced" => EventBodyStatus.Bounced,
                "clicked" => EventBodyStatus.Clicked,
                "complaint" => EventBodyStatus.Complaint,
                "created" => EventBodyStatus.Created,
                "deferred" => EventBodyStatus.Deferred,
                "delayed" => EventBodyStatus.Delayed,
                "delivered" => EventBodyStatus.Delivered,
                "dismissed" => EventBodyStatus.Dismissed,
                "dropped" => EventBodyStatus.Dropped,
                "failed" => EventBodyStatus.Failed,
                "opened" => EventBodyStatus.Opened,
                "queued" => EventBodyStatus.Queued,
                "rejected" => EventBodyStatus.Rejected,
                "sending" => EventBodyStatus.Sending,
                "sent" => EventBodyStatus.Sent,
                "spam" => EventBodyStatus.Spam,
                "undelivered" => EventBodyStatus.Undelivered,
                "unsubscribed" => EventBodyStatus.Unsubscribed,
                _ => null,
            };
        }
    }
}