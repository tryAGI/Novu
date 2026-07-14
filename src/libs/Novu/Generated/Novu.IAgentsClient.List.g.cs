#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List all agents<br/>
        /// Retrieve a cursor-paginated list of agents for the current environment. Use **after**, **before**, **limit**, **orderBy**, and **orderDirection** query parameters.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerListAgentsResponse> ListAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.AgentsControllerListAgentsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? identifier = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all agents<br/>
        /// Retrieve a cursor-paginated list of agents for the current environment. Use **after**, **before**, **limit**, **orderBy**, and **orderDirection** query parameters.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentsControllerListAgentsResponse>> ListAsResponseAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.AgentsControllerListAgentsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? identifier = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}