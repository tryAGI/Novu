
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimedConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atTime")]
        public string? AtTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekDays")]
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? WeekDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthDays")]
        public global::System.Collections.Generic.IList<string>? MonthDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordinal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter))]
        public global::Novu.TimedConfigOrdinal? Ordinal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordinalValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter))]
        public global::Novu.TimedConfigOrdinalValue? OrdinalValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter))]
        public global::Novu.TimedConfigMonthlyType? MonthlyType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedConfig" /> class.
        /// </summary>
        /// <param name="atTime"></param>
        /// <param name="weekDays"></param>
        /// <param name="monthDays"></param>
        /// <param name="ordinal"></param>
        /// <param name="ordinalValue"></param>
        /// <param name="monthlyType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimedConfig(
            string? atTime,
            global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? weekDays,
            global::System.Collections.Generic.IList<string>? monthDays,
            global::Novu.TimedConfigOrdinal? ordinal,
            global::Novu.TimedConfigOrdinalValue? ordinalValue,
            global::Novu.TimedConfigMonthlyType? monthlyType)
        {
            this.AtTime = atTime;
            this.WeekDays = weekDays;
            this.MonthDays = monthDays;
            this.Ordinal = ordinal;
            this.OrdinalValue = ordinalValue;
            this.MonthlyType = monthlyType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedConfig" /> class.
        /// </summary>
        public TimedConfig()
        {
        }
    }
}