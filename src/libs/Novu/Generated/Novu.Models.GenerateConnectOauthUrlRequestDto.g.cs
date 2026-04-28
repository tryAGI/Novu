
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateConnectOauthUrlRequestDto
    {
        /// <summary>
        /// The subscriber ID to associate with the channel connection. For Slack: optional for workspace connections (required only for incoming-webhook scope). For MS Teams: optional. Admin consent is tenant-wide.<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// Integration identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// Identifier of the channel connection that will be created. Generated automatically if not provided.<br/>
        /// Example: slack-connection-abc123
        /// </summary>
        /// <example>slack-connection-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionIdentifier")]
        public string? ConnectionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// **Slack only**: OAuth scopes to request during authorization. If not specified, default scopes will be used: chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email. **MS Teams**: ignored — uses admin consent with pre-configured Azure AD permissions.<br/>
        /// Example: [chat:write, chat:write.public, channels:read]
        /// </summary>
        /// <example>[chat:write, chat:write.public, channels:read]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<string>? Scope { get; set; }

        /// <summary>
        /// Connection mode that determines how the channel connection is scoped. "subscriber" (default) associates the connection with a specific subscriber. "shared" associates the connection with a context instead of a subscriber.<br/>
        /// Example: shared
        /// </summary>
        /// <example>shared</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter))]
        public global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? ConnectionMode { get; set; }

        /// <summary>
        /// When true (default when connectionMode is "subscriber"), after the workspace/tenant connection is created the OAuth flow also links the subscriber who clicked "Connect" as a personal endpoint. For Slack, uses the authed_user.id returned by oauth.v2.access — no extra redirect. For MS Teams, triggers a second OAuth redirect for delegated user-identity consent. Set to false to only create the workspace connection without linking the individual user.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoLinkUser")]
        public bool? AutoLinkUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateConnectOauthUrlRequestDto" /> class.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// Integration identifier
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID to associate with the channel connection. For Slack: optional for workspace connections (required only for incoming-webhook scope). For MS Teams: optional. Admin consent is tenant-wide.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="connectionIdentifier">
        /// Identifier of the channel connection that will be created. Generated automatically if not provided.<br/>
        /// Example: slack-connection-abc123
        /// </param>
        /// <param name="context"></param>
        /// <param name="scope">
        /// **Slack only**: OAuth scopes to request during authorization. If not specified, default scopes will be used: chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email. **MS Teams**: ignored — uses admin consent with pre-configured Azure AD permissions.<br/>
        /// Example: [chat:write, chat:write.public, channels:read]
        /// </param>
        /// <param name="connectionMode">
        /// Connection mode that determines how the channel connection is scoped. "subscriber" (default) associates the connection with a specific subscriber. "shared" associates the connection with a context instead of a subscriber.<br/>
        /// Example: shared
        /// </param>
        /// <param name="autoLinkUser">
        /// When true (default when connectionMode is "subscriber"), after the workspace/tenant connection is created the OAuth flow also links the subscriber who clicked "Connect" as a personal endpoint. For Slack, uses the authed_user.id returned by oauth.v2.access — no extra redirect. For MS Teams, triggers a second OAuth redirect for delegated user-identity consent. Set to false to only create the workspace connection without linking the individual user.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateConnectOauthUrlRequestDto(
            string integrationIdentifier,
            string? subscriberId,
            string? connectionIdentifier,
            object? context,
            global::System.Collections.Generic.IList<string>? scope,
            global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? connectionMode,
            bool? autoLinkUser)
        {
            this.SubscriberId = subscriberId;
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.ConnectionIdentifier = connectionIdentifier;
            this.Context = context;
            this.Scope = scope;
            this.ConnectionMode = connectionMode;
            this.AutoLinkUser = autoLinkUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateConnectOauthUrlRequestDto" /> class.
        /// </summary>
        public GenerateConnectOauthUrlRequestDto()
        {
        }
    }
}