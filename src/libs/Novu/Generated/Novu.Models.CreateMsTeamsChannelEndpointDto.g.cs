
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMsTeamsChannelEndpointDto
    {
        /// <summary>
        /// The unique identifier for the channel endpoint. If not provided, one will be generated automatically.<br/>
        /// Example: slack-channel-user123-abc4
        /// </summary>
        /// <example>slack-channel-user123-abc4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The subscriber ID to which the channel endpoint is linked<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// The identifier of the integration to use for this channel endpoint.<br/>
        /// Example: slack-prod
        /// </summary>
        /// <example>slack-prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// The identifier of the channel connection to use for this channel endpoint.<br/>
        /// Example: slack-connection-abc123
        /// </summary>
        /// <example>slack-connection-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionIdentifier")]
        public string? ConnectionIdentifier { get; set; }

        /// <summary>
        /// Type of channel endpoint<br/>
        /// Example: ms_teams_channel
        /// </summary>
        /// <example>ms_teams_channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter))]
        public global::Novu.CreateMsTeamsChannelEndpointDtoType Type { get; set; }

        /// <summary>
        /// MS Teams channel endpoint data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MsTeamsChannelEndpointDto Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMsTeamsChannelEndpointDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// The subscriber ID to which the channel endpoint is linked<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="integrationIdentifier">
        /// The identifier of the integration to use for this channel endpoint.<br/>
        /// Example: slack-prod
        /// </param>
        /// <param name="endpoint">
        /// MS Teams channel endpoint data
        /// </param>
        /// <param name="identifier">
        /// The unique identifier for the channel endpoint. If not provided, one will be generated automatically.<br/>
        /// Example: slack-channel-user123-abc4
        /// </param>
        /// <param name="context"></param>
        /// <param name="connectionIdentifier">
        /// The identifier of the channel connection to use for this channel endpoint.<br/>
        /// Example: slack-connection-abc123
        /// </param>
        /// <param name="type">
        /// Type of channel endpoint<br/>
        /// Example: ms_teams_channel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMsTeamsChannelEndpointDto(
            string subscriberId,
            string integrationIdentifier,
            global::Novu.MsTeamsChannelEndpointDto endpoint,
            string? identifier,
            object? context,
            string? connectionIdentifier,
            global::Novu.CreateMsTeamsChannelEndpointDtoType type)
        {
            this.Identifier = identifier;
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Context = context;
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.ConnectionIdentifier = connectionIdentifier;
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMsTeamsChannelEndpointDto" /> class.
        /// </summary>
        public CreateMsTeamsChannelEndpointDto()
        {
        }
    }
}