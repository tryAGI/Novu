
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchSubscriberPreferencesDto
    {
        /// <summary>
        /// Channel-specific preference settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::Novu.PatchPreferenceChannelsDto? Channels { get; set; }

        /// <summary>
        /// Workflow internal _id, identifier or slug. If provided, update workflow specific preferences, otherwise update global preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Subscriber schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::Novu.ScheduleDto? Schedule { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchSubscriberPreferencesDto" /> class.
        /// </summary>
        /// <param name="channels">
        /// Channel-specific preference settings
        /// </param>
        /// <param name="workflowId">
        /// Workflow internal _id, identifier or slug. If provided, update workflow specific preferences, otherwise update global preferences
        /// </param>
        /// <param name="schedule">
        /// Subscriber schedule
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchSubscriberPreferencesDto(
            global::Novu.PatchPreferenceChannelsDto? channels,
            string? workflowId,
            global::Novu.ScheduleDto? schedule,
            object? context)
        {
            this.Channels = channels;
            this.WorkflowId = workflowId;
            this.Schedule = schedule;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSubscriberPreferencesDto" /> class.
        /// </summary>
        public PatchSubscriberPreferencesDto()
        {
        }
    }
}