
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelayRenderOutput
    {
        /// <summary>
        /// Type of delay
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Amount of time units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Time unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TimeUnitEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TimeUnitEnum Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayRenderOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of delay
        /// </param>
        /// <param name="amount">
        /// Amount of time units
        /// </param>
        /// <param name="unit">
        /// Time unit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelayRenderOutput(
            string type,
            double amount,
            global::Novu.TimeUnitEnum unit)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Amount = amount;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayRenderOutput" /> class.
        /// </summary>
        public DelayRenderOutput()
        {
        }
    }
}