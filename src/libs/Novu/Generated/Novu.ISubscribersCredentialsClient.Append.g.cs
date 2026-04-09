#nullable enable

namespace Novu
{
    public partial interface ISubscribersCredentialsClient
    {
        /// <summary>
        /// Upsert provider credentials<br/>
        /// Upsert credentials for a provider such as **slack** and **FCM**. <br/>
        ///       **providerId** is required field. This API creates **deviceTokens** or appends to the existing ones.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse> AppendAsync(
            string subscriberId,

            global::Novu.UpdateSubscriberChannelRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert provider credentials<br/>
        /// Upsert credentials for a provider such as **slack** and **FCM**. <br/>
        ///       **providerId** is required field. This API creates **deviceTokens** or appends to the existing ones.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse>> AppendAsResponseAsync(
            string subscriberId,

            global::Novu.UpdateSubscriberChannelRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert provider credentials<br/>
        /// Upsert credentials for a provider such as **slack** and **FCM**. <br/>
        ///       **providerId** is required field. This API creates **deviceTokens** or appends to the existing ones.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="providerId">
        /// The provider identifier for the credentials
        /// </param>
        /// <param name="integrationIdentifier">
        /// The integration identifier
        /// </param>
        /// <param name="credentials">
        /// Credentials payload for the specified provider
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse> AppendAsync(
            string subscriberId,
            global::Novu.ChatOrPushProviderEnum providerId,
            global::Novu.ChannelCredentials credentials,
            string? integrationIdentifier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}