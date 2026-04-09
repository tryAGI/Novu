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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerGetSubscriberResponse> RetrieveAsync(
            string subscriberId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a subscriber<br/>
        /// Retrieve a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     **subscriberId** field is required.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerGetSubscriberResponse>> RetrieveAsResponseAsync(
            string subscriberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}