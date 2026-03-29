
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelayRegularMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter))]
        public global::Novu.DelayRegularMetadataUnit? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter))]
        public global::Novu.DelayRegularMetadataType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayRegularMetadata" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="unit"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelayRegularMetadata(
            double? amount,
            global::Novu.DelayRegularMetadataUnit? unit,
            global::Novu.DelayRegularMetadataType type)
        {
            this.Amount = amount;
            this.Unit = unit;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayRegularMetadata" /> class.
        /// </summary>
        public DelayRegularMetadata()
        {
        }
    }
}