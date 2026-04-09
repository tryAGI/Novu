#nullable enable

namespace Novu
{
    public partial interface IChannelConnectionsClient
    {
        /// <summary>
        /// List all channel connections<br/>
        /// List all channel connections for a resource.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="subscriberId"></param>
        /// <param name="channel"></param>
        /// <param name="providerId">
        /// Provider ID of the job
        /// </param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse> ListAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? subscriberId = default,
            global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? channel = default,
            global::Novu.ProvidersIdEnum? providerId = default,
            string? integrationIdentifier = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all channel connections<br/>
        /// List all channel connections for a resource.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="subscriberId"></param>
        /// <param name="channel"></param>
        /// <param name="providerId">
        /// Provider ID of the job
        /// </param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse>> ListAsResponseAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? subscriberId = default,
            global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? channel = default,
            global::Novu.ProvidersIdEnum? providerId = default,
            string? integrationIdentifier = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}