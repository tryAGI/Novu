#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Generate layout preview<br/>
        /// Generates a preview for a layout by its unique identifier **layoutId**
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerGeneratePreviewResponse> LayoutsControllerGeneratePreviewAsync(
            string layoutId,

            global::Novu.LayoutPreviewRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate layout preview<br/>
        /// Generates a preview for a layout by its unique identifier **layoutId**
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="controlValues">
        /// Optional control values for layout preview
        /// </param>
        /// <param name="previewPayload">
        /// Optional payload for layout preview
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerGeneratePreviewResponse> LayoutsControllerGeneratePreviewAsync(
            string layoutId,
            object? controlValues = default,
            global::Novu.LayoutPreviewPayloadDto? previewPayload = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}