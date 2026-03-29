
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelConnectionResponseDto
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter))]
        public global::Novu.GetChannelConnectionResponseDtoChannel? Channel { get; set; }

        /// <summary>
        /// The provider identifier (e.g., sendgrid, twilio, slack, etc.).<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter))]
        public global::Novu.GetChannelConnectionResponseDtoProviderId? ProviderId { get; set; }

        /// <summary>
        /// The identifier of the integration to use for this channel endpoint.<br/>
        /// Example: slack-prod
        /// </summary>
        /// <example>slack-prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        public string? IntegrationIdentifier { get; set; }

        /// <summary>
        /// The subscriber ID to which the channel connection is linked<br/>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkspaceDto Workspace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.AuthDto Auth { get; set; }

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
        /// Initializes a new instance of the <see cref="GetChannelConnectionResponseDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// The unique identifier of the channel endpoint.
        /// </param>
        /// <param name="contextKeys">
        /// The context of the channel connection<br/>
        /// Example: [tenant:org-123, region:us-east-1]
        /// </param>
        /// <param name="workspace"></param>
        /// <param name="auth"></param>
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
        /// <param name="subscriberId">
        /// The subscriber ID to which the channel connection is linked<br/>
        /// Example: subscriber-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelConnectionResponseDto(
            string identifier,
            global::System.Collections.Generic.IList<string> contextKeys,
            global::Novu.WorkspaceDto workspace,
            global::Novu.AuthDto auth,
            string createdAt,
            string updatedAt,
            global::Novu.GetChannelConnectionResponseDtoChannel? channel,
            global::Novu.GetChannelConnectionResponseDtoProviderId? providerId,
            string? integrationIdentifier,
            string? subscriberId)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Channel = channel;
            this.ProviderId = providerId;
            this.IntegrationIdentifier = integrationIdentifier;
            this.SubscriberId = subscriberId;
            this.ContextKeys = contextKeys ?? throw new global::System.ArgumentNullException(nameof(contextKeys));
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelConnectionResponseDto" /> class.
        /// </summary>
        public GetChannelConnectionResponseDto()
        {
        }
    }
}