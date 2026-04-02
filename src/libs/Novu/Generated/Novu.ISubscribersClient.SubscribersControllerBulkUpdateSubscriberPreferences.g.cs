#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Bulk update subscriber preferences<br/>
        /// Bulk update subscriber preferences by its unique key identifier **subscriberId**. <br/>
        ///     This API allows updating multiple workflow preferences in a single request.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse> SubscribersControllerBulkUpdateSubscriberPreferencesAsync(
            string subscriberId,

            global::Novu.BulkUpdateSubscriberPreferencesDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update subscriber preferences<br/>
        /// Bulk update subscriber preferences by its unique key identifier **subscriberId**. <br/>
        ///     This API allows updating multiple workflow preferences in a single request.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse>> SubscribersControllerBulkUpdateSubscriberPreferencesAsResponseAsync(
            string subscriberId,

            global::Novu.BulkUpdateSubscriberPreferencesDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update subscriber preferences<br/>
        /// Bulk update subscriber preferences by its unique key identifier **subscriberId**. <br/>
        ///     This API allows updating multiple workflow preferences in a single request.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="preferences">
        /// Array of workflow preferences to update (maximum 100 items)
        /// </param>
        /// <param name="context"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse> SubscribersControllerBulkUpdateSubscriberPreferencesAsync(
            string subscriberId,
            global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto> preferences,
            object? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}