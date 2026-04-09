#nullable enable

namespace Novu
{
    public partial interface IChannelEndpointsClient
    {
        /// <summary>
        /// List all channel endpoints<br/>
        /// List all channel endpoints for a resource based on query filters.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="subscriberId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="channel"></param>
        /// <param name="providerId">
        /// Provider ID of the job
        /// </param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="connectionIdentifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse> ListAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? subscriberId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? channel = default,
            global::Novu.ProvidersIdEnum? providerId = default,
            string? integrationIdentifier = default,
            string? connectionIdentifier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all channel endpoints<br/>
        /// List all channel endpoints for a resource based on query filters.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="subscriberId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="channel"></param>
        /// <param name="providerId">
        /// Provider ID of the job
        /// </param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="connectionIdentifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse>> ListAsResponseAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? subscriberId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? channel = default,
            global::Novu.ProvidersIdEnum? providerId = default,
            string? integrationIdentifier = default,
            string? connectionIdentifier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}