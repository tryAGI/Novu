
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleDto
    {
        /// <summary>
        /// Schedule enabled<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Weekly schedule<br/>
        /// Example: {"monday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"tuesday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"wednesday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"thursday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"friday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"saturday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"sunday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}}
        /// </summary>
        /// <example>{"monday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"tuesday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"wednesday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"thursday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"friday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"saturday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"sunday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weeklySchedule")]
        public global::Novu.WeeklyScheduleDto? WeeklySchedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDto" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Schedule enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="weeklySchedule">
        /// Weekly schedule<br/>
        /// Example: {"monday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"tuesday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"wednesday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"thursday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"friday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"saturday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]},"sunday":{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleDto(
            bool isEnabled,
            global::Novu.WeeklyScheduleDto? weeklySchedule)
        {
            this.IsEnabled = isEnabled;
            this.WeeklySchedule = weeklySchedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDto" /> class.
        /// </summary>
        public ScheduleDto()
        {
        }
    }
}