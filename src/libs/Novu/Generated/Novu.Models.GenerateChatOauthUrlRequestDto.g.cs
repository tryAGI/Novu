
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateChatOauthUrlRequestDto
    {
        /// <summary>
        /// The subscriber ID to link the channel connection to. For Slack: Required for incoming webhook endpoints, optional for workspace connections. For MS Teams: Optional. Admin consent is tenant-wide and can be associated with a subscriber for organizational purposes.<br/>
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
        /// Identifier of the channel connection that will be created. It is generated automatically if not provided.<br/>
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
        /// **Slack only**: OAuth scopes to request during authorization. These define the permissions your Slack integration will have. If not specified, default scopes will be used: chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email. **MS Teams**: This parameter is ignored. MS Teams uses admin consent with pre-configured permissions in Azure AD. Note: The generated OAuth URL expires after 5 minutes.<br/>
        /// Example: [chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email, incoming-webhook]
        /// </summary>
        /// <example>[chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email, incoming-webhook]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<string>? Scope { get; set; }

        /// <summary>
        /// **Slack only, link_user mode**: User-level OAuth scopes to request during authorization. Used when mode is "link_user" to identify the Slack user via "Sign in with Slack". If not specified, defaults to: identity.basic.<br/>
        /// Example: [identity.basic]
        /// </summary>
        /// <example>[identity.basic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScope")]
        public global::System.Collections.Generic.IList<string>? UserScope { get; set; }

        /// <summary>
        /// OAuth flow mode. Use "connect" (default) to create a workspace channel connection, or "link_user" to identify the subscriber's Slack user ID without creating a connection.<br/>
        /// Example: link_user
        /// </summary>
        /// <example>link_user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter))]
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Mode { get; set; }

        /// <summary>
        /// Connection mode that determines how the channel connection is scoped. Use "subscriber" (default) to associate the connection with a specific subscriber. Use "shared" to associate the connection with a context instead of a subscriber — subscriberId will not be stored on the connection.<br/>
        /// Example: shared
        /// </summary>
        /// <example>shared</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter))]
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? ConnectionMode { get; set; }

        /// <summary>
        /// When true, after the workspace/tenant connection is created the OAuth flow also links the subscriber who clicked "Connect" as a personal endpoint. For Slack, this uses the authed_user.id already returned by oauth.v2.access — no extra redirect. For MS Teams, this triggers a second OAuth redirect for delegated user-identity consent. Defaults to false when omitted; the SlackConnectButton and MsTeamsConnectButton SDK components default this to true.<br/>
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
        /// Initializes a new instance of the <see cref="GenerateChatOauthUrlRequestDto" /> class.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// Integration identifier
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID to link the channel connection to. For Slack: Required for incoming webhook endpoints, optional for workspace connections. For MS Teams: Optional. Admin consent is tenant-wide and can be associated with a subscriber for organizational purposes.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="connectionIdentifier">
        /// Identifier of the channel connection that will be created. It is generated automatically if not provided.<br/>
        /// Example: slack-connection-abc123
        /// </param>
        /// <param name="context"></param>
        /// <param name="scope">
        /// **Slack only**: OAuth scopes to request during authorization. These define the permissions your Slack integration will have. If not specified, default scopes will be used: chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email. **MS Teams**: This parameter is ignored. MS Teams uses admin consent with pre-configured permissions in Azure AD. Note: The generated OAuth URL expires after 5 minutes.<br/>
        /// Example: [chat:write, chat:write.public, channels:read, groups:read, users:read, users:read.email, incoming-webhook]
        /// </param>
        /// <param name="userScope">
        /// **Slack only, link_user mode**: User-level OAuth scopes to request during authorization. Used when mode is "link_user" to identify the Slack user via "Sign in with Slack". If not specified, defaults to: identity.basic.<br/>
        /// Example: [identity.basic]
        /// </param>
        /// <param name="mode">
        /// OAuth flow mode. Use "connect" (default) to create a workspace channel connection, or "link_user" to identify the subscriber's Slack user ID without creating a connection.<br/>
        /// Example: link_user
        /// </param>
        /// <param name="connectionMode">
        /// Connection mode that determines how the channel connection is scoped. Use "subscriber" (default) to associate the connection with a specific subscriber. Use "shared" to associate the connection with a context instead of a subscriber — subscriberId will not be stored on the connection.<br/>
        /// Example: shared
        /// </param>
        /// <param name="autoLinkUser">
        /// When true, after the workspace/tenant connection is created the OAuth flow also links the subscriber who clicked "Connect" as a personal endpoint. For Slack, this uses the authed_user.id already returned by oauth.v2.access — no extra redirect. For MS Teams, this triggers a second OAuth redirect for delegated user-identity consent. Defaults to false when omitted; the SlackConnectButton and MsTeamsConnectButton SDK components default this to true.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateChatOauthUrlRequestDto(
            string integrationIdentifier,
            string? subscriberId,
            string? connectionIdentifier,
            object? context,
            global::System.Collections.Generic.IList<string>? scope,
            global::System.Collections.Generic.IList<string>? userScope,
            global::Novu.GenerateChatOauthUrlRequestDtoMode? mode,
            global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? connectionMode,
            bool? autoLinkUser)
        {
            this.SubscriberId = subscriberId;
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.ConnectionIdentifier = connectionIdentifier;
            this.Context = context;
            this.Scope = scope;
            this.UserScope = userScope;
            this.Mode = mode;
            this.ConnectionMode = connectionMode;
            this.AutoLinkUser = autoLinkUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateChatOauthUrlRequestDto" /> class.
        /// </summary>
        public GenerateChatOauthUrlRequestDto()
        {
        }
    }
}