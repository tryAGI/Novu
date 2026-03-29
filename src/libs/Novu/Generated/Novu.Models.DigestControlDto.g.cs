
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestControlDto
    {
        /// <summary>
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </summary>
        /// <example>{"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public object? Skip { get; set; }

        /// <summary>
        /// The type of digest strategy. Determines which fields are applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter))]
        public global::Novu.DigestControlDtoType? Type { get; set; }

        /// <summary>
        /// The amount of time for the digest interval (for REGULAR type). Min 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The unit of time for the digest interval (for REGULAR type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter))]
        public global::Novu.DigestControlDtoUnit? Unit { get; set; }

        /// <summary>
        /// Configuration for look-back window (for REGULAR type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lookBackWindow")]
        public global::Novu.LookBackWindowDto? LookBackWindow { get; set; }

        /// <summary>
        /// Cron expression for TIMED digest. Min length 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        public string? Cron { get; set; }

        /// <summary>
        /// Specify a custom key for digesting events instead of the default event key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestKey")]
        public string? DigestKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestControlDto" /> class.
        /// </summary>
        /// <param name="skip">
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </param>
        /// <param name="type">
        /// The type of digest strategy. Determines which fields are applicable.
        /// </param>
        /// <param name="amount">
        /// The amount of time for the digest interval (for REGULAR type). Min 1.
        /// </param>
        /// <param name="unit">
        /// The unit of time for the digest interval (for REGULAR type).
        /// </param>
        /// <param name="lookBackWindow">
        /// Configuration for look-back window (for REGULAR type).
        /// </param>
        /// <param name="cron">
        /// Cron expression for TIMED digest. Min length 1.
        /// </param>
        /// <param name="digestKey">
        /// Specify a custom key for digesting events instead of the default event key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestControlDto(
            object? skip,
            global::Novu.DigestControlDtoType? type,
            double? amount,
            global::Novu.DigestControlDtoUnit? unit,
            global::Novu.LookBackWindowDto? lookBackWindow,
            string? cron,
            string? digestKey)
        {
            this.Skip = skip;
            this.Type = type;
            this.Amount = amount;
            this.Unit = unit;
            this.LookBackWindow = lookBackWindow;
            this.Cron = cron;
            this.DigestKey = digestKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestControlDto" /> class.
        /// </summary>
        public DigestControlDto()
        {
        }
    }
}