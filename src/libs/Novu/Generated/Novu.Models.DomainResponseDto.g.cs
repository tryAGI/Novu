
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DomainResponseDtoStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mxRecordConfigured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MxRecordConfigured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dnsProvider")]
        public string? DnsProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedDnsRecords")]
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? ExpectedDnsRecords { get; set; }

        /// <summary>
        /// String key-value metadata (max 10 keys, 500 characters total when set via API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, string>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="mxRecordConfigured"></param>
        /// <param name="environmentId"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="dnsProvider"></param>
        /// <param name="expectedDnsRecords"></param>
        /// <param name="data">
        /// String key-value metadata (max 10 keys, 500 characters total when set via API).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainResponseDto(
            string id,
            string name,
            global::Novu.DomainResponseDtoStatus status,
            bool mxRecordConfigured,
            string environmentId,
            string organizationId,
            string createdAt,
            string updatedAt,
            string? dnsProvider,
            global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? expectedDnsRecords,
            global::System.Collections.Generic.Dictionary<string, string>? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.MxRecordConfigured = mxRecordConfigured;
            this.DnsProvider = dnsProvider;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.ExpectedDnsRecords = expectedDnsRecords;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponseDto" /> class.
        /// </summary>
        public DomainResponseDto()
        {
        }
    }
}