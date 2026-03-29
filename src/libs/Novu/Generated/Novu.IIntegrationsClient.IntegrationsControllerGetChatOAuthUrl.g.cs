#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Generate chat OAuth URL<br/>
        /// Generate an OAuth URL for chat integrations like Slack and MS Teams. <br/>
        ///     This URL allows subscribers to authorize the integration, enabling the system to send messages <br/>
        ///     through their chat workspace. The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerGetChatOAuthUrlResponse> IntegrationsControllerGetChatOAuthUrlAsync(

            global::Novu.GenerateChatOauthUrlRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate chat OAuth URL<br/>
        /// Generate an OAuth URL for chat integrations like Slack and MS Teams. <br/>
        ///     This URL allows subscribers to authorize the integration, enabling the system to send messages <br/>
        ///     through their chat workspace. The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="subscriberId">
        /// The subscriber ID to link the channel connection to. For Slack: Required for incoming webhook endpoints, optional for workspace connections. For MS Teams: Optional. Admin consent is tenant-wide and can be associated with a subscriber for organizational purposes.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="integrationIdentifier">
        /// Integration identifier
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerGetChatOAuthUrlResponse> IntegrationsControllerGetChatOAuthUrlAsync(
            string integrationIdentifier,
            string? subscriberId = default,
            string? connectionIdentifier = default,
            object? context = default,
            global::System.Collections.Generic.IList<string>? scope = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}