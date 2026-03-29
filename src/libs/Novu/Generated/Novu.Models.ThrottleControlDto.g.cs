
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThrottleControlDto
    {
        /// <summary>
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </summary>
        /// <example>{"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public object? Skip { get; set; }

        /// <summary>
        /// The type of throttle window.<br/>
        /// Default Value: fixed
        /// </summary>
        /// <default>global::Novu.ThrottleControlDtoType.Fixed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ThrottleControlDtoType Type { get; set; } = global::Novu.ThrottleControlDtoType.Fixed;

        /// <summary>
        /// The amount of time for the throttle window (required for fixed type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The unit of time for the throttle window (required for fixed type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter))]
        public global::Novu.ThrottleControlDtoUnit? Unit { get; set; }

        /// <summary>
        /// Key path to retrieve dynamic window value (required for dynamic type).<br/>
        /// Example: payload.timestamp
        /// </summary>
        /// <example>payload.timestamp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicKey")]
        public string? DynamicKey { get; set; }

        /// <summary>
        /// The maximum number of executions allowed within the window. Defaults to 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Optional key for grouping throttle rules. If not provided, defaults to workflow and subscriber combination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttleKey")]
        public string? ThrottleKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottleControlDto" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of throttle window.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="skip">
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </param>
        /// <param name="amount">
        /// The amount of time for the throttle window (required for fixed type).
        /// </param>
        /// <param name="unit">
        /// The unit of time for the throttle window (required for fixed type).
        /// </param>
        /// <param name="dynamicKey">
        /// Key path to retrieve dynamic window value (required for dynamic type).<br/>
        /// Example: payload.timestamp
        /// </param>
        /// <param name="threshold">
        /// The maximum number of executions allowed within the window. Defaults to 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="throttleKey">
        /// Optional key for grouping throttle rules. If not provided, defaults to workflow and subscriber combination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThrottleControlDto(
            global::Novu.ThrottleControlDtoType type,
            object? skip,
            double? amount,
            global::Novu.ThrottleControlDtoUnit? unit,
            string? dynamicKey,
            double? threshold,
            string? throttleKey)
        {
            this.Skip = skip;
            this.Type = type;
            this.Amount = amount;
            this.Unit = unit;
            this.DynamicKey = dynamicKey;
            this.Threshold = threshold;
            this.ThrottleKey = throttleKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottleControlDto" /> class.
        /// </summary>
        public ThrottleControlDto()
        {
        }
    }
}