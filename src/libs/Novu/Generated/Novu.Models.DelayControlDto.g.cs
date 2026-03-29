
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelayControlDto
    {
        /// <summary>
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </summary>
        /// <example>{"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public object? Skip { get; set; }

        /// <summary>
        /// Type of the delay. Currently only 'regular' is supported by the schema.<br/>
        /// Default Value: regular
        /// </summary>
        /// <default>global::Novu.DelayControlDtoType.Regular</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DelayControlDtoType Type { get; set; } = global::Novu.DelayControlDtoType.Regular;

        /// <summary>
        /// Amount of time to delay.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Unit of time for the delay amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter))]
        public global::Novu.DelayControlDtoUnit? Unit { get; set; }

        /// <summary>
        /// Cron expression for the delay. Min length 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        public string? Cron { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayControlDto" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the delay. Currently only 'regular' is supported by the schema.<br/>
        /// Default Value: regular
        /// </param>
        /// <param name="skip">
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </param>
        /// <param name="amount">
        /// Amount of time to delay.
        /// </param>
        /// <param name="unit">
        /// Unit of time for the delay amount.
        /// </param>
        /// <param name="cron">
        /// Cron expression for the delay. Min length 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelayControlDto(
            global::Novu.DelayControlDtoType type,
            object? skip,
            double? amount,
            global::Novu.DelayControlDtoUnit? unit,
            string? cron)
        {
            this.Skip = skip;
            this.Type = type;
            this.Amount = amount;
            this.Unit = unit;
            this.Cron = cron;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayControlDto" /> class.
        /// </summary>
        public DelayControlDto()
        {
        }
    }
}