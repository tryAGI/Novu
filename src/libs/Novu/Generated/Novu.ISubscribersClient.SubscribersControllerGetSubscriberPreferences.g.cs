#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Retrieve subscriber preferences<br/>
        /// Retrieve subscriber channel preferences by its unique key identifier **subscriberId**. <br/>
        ///     This API returns all five channels preferences for all workflows and global preferences.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="criticality">
        /// Default Value: nonCritical
        /// </param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerGetSubscriberPreferencesResponse> SubscribersControllerGetSubscriberPreferencesAsync(
            string subscriberId,
            global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? criticality = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve subscriber preferences<br/>
        /// Retrieve subscriber channel preferences by its unique key identifier **subscriberId**. <br/>
        ///     This API returns all five channels preferences for all workflows and global preferences.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="criticality">
        /// Default Value: nonCritical
        /// </param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerGetSubscriberPreferencesResponse>> SubscribersControllerGetSubscriberPreferencesAsResponseAsync(
            string subscriberId,
            global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? criticality = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}