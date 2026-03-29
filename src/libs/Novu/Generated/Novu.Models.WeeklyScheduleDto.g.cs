
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WeeklyScheduleDto
    {
        /// <summary>
        /// Monday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("monday")]
        public global::Novu.DayScheduleDto? Monday { get; set; }

        /// <summary>
        /// Tuesday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tuesday")]
        public global::Novu.DayScheduleDto? Tuesday { get; set; }

        /// <summary>
        /// Wednesday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wednesday")]
        public global::Novu.DayScheduleDto? Wednesday { get; set; }

        /// <summary>
        /// Thursday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thursday")]
        public global::Novu.DayScheduleDto? Thursday { get; set; }

        /// <summary>
        /// Friday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("friday")]
        public global::Novu.DayScheduleDto? Friday { get; set; }

        /// <summary>
        /// Saturday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("saturday")]
        public global::Novu.DayScheduleDto? Saturday { get; set; }

        /// <summary>
        /// Sunday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </summary>
        /// <example>{"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunday")]
        public global::Novu.DayScheduleDto? Sunday { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyScheduleDto" /> class.
        /// </summary>
        /// <param name="monday">
        /// Monday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
        /// <param name="tuesday">
        /// Tuesday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
        /// <param name="wednesday">
        /// Wednesday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
        /// <param name="thursday">
        /// Thursday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
        /// <param name="friday">
        /// Friday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
        /// <param name="saturday">
        /// Saturday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
        /// <param name="sunday">
        /// Sunday schedule<br/>
        /// Example: {"isEnabled":true,"hours":[{"start":"09:00 AM","end":"05:00 PM"}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WeeklyScheduleDto(
            global::Novu.DayScheduleDto? monday,
            global::Novu.DayScheduleDto? tuesday,
            global::Novu.DayScheduleDto? wednesday,
            global::Novu.DayScheduleDto? thursday,
            global::Novu.DayScheduleDto? friday,
            global::Novu.DayScheduleDto? saturday,
            global::Novu.DayScheduleDto? sunday)
        {
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyScheduleDto" /> class.
        /// </summary>
        public WeeklyScheduleDto()
        {
        }
    }
}