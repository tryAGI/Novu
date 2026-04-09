#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Delete a subscriber<br/>
        /// Deletes a subscriber entity from the Novu platform along with associated messages, preferences, and topic subscriptions. <br/>
        ///       **subscriberId** is a required field.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerRemoveSubscriberResponse> DeleteAsync(
            string subscriberId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a subscriber<br/>
        /// Deletes a subscriber entity from the Novu platform along with associated messages, preferences, and topic subscriptions. <br/>
        ///       **subscriberId** is a required field.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerRemoveSubscriberResponse>> DeleteAsResponseAsync(
            string subscriberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}