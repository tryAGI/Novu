#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Issue a URL to link a subscriber chat identity<br/>
        /// Returns a provider-specific URL the subscriber opens to link their chat identity. The integration provider is resolved from integrationIdentifier; Telegram returns a deep link.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerLinkChannelEndpointResponse> LinkChannelEndpointAsync(

            global::Novu.LinkChannelEndpointRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue a URL to link a subscriber chat identity<br/>
        /// Returns a provider-specific URL the subscriber opens to link their chat identity. The integration provider is resolved from integrationIdentifier; Telegram returns a deep link.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerLinkChannelEndpointResponse>> LinkChannelEndpointAsResponseAsync(

            global::Novu.LinkChannelEndpointRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue a URL to link a subscriber chat identity<br/>
        /// Returns a provider-specific URL the subscriber opens to link their chat identity. The integration provider is resolved from integrationIdentifier; Telegram returns a deep link.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// Integration identifier for the chat provider integration<br/>
        /// Example: telegram-bot
        /// </param>
        /// <param name="subscriberId">
        /// External subscriber identifier to link to their chat identity<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="context"></param>
        /// <param name="contextHash">
        /// HMAC-SHA256 of the canonicalized `context`, signed with the tenant environment secret key (the same "Inbox with context" signing scheme). Required when the integration has HMAC validation enabled.<br/>
        /// Example: a1b2c3d4e5f6...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerLinkChannelEndpointResponse> LinkChannelEndpointAsync(
            string integrationIdentifier,
            string subscriberId,
            object? context = default,
            string? contextHash = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}