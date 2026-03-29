#nullable enable

namespace Novu
{
    public partial interface IChannelConnectionsClient
    {
        /// <summary>
        /// Delete a channel connection<br/>
        /// Delete a specific channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task ChannelConnectionsControllerDeleteChannelConnectionAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}