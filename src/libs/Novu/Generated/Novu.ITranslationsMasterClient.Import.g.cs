#nullable enable

namespace Novu
{
    public partial interface ITranslationsMasterClient
    {
        /// <summary>
        /// Import master translations JSON<br/>
        /// Import translations for multiple workflows from master JSON format for a specific locale
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ImportMasterJsonResponseDto> ImportAsync(

            global::Novu.ImportMasterJsonRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import master translations JSON<br/>
        /// Import translations for multiple workflows from master JSON format for a specific locale
        /// </summary>
        /// <param name="locale">
        /// The locale for which translations are being imported<br/>
        /// Example: en_US
        /// </param>
        /// <param name="masterJson">
        /// Master JSON object containing all translations organized by workflow identifier<br/>
        /// Example: {"workflows":{"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ImportMasterJsonResponseDto> ImportAsync(
            string locale,
            object masterJson,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}