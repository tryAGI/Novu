#nullable enable

namespace Novu
{
    public partial interface IChannelEndpointsClient
    {
        /// <summary>
        /// Retrieve a channel endpoint<br/>
        /// Retrieve a specific channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse> RetrieveAsync(
            string identifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a channel endpoint<br/>
        /// Retrieve a specific channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse>> RetrieveAsResponseAsync(
            string identifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}