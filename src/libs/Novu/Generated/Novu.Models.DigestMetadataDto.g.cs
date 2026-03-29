
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestMetadataDto
    {
        /// <summary>
        /// Optional key for the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestKey")]
        public string? DigestKey { get; set; }

        /// <summary>
        /// Amount for the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Unit of the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter))]
        public global::Novu.DigestMetadataDtoUnit? Unit { get; set; }

        /// <summary>
        /// The Digest Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DigestTypeEnum Type { get; set; }

        /// <summary>
        /// Optional array of events associated with the digest, represented as key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// Regular digest: Indicates if backoff is enabled for the regular digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoff")]
        public bool? Backoff { get; set; }

        /// <summary>
        /// Regular digest: Amount for backoff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffAmount")]
        public double? BackoffAmount { get; set; }

        /// <summary>
        /// Regular digest: Unit for backoff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DigestUnitEnumJsonConverter))]
        public global::Novu.DigestUnitEnum? BackoffUnit { get; set; }

        /// <summary>
        /// Regular digest: Indicates if the digest should update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateMode")]
        public bool? UpdateMode { get; set; }

        /// <summary>
        /// Configuration for timed digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timed")]
        public global::Novu.DigestTimedConfigDto? Timed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestMetadataDto" /> class.
        /// </summary>
        /// <param name="type">
        /// The Digest Type
        /// </param>
        /// <param name="digestKey">
        /// Optional key for the digest
        /// </param>
        /// <param name="amount">
        /// Amount for the digest
        /// </param>
        /// <param name="unit">
        /// Unit of the digest
        /// </param>
        /// <param name="events">
        /// Optional array of events associated with the digest, represented as key-value pairs
        /// </param>
        /// <param name="backoff">
        /// Regular digest: Indicates if backoff is enabled for the regular digest
        /// </param>
        /// <param name="backoffAmount">
        /// Regular digest: Amount for backoff
        /// </param>
        /// <param name="backoffUnit">
        /// Regular digest: Unit for backoff
        /// </param>
        /// <param name="updateMode">
        /// Regular digest: Indicates if the digest should update
        /// </param>
        /// <param name="timed">
        /// Configuration for timed digest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestMetadataDto(
            global::Novu.DigestTypeEnum type,
            string? digestKey,
            double? amount,
            global::Novu.DigestMetadataDtoUnit? unit,
            global::System.Collections.Generic.IList<object>? events,
            bool? backoff,
            double? backoffAmount,
            global::Novu.DigestUnitEnum? backoffUnit,
            bool? updateMode,
            global::Novu.DigestTimedConfigDto? timed)
        {
            this.DigestKey = digestKey;
            this.Amount = amount;
            this.Unit = unit;
            this.Type = type;
            this.Events = events;
            this.Backoff = backoff;
            this.BackoffAmount = backoffAmount;
            this.BackoffUnit = backoffUnit;
            this.UpdateMode = updateMode;
            this.Timed = timed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestMetadataDto" /> class.
        /// </summary>
        public DigestMetadataDto()
        {
        }
    }
}