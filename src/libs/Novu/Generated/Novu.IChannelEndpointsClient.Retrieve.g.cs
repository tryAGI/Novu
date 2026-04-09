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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse> RetrieveAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a channel endpoint<br/>
        /// Retrieve a specific channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse>> RetrieveAsResponseAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}