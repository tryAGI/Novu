
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDomainRouteDto
    {
        /// <summary>
        /// Agent identifier; required when type is agent, ignored when type is webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter))]
        public global::Novu.UpdateDomainRouteDtoType? Type { get; set; }

        /// <summary>
        /// Replaces route metadata when provided (max 10 keys, 500 characters total for keys+values).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, string>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainRouteDto" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent identifier; required when type is agent, ignored when type is webhook.
        /// </param>
        /// <param name="type"></param>
        /// <param name="data">
        /// Replaces route metadata when provided (max 10 keys, 500 characters total for keys+values).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDomainRouteDto(
            string? agentId,
            global::Novu.UpdateDomainRouteDtoType? type,
            global::System.Collections.Generic.Dictionary<string, string>? data)
        {
            this.AgentId = agentId;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainRouteDto" /> class.
        /// </summary>
        public UpdateDomainRouteDto()
        {
        }
    }
}