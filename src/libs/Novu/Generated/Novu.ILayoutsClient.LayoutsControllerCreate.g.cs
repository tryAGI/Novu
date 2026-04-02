#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Create a layout<br/>
        /// Creates a new layout in the Novu Cloud environment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerCreateResponse> LayoutsControllerCreateAsync(

            global::Novu.CreateLayoutDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a layout<br/>
        /// Creates a new layout in the Novu Cloud environment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.LayoutsControllerCreateResponse>> LayoutsControllerCreateAsResponseAsync(

            global::Novu.CreateLayoutDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a layout<br/>
        /// Creates a new layout in the Novu Cloud environment
        /// </summary>
        /// <param name="layoutId">
        /// Unique identifier for the layout
        /// </param>
        /// <param name="name">
        /// Name of the layout
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this layout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="source">
        /// Source of layout creation<br/>
        /// Default Value: dashboard
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerCreateResponse> LayoutsControllerCreateAsync(
            string layoutId,
            string name,
            bool? isTranslationEnabled = default,
            global::Novu.LayoutCreationSourceEnum? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}