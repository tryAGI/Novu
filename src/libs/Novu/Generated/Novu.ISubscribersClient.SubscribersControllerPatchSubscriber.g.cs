#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Update a subscriber<br/>
        /// Update a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     **subscriberId** is a required field, rest other fields are optional
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerPatchSubscriberResponse> SubscribersControllerPatchSubscriberAsync(
            string subscriberId,

            global::Novu.PatchSubscriberRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a subscriber<br/>
        /// Update a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     **subscriberId** is a required field, rest other fields are optional
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerPatchSubscriberResponse>> SubscribersControllerPatchSubscriberAsResponseAsync(
            string subscriberId,

            global::Novu.PatchSubscriberRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a subscriber<br/>
        /// Update a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     **subscriberId** is a required field, rest other fields are optional
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="firstName">
        /// First name of the subscriber<br/>
        /// Example: John
        /// </param>
        /// <param name="lastName">
        /// Last name of the subscriber<br/>
        /// Example: Doe
        /// </param>
        /// <param name="email">
        /// Email address of the subscriber<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="phone">
        /// Phone number of the subscriber<br/>
        /// Example: +1234567890
        /// </param>
        /// <param name="avatar">
        /// Avatar URL or identifier<br/>
        /// Example: https://example.com/avatar.jpg
        /// </param>
        /// <param name="locale">
        /// Locale of the subscriber<br/>
        /// Example: en-US
        /// </param>
        /// <param name="timezone">
        /// Timezone of the subscriber<br/>
        /// Example: America/New_York
        /// </param>
        /// <param name="data">
        /// Additional custom data associated with the subscriber
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerPatchSubscriberResponse> SubscribersControllerPatchSubscriberAsync(
            string subscriberId,
            string? firstName = default,
            string? lastName = default,
            string? email = default,
            string? phone = default,
            string? avatar = default,
            string? locale = default,
            string? timezone = default,
            object? data = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}