#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Retrieve a subscriber<br/>
        /// Retrieve a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     **subscriberId** field is required.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerGetSubscriberResponse> RetrieveAsync(
            string subscriberId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a subscriber<br/>
        /// Retrieve a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     **subscriberId** field is required.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerGetSubscriberResponse>> RetrieveAsResponseAsync(
            string subscriberId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}