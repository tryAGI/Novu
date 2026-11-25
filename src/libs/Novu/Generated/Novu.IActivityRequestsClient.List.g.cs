#nullable enable

namespace Novu
{
    public partial interface IActivityRequestsClient
    {
        /// <summary>
        /// List activity requests<br/>
        /// Retrieve a list of activity requests with optional filtering and pagination.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="statusCodes">
        /// Example: [200, 404, 500]
        /// </param>
        /// <param name="urlPattern"></param>
        /// <param name="transactionId"></param>
        /// <param name="createdGte">
        /// Example: 1640995200
        /// </param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.GetRequestsResponseDto> ListAsync(
            double? page = default,
            double? limit = default,
            global::System.Collections.Generic.IList<double>? statusCodes = default,
            string? urlPattern = default,
            string? transactionId = default,
            double? createdGte = default,
            global::Novu.ActivityControllerGetLogsSource? source = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List activity requests<br/>
        /// Retrieve a list of activity requests with optional filtering and pagination.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="statusCodes">
        /// Example: [200, 404, 500]
        /// </param>
        /// <param name="urlPattern"></param>
        /// <param name="transactionId"></param>
        /// <param name="createdGte">
        /// Example: 1640995200
        /// </param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.GetRequestsResponseDto>> ListAsResponseAsync(
            double? page = default,
            double? limit = default,
            global::System.Collections.Generic.IList<double>? statusCodes = default,
            string? urlPattern = default,
            string? transactionId = default,
            double? createdGte = default,
            global::Novu.ActivityControllerGetLogsSource? source = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}