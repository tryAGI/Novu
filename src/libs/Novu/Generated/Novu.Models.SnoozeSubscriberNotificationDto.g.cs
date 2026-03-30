
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnoozeSubscriberNotificationDto
    {
        /// <summary>
        /// The date and time until which the notification should be snoozed<br/>
        /// Example: 2026-03-01T10:00:00Z
        /// </summary>
        /// <example>2026-03-01T10:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoozeUntil")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SnoozeUntil { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeSubscriberNotificationDto" /> class.
        /// </summary>
        /// <param name="snoozeUntil">
        /// The date and time until which the notification should be snoozed<br/>
        /// Example: 2026-03-01T10:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnoozeSubscriberNotificationDto(
            global::System.DateTime snoozeUntil)
        {
            this.SnoozeUntil = snoozeUntil;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeSubscriberNotificationDto" /> class.
        /// </summary>
        public SnoozeSubscriberNotificationDto()
        {
        }
    }
}