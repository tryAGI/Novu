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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse> ChannelConnectionsControllerGetChannelConnectionByIdentifierAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a channel connection<br/>
        /// Retrieve a specific channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse>> ChannelConnectionsControllerGetChannelConnectionByIdentifierAsResponseAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}