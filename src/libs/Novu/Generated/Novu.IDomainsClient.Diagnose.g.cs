#nullable enable

namespace Novu
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Diagnose inbound DNS for a domain<br/>
        /// Runs live DNS checks for inbound email readiness (MX correctness, apex CNAME collision, and common DNS blocklists for the Novu mail host). Returns structured issues with plain-language fixes.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerDiagnoseDomainResponse> DiagnoseAsync(
            string domain,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Diagnose inbound DNS for a domain<br/>
        /// Runs live DNS checks for inbound email readiness (MX correctness, apex CNAME collision, and common DNS blocklists for the Novu mail host). Returns structured issues with plain-language fixes.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerDiagnoseDomainResponse>> DiagnoseAsResponseAsync(
            string domain,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}