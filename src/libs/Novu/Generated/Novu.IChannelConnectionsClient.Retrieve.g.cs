#nullable enable

namespace Novu
{
    public partial interface IChannelConnectionsClient
    {
        /// <summary>
        /// Retrieve a channel connection<br/>
        /// Retrieve a specific channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse> RetrieveAsync(
            string identifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a channel connection<br/>
        /// Retrieve a specific channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse>> RetrieveAsResponseAsync(
            string identifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}