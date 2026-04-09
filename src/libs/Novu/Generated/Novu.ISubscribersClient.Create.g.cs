#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Create a subscriber<br/>
        /// Create a subscriber with the subscriber attributes. <br/>
        ///       **subscriberId** is a required field, rest other fields are optional, if the subscriber already exists, it will be updated
        /// </summary>
        /// <param name="failIfExists"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerCreateSubscriberResponse> CreateAsync(

            global::Novu.CreateSubscriberRequestDto request,
            bool? failIfExists = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a subscriber<br/>
        /// Create a subscriber with the subscriber attributes. <br/>
        ///       **subscriberId** is a required field, rest other fields are optional, if the subscriber already exists, it will be updated
        /// </summary>
        /// <param name="failIfExists"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerCreateSubscriberResponse>> CreateAsResponseAsync(

            global::Novu.CreateSubscriberRequestDto request,
            bool? failIfExists = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a subscriber<br/>
        /// Create a subscriber with the subscriber attributes. <br/>
        ///       **subscriberId** is a required field, rest other fields are optional, if the subscriber already exists, it will be updated
        /// </summary>
        /// <param name="failIfExists"></param>
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
        /// <param name="subscriberId">
        /// Unique identifier of the subscriber
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerCreateSubscriberResponse> CreateAsync(
            string subscriberId,
            bool? failIfExists = default,
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