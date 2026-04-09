#nullable enable

namespace Novu
{
    public partial interface IChannelEndpointsClient
    {
        /// <summary>
        /// Update a channel endpoint<br/>
        /// Update an existing channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse> UpdateAsync(
            string identifier,

            global::Novu.UpdateChannelEndpointRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a channel endpoint<br/>
        /// Update an existing channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse>> UpdateAsResponseAsync(
            string identifier,

            global::Novu.UpdateChannelEndpointRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a channel endpoint<br/>
        /// Update an existing channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="endpoint">
        /// Updated endpoint data. The structure must match the existing channel endpoint type.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse> UpdateAsync(
            string identifier,
            global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto> endpoint,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}