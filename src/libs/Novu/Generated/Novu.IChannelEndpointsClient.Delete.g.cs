#nullable enable

namespace Novu
{
    public partial interface IChannelEndpointsClient
    {
        /// <summary>
        /// Delete a channel endpoint<br/>
        /// Delete a specific channel endpoint by its unique identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string identifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}