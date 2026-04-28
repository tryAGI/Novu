#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Generate OAuth URL to link a subscriber user identity<br/>
        /// Generate an OAuth URL that links a specific subscriber to their chat identity (Slack user ID or MS Teams user OID). <br/>
        ///     The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse> GenerateLinkUserOAuthUrlAsync(

            global::Novu.GenerateLinkUserOauthUrlRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate OAuth URL to link a subscriber user identity<br/>
        /// Generate an OAuth URL that links a specific subscriber to their chat identity (Slack user ID or MS Teams user OID). <br/>
        ///     The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse>> GenerateLinkUserOAuthUrlAsResponseAsync(

            global::Novu.GenerateLinkUserOauthUrlRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate OAuth URL to link a subscriber user identity<br/>
        /// Generate an OAuth URL that links a specific subscriber to their chat identity (Slack user ID or MS Teams user OID). <br/>
        ///     The generated URL expires after 5 minutes.
        /// </summary>
        /// <param name="subscriberId">
        /// The subscriber ID to link to their chat identity. Required — this operation always binds a specific subscriber to a user identity in the chat provider.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="integrationIdentifier">
        /// Integration identifier
        /// </param>
        /// <param name="connectionIdentifier">
        /// Identifier of the existing channel connection to associate this user endpoint with. Generated automatically if not provided.<br/>
        /// Example: slack-connection-abc123
        /// </param>
        /// <param name="context"></param>
        /// <param name="userScope">
        /// **Slack only**: User-level OAuth scopes for "Sign in with Slack". Defaults to: identity.basic. **MS Teams**: ignored — uses delegated OpenID scopes (openid, profile, User.Read).<br/>
        /// Example: [identity.basic]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse> GenerateLinkUserOAuthUrlAsync(
            string subscriberId,
            string integrationIdentifier,
            string? connectionIdentifier = default,
            object? context = default,
            global::System.Collections.Generic.IList<string>? userScope = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}