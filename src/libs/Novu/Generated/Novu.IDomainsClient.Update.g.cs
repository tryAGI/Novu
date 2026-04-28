#nullable enable

namespace Novu
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Update a domain<br/>
        /// Updates optional domain fields. When `data` is provided, it replaces the entire metadata object; omit `data` to leave it unchanged.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerUpdateDomainResponse> UpdateAsync(
            string domain,

            global::Novu.UpdateDomainDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a domain<br/>
        /// Updates optional domain fields. When `data` is provided, it replaces the entire metadata object; omit `data` to leave it unchanged.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerUpdateDomainResponse>> UpdateAsResponseAsync(
            string domain,

            global::Novu.UpdateDomainDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a domain<br/>
        /// Updates optional domain fields. When `data` is provided, it replaces the entire metadata object; omit `data` to leave it unchanged.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="data">
        /// Replaces domain metadata when provided (max 10 keys, 500 characters total for keys+values).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerUpdateDomainResponse> UpdateAsync(
            string domain,
            global::System.Collections.Generic.Dictionary<string, string>? data = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}