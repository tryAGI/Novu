#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Update a layout<br/>
        /// Updates the details of an existing layout, here **layoutId** is the identifier of the layout
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerUpdateResponse> LayoutsControllerUpdateAsync(
            string layoutId,

            global::Novu.UpdateLayoutDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a layout<br/>
        /// Updates the details of an existing layout, here **layoutId** is the identifier of the layout
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.LayoutsControllerUpdateResponse>> LayoutsControllerUpdateAsResponseAsync(
            string layoutId,

            global::Novu.UpdateLayoutDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a layout<br/>
        /// Updates the details of an existing layout, here **layoutId** is the identifier of the layout
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="name">
        /// Name of the layout
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this layout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="controlValues">
        /// Control values for the layout. Omit to leave unchanged, or set to null to clear stored control values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerUpdateResponse> LayoutsControllerUpdateAsync(
            string layoutId,
            string name,
            bool? isTranslationEnabled = default,
            global::Novu.LayoutControlValuesDto? controlValues = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}