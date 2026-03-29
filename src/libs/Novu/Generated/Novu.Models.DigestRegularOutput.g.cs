
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestRegularOutput
    {
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
        /// Optional digest key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestKey")]
        public string? DigestKey { get; set; }

        /// <summary>
        /// Look back window configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lookBackWindow")]
        public object? LookBackWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestRegularOutput" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount of time units
        /// </param>
        /// <param name="unit">
        /// Time unit
        /// </param>
        /// <param name="digestKey">
        /// Optional digest key
        /// </param>
        /// <param name="lookBackWindow">
        /// Look back window configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestRegularOutput(
            double amount,
            global::Novu.TimeUnitEnum unit,
            string? digestKey,
            object? lookBackWindow)
        {
            this.Amount = amount;
            this.Unit = unit;
            this.DigestKey = digestKey;
            this.LookBackWindow = lookBackWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestRegularOutput" /> class.
        /// </summary>
        public DigestRegularOutput()
        {
        }
    }
}