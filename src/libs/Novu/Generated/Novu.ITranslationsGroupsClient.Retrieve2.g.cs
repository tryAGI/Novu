#nullable enable

namespace Novu
{
    public partial interface ITranslationsGroupsClient
    {
        /// <summary>
        /// Retrieve a translation group<br/>
        /// Retrieves a single translation group by resource type (workflow, layout) and resource ID (workflowId, layoutId)
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TranslationGroupDto> Retrieve2Async(
            global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType resourceType,
            string resourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}