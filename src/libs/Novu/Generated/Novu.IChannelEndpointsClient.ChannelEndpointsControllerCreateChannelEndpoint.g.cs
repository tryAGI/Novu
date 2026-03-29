#nullable enable

namespace Novu
{
    public partial interface IChannelEndpointsClient
    {
        /// <summary>
        /// Create a channel endpoint<br/>
        /// Create a new channel endpoint for a resource.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse> ChannelEndpointsControllerCreateChannelEndpointAsync(

            global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a channel endpoint<br/>
        /// Create a new channel endpoint for a resource.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse> ChannelEndpointsControllerCreateChannelEndpointAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}