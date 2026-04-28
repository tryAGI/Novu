#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Generate OAuth URL for a workspace/tenant connection<br/>
        /// Generate an OAuth URL that creates a workspace or tenant-level channel connection (Slack workspace install or MS Teams admin consent). <br/>
        ///     The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse> GenerateConnectOAuthUrlAsync(

            global::Novu.GenerateConnectOauthUrlRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate OAuth URL for a workspace/tenant connection<br/>
        /// Generate an OAuth URL that creates a workspace or tenant-level channel connection (Slack workspace install or MS Teams admin consent). <br/>
        ///     The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse>> GenerateConnectOAuthUrlAsResponseAsync(

            global::Novu.GenerateConnectOauthUrlRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate OAuth URL for a workspace/tenant connection<br/>
        /// Generate an OAuth URL that creates a workspace or tenant-level channel connection (Slack workspace install or MS Teams admin consent). <br/>
        ///     The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="subscriberId">
        /// The subscriber ID to associate with the channel connection. For Slack: optional for workspace connections (required only for incoming-webhook scope). For MS Teams: optional. Admin consent is tenant-wide.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="integrationIdentifier">
        /// Integration identifier
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse> GenerateConnectOAuthUrlAsync(
            string integrationIdentifier,
            string? subscriberId = default,
            string? connectionIdentifier = default,
            object? context = default,
            global::System.Collections.Generic.IList<string>? scope = default,
            global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? connectionMode = default,
            bool? autoLinkUser = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}