#nullable enable

namespace Novu
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Retrieve master translations JSON<br/>
        /// Retrieve all translations for a locale in master JSON format organized by resourceId (workflowId)
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.GetMasterJsonResponseDto> TranslationControllerGetMasterJsonEndpointAsync(
            string? locale = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}