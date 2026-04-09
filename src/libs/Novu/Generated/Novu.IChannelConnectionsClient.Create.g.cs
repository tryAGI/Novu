#nullable enable

namespace Novu
{
    public partial interface IChannelConnectionsClient
    {
        /// <summary>
        /// Create a channel connection<br/>
        /// Create a new channel connection for a resource for given integration. Only one channel connection is allowed per resource and integration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse> CreateAsync(

            global::Novu.CreateChannelConnectionRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a channel connection<br/>
        /// Create a new channel connection for a resource for given integration. Only one channel connection is allowed per resource and integration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse>> CreateAsResponseAsync(

            global::Novu.CreateChannelConnectionRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a channel connection<br/>
        /// Create a new channel connection for a resource for given integration. Only one channel connection is allowed per resource and integration.
        /// </summary>
        /// <param name="identifier">
        /// The unique identifier for the channel connection. If not provided, one will be generated automatically.<br/>
        /// Example: slack-prod-user123-abc4
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID to link the channel connection to<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="context"></param>
        /// <param name="integrationIdentifier">
        /// The identifier of the integration to use for this channel connection.<br/>
        /// Example: slack-prod
        /// </param>
        /// <param name="workspace"></param>
        /// <param name="auth"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse> CreateAsync(
            string integrationIdentifier,
            global::Novu.WorkspaceDto workspace,
            global::Novu.AuthDto auth,
            string? identifier = default,
            string? subscriberId = default,
            object? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}