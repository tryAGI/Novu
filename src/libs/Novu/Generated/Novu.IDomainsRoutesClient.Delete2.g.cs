#nullable enable

namespace Novu
{
    public partial interface IDomainsRoutesClient
    {
        /// <summary>
        /// Delete a route<br/>
        /// Removes the route bound to `&lt;address&gt;@&lt;domain&gt;`. Inbound mail for that address will no longer be processed.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            string domain,
            string address,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}