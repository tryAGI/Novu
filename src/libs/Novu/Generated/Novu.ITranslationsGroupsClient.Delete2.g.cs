#nullable enable

namespace Novu
{
    public partial interface ITranslationsGroupsClient
    {
        /// <summary>
        /// Delete a translation group<br/>
        /// Delete an entire translation group and all its translations
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType resourceType,
            string resourceId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}