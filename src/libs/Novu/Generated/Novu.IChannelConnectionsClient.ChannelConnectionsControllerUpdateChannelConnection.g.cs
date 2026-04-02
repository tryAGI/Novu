#nullable enable

namespace Novu
{
    public partial interface IChannelConnectionsClient
    {
        /// <summary>
        /// Update a channel connection<br/>
        /// Update an existing channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse> ChannelConnectionsControllerUpdateChannelConnectionAsync(
            string identifier,

            global::Novu.UpdateChannelConnectionRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a channel connection<br/>
        /// Update an existing channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse>> ChannelConnectionsControllerUpdateChannelConnectionAsResponseAsync(
            string identifier,

            global::Novu.UpdateChannelConnectionRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a channel connection<br/>
        /// Update an existing channel connection by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="workspace"></param>
        /// <param name="auth"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse> ChannelConnectionsControllerUpdateChannelConnectionAsync(
            string identifier,
            global::Novu.WorkspaceDto workspace,
            global::Novu.AuthDto auth,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}