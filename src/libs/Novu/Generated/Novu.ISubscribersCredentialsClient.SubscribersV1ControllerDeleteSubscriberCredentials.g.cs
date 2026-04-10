#nullable enable

namespace Novu
{
    public partial interface ISubscribersCredentialsClient
    {
        /// <summary>
        /// Delete provider credentials<br/>
        /// Delete subscriber credentials for a provider such as **slack** and **FCM** by **providerId**. <br/>
        ///     This action is irreversible and will remove the credentials for the provider for particular **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="providerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task SubscribersV1ControllerDeleteSubscriberCredentialsAsync(
            string subscriberId,
            string providerId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}