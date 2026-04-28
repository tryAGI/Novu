
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainConnectStatusResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerName")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter))]
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? ReasonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualRecords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto> ManualRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainConnectStatusResponseDto" /> class.
        /// </summary>
        /// <param name="available"></param>
        /// <param name="manualRecords"></param>
        /// <param name="providerName"></param>
        /// <param name="providerId"></param>
        /// <param name="reason"></param>
        /// <param name="reasonCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainConnectStatusResponseDto(
            bool available,
            global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto> manualRecords,
            string? providerName,
            string? providerId,
            string? reason,
            global::Novu.DomainConnectStatusResponseDtoReasonCode? reasonCode)
        {
            this.Available = available;
            this.ProviderName = providerName;
            this.ProviderId = providerId;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.ManualRecords = manualRecords ?? throw new global::System.ArgumentNullException(nameof(manualRecords));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainConnectStatusResponseDto" /> class.
        /// </summary>
        public DomainConnectStatusResponseDto()
        {
        }
    }
}