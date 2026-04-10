#nullable enable

namespace Novu
{
    public partial interface ITranslationsMasterClient
    {
        /// <summary>
        /// Upload master translations JSON file<br/>
        /// Upload a master JSON file containing translations for multiple workflows. Locale is automatically detected from filename (e.g., en_US.json)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ImportMasterJsonResponseDto> Upload2Async(

            global::Novu.TranslationControllerUploadMasterJsonEndpointRequest request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload master translations JSON file<br/>
        /// Upload a master JSON file containing translations for multiple workflows. Locale is automatically detected from filename (e.g., en_US.json)
        /// </summary>
        /// <param name="file">
        /// Master JSON file with locale as filename (e.g., en_US.json)
        /// </param>
        /// <param name="filename">
        /// Master JSON file with locale as filename (e.g., en_US.json)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ImportMasterJsonResponseDto> Upload2Async(
            byte[] file,
            string filename,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}