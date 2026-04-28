
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainRouteDto
    {
        /// <summary>
        /// Inbox address local part (e.g. "support", "*")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Agent identifier; required when type is agent, unused for webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DomainRouteDtoType Type { get; set; }

        /// <summary>
        /// Optional string key-value metadata (max 10 keys, 500 characters total for keys+values).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, string>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainRouteDto" /> class.
        /// </summary>
        /// <param name="address">
        /// Inbox address local part (e.g. "support", "*")
        /// </param>
        /// <param name="type"></param>
        /// <param name="agentId">
        /// Agent identifier; required when type is agent, unused for webhook
        /// </param>
        /// <param name="data">
        /// Optional string key-value metadata (max 10 keys, 500 characters total for keys+values).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainRouteDto(
            string address,
            global::Novu.DomainRouteDtoType type,
            string? agentId,
            global::System.Collections.Generic.Dictionary<string, string>? data)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.AgentId = agentId;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainRouteDto" /> class.
        /// </summary>
        public DomainRouteDto()
        {
        }
    }
}