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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType resourceType,
            string resourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}