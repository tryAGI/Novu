#nullable enable

namespace Novu
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Create a translation<br/>
        /// Create a translation for a specific workflow and locale, if the translation already exists, it will be updated
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TranslationResponseDto> CreateAsync(

            global::Novu.CreateTranslationRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a translation<br/>
        /// Create a translation for a specific workflow and locale, if the translation already exists, it will be updated
        /// </summary>
        /// <param name="resourceId">
        /// The resource ID to associate translation with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// The resource type to associate translation with
        /// </param>
        /// <param name="locale">
        /// Locale code (e.g., en_US, es_ES)<br/>
        /// Example: en_US
        /// </param>
        /// <param name="content">
        /// Translation content as JSON object<br/>
        /// Example: {"welcome.title":"Welcome","welcome.message":"Hello there!"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TranslationResponseDto> CreateAsync(
            string resourceId,
            global::Novu.CreateTranslationRequestDtoResourceType resourceType,
            string locale,
            object content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}