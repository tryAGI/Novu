#nullable enable

namespace Novu
{
    public partial interface ISubscribersPreferencesClient
    {
        /// <summary>
        /// Update subscriber preferences<br/>
        /// Update subscriber preferences by its unique key identifier **subscriberId**. <br/>
        ///     **workflowId** is optional field, if provided, this API will update that workflow preference, <br/>
        ///     otherwise it will update global preferences
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse> UpdateAsync(
            string subscriberId,

            global::Novu.PatchSubscriberPreferencesDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update subscriber preferences<br/>
        /// Update subscriber preferences by its unique key identifier **subscriberId**. <br/>
        ///     **workflowId** is optional field, if provided, this API will update that workflow preference, <br/>
        ///     otherwise it will update global preferences
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse>> UpdateAsResponseAsync(
            string subscriberId,

            global::Novu.PatchSubscriberPreferencesDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update subscriber preferences<br/>
        /// Update subscriber preferences by its unique key identifier **subscriberId**. <br/>
        ///     **workflowId** is optional field, if provided, this API will update that workflow preference, <br/>
        ///     otherwise it will update global preferences
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="channels">
        /// Channel-specific preference settings
        /// </param>
        /// <param name="workflowId">
        /// Workflow internal _id, identifier or slug. If provided, update workflow specific preferences, otherwise update global preferences
        /// </param>
        /// <param name="schedule">
        /// Subscriber schedule
        /// </param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse> UpdateAsync(
            string subscriberId,
            global::Novu.PatchPreferenceChannelsDto? channels = default,
            string? workflowId = default,
            global::Novu.ScheduleDto? schedule = default,
            object? context = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}