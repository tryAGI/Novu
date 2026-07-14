#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete an agent<br/>
        /// Delete an agent by identifier and remove all agent-integration links. For managed-runtime agents, pass `deleteFromProvider=true` to also archive the agent on the provider side (e.g. Anthropic). By default only the Novu record is deleted and the provider agent is left intact.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="deleteFromProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string identifier,
            string deleteFromProvider,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent<br/>
        /// Delete an agent by identifier and remove all agent-integration links. For managed-runtime agents, pass `deleteFromProvider=true` to also archive the agent on the provider side (e.g. Anthropic). By default only the Novu record is deleted and the provider agent is left intact.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="deleteFromProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string identifier,
            string deleteFromProvider,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}