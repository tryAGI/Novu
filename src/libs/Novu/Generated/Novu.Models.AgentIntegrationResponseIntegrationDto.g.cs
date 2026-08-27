
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentIntegrationResponseIntegrationDto
    {
        /// <summary>
        /// Integration document _id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The integration identifier (matches the integration store), not the internal MongoDB _id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// Channel type through which the message is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter))]
        public global::Novu.ChannelTypeEnum? Channel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// The Novu shared inbox address for this agent. Set whenever the cloud shared-inbox feature is enabled. The dashboard uses this as the headline inbound address and to render the shared inbox row in the inbox list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedInboundAddress")]
        public string? SharedInboundAddress { get; set; }

        /// <summary>
        /// Default email From display name for this agent (NovuAgent integrations only). Falls back to the agent name when not explicitly stored on the integration credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSenderName")]
        public string? DefaultSenderName { get; set; }

        /// <summary>
        /// When true, the worker drops inbound mail addressed to this agent on the shared `agentconnect.sh` domain. Custom-domain routes still deliver. Meaningful on cloud-enabled NovuAgent integrations; on self-hosted it is set defensively at provisioning time and is effectively redundant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedInboxDisabled")]
        public bool? SharedInboxDisabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationResponseIntegrationDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Integration document _id.
        /// </param>
        /// <param name="identifier">
        /// The integration identifier (matches the integration store), not the internal MongoDB _id.
        /// </param>
        /// <param name="name"></param>
        /// <param name="providerId"></param>
        /// <param name="active"></param>
        /// <param name="channel">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="sharedInboundAddress">
        /// The Novu shared inbox address for this agent. Set whenever the cloud shared-inbox feature is enabled. The dashboard uses this as the headline inbound address and to render the shared inbox row in the inbox list.
        /// </param>
        /// <param name="defaultSenderName">
        /// Default email From display name for this agent (NovuAgent integrations only). Falls back to the agent name when not explicitly stored on the integration credentials.
        /// </param>
        /// <param name="sharedInboxDisabled">
        /// When true, the worker drops inbound mail addressed to this agent on the shared `agentconnect.sh` domain. Custom-domain routes still deliver. Meaningful on cloud-enabled NovuAgent integrations; on self-hosted it is set defensively at provisioning time and is effectively redundant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentIntegrationResponseIntegrationDto(
            string id,
            string identifier,
            string name,
            string providerId,
            bool active,
            global::Novu.ChannelTypeEnum? channel,
            string? sharedInboundAddress,
            string? defaultSenderName,
            bool? sharedInboxDisabled)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Channel = channel;
            this.Active = active;
            this.SharedInboundAddress = sharedInboundAddress;
            this.DefaultSenderName = defaultSenderName;
            this.SharedInboxDisabled = sharedInboxDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationResponseIntegrationDto" /> class.
        /// </summary>
        public AgentIntegrationResponseIntegrationDto()
        {
        }

    }
}