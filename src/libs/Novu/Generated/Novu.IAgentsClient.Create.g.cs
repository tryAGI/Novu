#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent<br/>
        /// Create an agent scoped to the current environment. The identifier must be unique per environment. Set `runtime` to `managed` and supply `managedRuntime` to provision a provider-hosted agent brain.
        /// </summary>
        /// <param name="novuAnalyticsSource"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerCreateAgentResponse> CreateAsync(
            string novuAnalyticsSource,

            global::Novu.CreateAgentRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Create an agent scoped to the current environment. The identifier must be unique per environment. Set `runtime` to `managed` and supply `managedRuntime` to provision a provider-hosted agent brain.
        /// </summary>
        /// <param name="novuAnalyticsSource"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentsControllerCreateAgentResponse>> CreateAsResponseAsync(
            string novuAnalyticsSource,

            global::Novu.CreateAgentRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Create an agent scoped to the current environment. The identifier must be unique per environment. Set `runtime` to `managed` and supply `managedRuntime` to provision a provider-hosted agent brain.
        /// </summary>
        /// <param name="novuAnalyticsSource"></param>
        /// <param name="name">
        /// Required when not adopting an existing managed agent (i.e. when managedRuntime.externalAgentId is absent). Optional in adopt mode where the name is resolved from the provider.
        /// </param>
        /// <param name="identifier">
        /// Required when not adopting an existing managed agent. Auto-generated from the provider agent name when omitted in adopt mode.
        /// </param>
        /// <param name="description"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="runtime"></param>
        /// <param name="managedRuntime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerCreateAgentResponse> CreateAsync(
            string novuAnalyticsSource,
            string name,
            string identifier,
            string? description = default,
            bool? active = default,
            global::Novu.CreateAgentRequestDtoRuntime? runtime = default,
            global::Novu.ManagedRuntimeDto? managedRuntime = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}