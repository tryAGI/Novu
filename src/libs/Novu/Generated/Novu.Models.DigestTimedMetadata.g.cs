
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestTimedMetadata
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter))]
        public global::Novu.DigestTimedMetadataUnit? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestKey")]
        public string? DigestKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter))]
        public global::Novu.DigestTimedMetadataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timed")]
        public global::Novu.TimedConfig? Timed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestTimedMetadata" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="unit"></param>
        /// <param name="digestKey"></param>
        /// <param name="type"></param>
        /// <param name="timed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestTimedMetadata(
            double? amount,
            global::Novu.DigestTimedMetadataUnit? unit,
            string? digestKey,
            global::Novu.DigestTimedMetadataType type,
            global::Novu.TimedConfig? timed)
        {
            this.Amount = amount;
            this.Unit = unit;
            this.DigestKey = digestKey;
            this.Type = type;
            this.Timed = timed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestTimedMetadata" /> class.
        /// </summary>
        public DigestTimedMetadata()
        {
        }
    }
}