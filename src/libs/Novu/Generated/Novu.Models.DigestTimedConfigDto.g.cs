
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestTimedConfigDto
    {
        /// <summary>
        /// Time at which the digest is triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atTime")]
        public string? AtTime { get; set; }

        /// <summary>
        /// Days of the week for the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekDays")]
        public global::System.Collections.Generic.IList<global::Novu.DigestTimedConfigDtoWeekDay>? WeekDays { get; set; }

        /// <summary>
        /// Specific days of the month for the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthDays")]
        public global::System.Collections.Generic.IList<double>? MonthDays { get; set; }

        /// <summary>
        /// Ordinal position for the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordinal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OrdinalEnumJsonConverter))]
        public global::Novu.OrdinalEnum? Ordinal { get; set; }

        /// <summary>
        /// Value of the ordinal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordinalValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OrdinalValueEnumJsonConverter))]
        public global::Novu.OrdinalValueEnum? OrdinalValue { get; set; }

        /// <summary>
        /// Type of monthly schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter))]
        public global::Novu.MonthlyTypeEnum? MonthlyType { get; set; }

        /// <summary>
        /// Cron expression for scheduling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cronExpression")]
        public string? CronExpression { get; set; }

        /// <summary>
        /// Until date for scheduling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("untilDate")]
        public string? UntilDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestTimedConfigDto" /> class.
        /// </summary>
        /// <param name="atTime">
        /// Time at which the digest is triggered
        /// </param>
        /// <param name="weekDays">
        /// Days of the week for the digest
        /// </param>
        /// <param name="monthDays">
        /// Specific days of the month for the digest
        /// </param>
        /// <param name="ordinal">
        /// Ordinal position for the digest
        /// </param>
        /// <param name="ordinalValue">
        /// Value of the ordinal
        /// </param>
        /// <param name="monthlyType">
        /// Type of monthly schedule
        /// </param>
        /// <param name="cronExpression">
        /// Cron expression for scheduling
        /// </param>
        /// <param name="untilDate">
        /// Until date for scheduling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestTimedConfigDto(
            string? atTime,
            global::System.Collections.Generic.IList<global::Novu.DigestTimedConfigDtoWeekDay>? weekDays,
            global::System.Collections.Generic.IList<double>? monthDays,
            global::Novu.OrdinalEnum? ordinal,
            global::Novu.OrdinalValueEnum? ordinalValue,
            global::Novu.MonthlyTypeEnum? monthlyType,
            string? cronExpression,
            string? untilDate)
        {
            this.AtTime = atTime;
            this.WeekDays = weekDays;
            this.MonthDays = monthDays;
            this.Ordinal = ordinal;
            this.OrdinalValue = ordinalValue;
            this.MonthlyType = monthlyType;
            this.CronExpression = cronExpression;
            this.UntilDate = untilDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestTimedConfigDto" /> class.
        /// </summary>
        public DigestTimedConfigDto()
        {
        }
    }
}