
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestRegularMetadata
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter))]
        public global::Novu.DigestRegularMetadataUnit? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestKey")]
        public string? DigestKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DigestRegularMetadataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoff")]
        public bool? Backoff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffAmount")]
        public double? BackoffAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter))]
        public global::Novu.DigestRegularMetadataBackoffUnit? BackoffUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateMode")]
        public bool? UpdateMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestRegularMetadata" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        /// <param name="unit"></param>
        /// <param name="digestKey"></param>
        /// <param name="backoff"></param>
        /// <param name="backoffAmount"></param>
        /// <param name="backoffUnit"></param>
        /// <param name="updateMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestRegularMetadata(
            global::Novu.DigestRegularMetadataType type,
            double? amount,
            global::Novu.DigestRegularMetadataUnit? unit,
            string? digestKey,
            bool? backoff,
            double? backoffAmount,
            global::Novu.DigestRegularMetadataBackoffUnit? backoffUnit,
            bool? updateMode)
        {
            this.Amount = amount;
            this.Unit = unit;
            this.DigestKey = digestKey;
            this.Type = type;
            this.Backoff = backoff;
            this.BackoffAmount = backoffAmount;
            this.BackoffUnit = backoffUnit;
            this.UpdateMode = updateMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestRegularMetadata" /> class.
        /// </summary>
        public DigestRegularMetadata()
        {
        }
    }
}