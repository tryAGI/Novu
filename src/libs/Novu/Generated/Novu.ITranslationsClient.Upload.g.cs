#nullable enable

namespace Novu
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Upload translation files<br/>
        /// Upload one or more JSON translation files for a specific workflow. Files name must match the locale, e.g. en_US.json. Supports both "files" and "files[]" field names for backwards compatibility.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.UploadTranslationsResponseDto> UploadAsync(

            global::Novu.TranslationControllerUploadTranslationFilesRequest request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload translation files<br/>
        /// Upload one or more JSON translation files for a specific workflow. Files name must match the locale, e.g. en_US.json. Supports both "files" and "files[]" field names for backwards compatibility.
        /// </summary>
        /// <param name="resourceId">
        /// The resource ID to associate localizations with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// The resource type to associate localizations with
        /// </param>
        /// <param name="files">
        /// One or more JSON translation files. Filenames must match locale format (e.g., en_US.json, fr_FR.json). Field name can be "files" or "files[]".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.UploadTranslationsResponseDto> UploadAsync(
            string resourceId,
            global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType resourceType,
            global::System.Collections.Generic.IList<byte[]> files,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}