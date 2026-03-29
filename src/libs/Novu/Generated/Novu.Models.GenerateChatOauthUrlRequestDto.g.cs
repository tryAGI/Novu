
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateChatOauthUrlRequestDto(
            string integrationIdentifier,
            string? subscriberId,
            string? connectionIdentifier,
            object? context,
            global::System.Collections.Generic.IList<string>? scope)
        {
            this.SubscriberId = subscriberId;
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.ConnectionIdentifier = connectionIdentifier;
            this.Context = context;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateChatOauthUrlRequestDto" /> class.
        /// </summary>
        public GenerateChatOauthUrlRequestDto()
        {
        }
    }
}