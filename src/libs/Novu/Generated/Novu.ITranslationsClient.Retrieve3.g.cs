#nullable enable

namespace Novu
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Retrieve a translation<br/>
        /// Retrieve a specific translation by resource type, resource ID and locale
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        /// <param name="locale"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TranslationResponseDto> Retrieve3Async(
            global::Novu.TranslationControllerGetSingleTranslationResourceType resourceType,
            string resourceId,
            string locale,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}