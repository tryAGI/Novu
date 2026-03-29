
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelEndpointResponseDto
    {
        /// <summary>
        /// The unique identifier of the channel endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// The channel type (email, sms, push, chat, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter))]
        public global::Novu.GetChannelEndpointResponseDtoChannel? Channel { get; set; }

        /// <summary>
        /// The provider identifier (e.g., sendgrid, twilio, slack, etc.).<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter))]
        public global::Novu.GetChannelEndpointResponseDtoProviderId? ProviderId { get; set; }

        /// <summary>
        /// The identifier of the integration to use for this channel endpoint.<br/>
        /// Example: slack-prod
        /// </summary>
        /// <example>slack-prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        public string? IntegrationIdentifier { get; set; }

        /// <summary>
        /// The identifier of the channel connection used for this endpoint.<br/>
        /// Example: slack-connection-abc123
        /// </summary>
        /// <example>slack-connection-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionIdentifier")]
        public string? ConnectionIdentifier { get; set; }

        /// <summary>
        /// The subscriber ID to which the channel endpoint is linked<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// The context of the channel connection<br/>
        /// Example: [tenant:org-123, region:us-east-1]
        /// </summary>
        /// <example>[tenant:org-123, region:us-east-1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ContextKeys { get; set; }

        /// <summary>
        /// Type of channel endpoint<br/>
        /// Example: slack_channel
        /// </summary>
        /// <example>slack_channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.GetChannelEndpointResponseDtoType Type { get; set; }

        /// <summary>
        /// Endpoint data specific to the channel type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto> Endpoint { get; set; }

        /// <summary>
        /// The timestamp indicating when the channel endpoint was created, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The timestamp indicating when the channel endpoint was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelEndpointResponseDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// The unique identifier of the channel endpoint.
        /// </param>
        /// <param name="contextKeys">
        /// The context of the channel connection<br/>
        /// Example: [tenant:org-123, region:us-east-1]
        /// </param>
        /// <param name="type">
        /// Type of channel endpoint<br/>
        /// Example: slack_channel
        /// </param>
        /// <param name="endpoint">
        /// Endpoint data specific to the channel type
        /// </param>
        /// <param name="createdAt">
        /// The timestamp indicating when the channel endpoint was created, in ISO 8601 format.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp indicating when the channel endpoint was last updated, in ISO 8601 format.
        /// </param>
        /// <param name="channel">
        /// The channel type (email, sms, push, chat, etc.).
        /// </param>
        /// <param name="providerId">
        /// The provider identifier (e.g., sendgrid, twilio, slack, etc.).<br/>
        /// Example: slack
        /// </param>
        /// <param name="integrationIdentifier">
        /// The identifier of the integration to use for this channel endpoint.<br/>
        /// Example: slack-prod
        /// </param>
        /// <param name="connectionIdentifier">
        /// The identifier of the channel connection used for this endpoint.<br/>
        /// Example: slack-connection-abc123
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID to which the channel endpoint is linked<br/>
        /// Example: subscriber-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelEndpointResponseDto(
            string identifier,
            global::System.Collections.Generic.IList<string> contextKeys,
            global::Novu.GetChannelEndpointResponseDtoType type,
            global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto> endpoint,
            string createdAt,
            string updatedAt,
            global::Novu.GetChannelEndpointResponseDtoChannel? channel,
            global::Novu.GetChannelEndpointResponseDtoProviderId? providerId,
            string? integrationIdentifier,
            string? connectionIdentifier,
            string? subscriberId)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Channel = channel;
            this.ProviderId = providerId;
            this.IntegrationIdentifier = integrationIdentifier;
            this.ConnectionIdentifier = connectionIdentifier;
            this.SubscriberId = subscriberId;
            this.ContextKeys = contextKeys ?? throw new global::System.ArgumentNullException(nameof(contextKeys));
            this.Type = type;
            this.Endpoint = endpoint;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelEndpointResponseDto" /> class.
        /// </summary>
        public GetChannelEndpointResponseDto()
        {
        }
    }
}