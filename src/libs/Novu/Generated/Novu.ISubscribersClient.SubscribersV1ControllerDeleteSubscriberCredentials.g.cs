#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Delete provider credentials<br/>
        /// Delete subscriber credentials for a provider such as **slack** and **FCM** by **providerId**. <br/>
        ///     This action is irreversible and will remove the credentials for the provider for particular **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="providerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task SubscribersV1ControllerDeleteSubscriberCredentialsAsync(
            string subscriberId,
            string providerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}