
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DayScheduleDto
    {
        /// <summary>
        /// Day schedule enabled<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Hours<br/>
        /// Example: [{"start":"09:00 AM","end":"05:00 PM"}]
        /// </summary>
        /// <example>[{"start":"09:00 AM","end":"05:00 PM"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Hours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DayScheduleDto" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Day schedule enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="hours">
        /// Hours<br/>
        /// Example: [{"start":"09:00 AM","end":"05:00 PM"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DayScheduleDto(
            bool isEnabled,
            global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? hours)
        {
            this.IsEnabled = isEnabled;
            this.Hours = hours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DayScheduleDto" /> class.
        /// </summary>
        public DayScheduleDto()
        {
        }
    }
}