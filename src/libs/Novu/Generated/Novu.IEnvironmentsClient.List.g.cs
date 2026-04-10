#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List all environments<br/>
        /// This API returns a list of environments for the current organization. <br/>
        ///     Each environment contains its configuration, API keys (if user has access), and metadata.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse> ListAsync(
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all environments<br/>
        /// This API returns a list of environments for the current organization. <br/>
        ///     Each environment contains its configuration, API keys (if user has access), and metadata.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse>> ListAsResponseAsync(
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}