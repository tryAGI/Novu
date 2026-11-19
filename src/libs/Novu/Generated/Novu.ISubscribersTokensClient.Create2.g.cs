#nullable enable

namespace Novu
{
    public partial interface ISubscribersTokensClient
    {
        /// <summary>
        /// Create a subscriber login token<br/>
        /// Create a short-lived, Novu-signed login token for the subscriber identified by **subscriberId**.<br/>
        ///     Call it from your backend with your secret key, then pass the token to the browser, which exchanges it for an Inbox session.<br/>
        ///     Creating a token does not read or change the subscriber, so the subscriber does not need to exist yet.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerCreateSubscriberTokenResponse> Create2Async(
            string subscriberId,

            global::Novu.CreateSubscriberTokenRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a subscriber login token<br/>
        /// Create a short-lived, Novu-signed login token for the subscriber identified by **subscriberId**.<br/>
        ///     Call it from your backend with your secret key, then pass the token to the browser, which exchanges it for an Inbox session.<br/>
        ///     Creating a token does not read or change the subscriber, so the subscriber does not need to exist yet.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerCreateSubscriberTokenResponse>> Create2AsResponseAsync(
            string subscriberId,

            global::Novu.CreateSubscriberTokenRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a subscriber login token<br/>
        /// Create a short-lived, Novu-signed login token for the subscriber identified by **subscriberId**.<br/>
        ///     Call it from your backend with your secret key, then pass the token to the browser, which exchanges it for an Inbox session.<br/>
        ///     Creating a token does not read or change the subscriber, so the subscriber does not need to exist yet.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="context"></param>
        /// <param name="subscriber">
        /// Profile fields saved on the subscriber when the token is exchanged for an Inbox session. The subscriberId comes from the path.
        /// </param>
        /// <param name="scope">
        /// Extra permissions granted to the session the token is exchanged for. Defaults to none.<br/>
        /// Example: [channels:shared]
        /// </param>
        /// <param name="expiresIn">
        /// Token lifetime in seconds, from 1 to 3600.<br/>
        /// Default Value: 3600<br/>
        /// Example: 600
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerCreateSubscriberTokenResponse> Create2Async(
            string subscriberId,
            object? context = default,
            global::Novu.BaseSubscriberFieldsDto? subscriber = default,
            global::System.Collections.Generic.IList<global::Novu.SubscriberTokenScopeEnum>? scope = default,
            int? expiresIn = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}