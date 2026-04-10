#nullable enable

namespace Novu
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Track activity and engagement events<br/>
        /// Track activity and engagement events for a specific delivery provider
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>> TrackAsync(
            string environmentId,
            string integrationId,

            object request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track activity and engagement events<br/>
        /// Track activity and engagement events for a specific delivery provider
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="integrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>> TrackAsync(
            string environmentId,
            string integrationId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}