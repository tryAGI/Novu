#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Create a topic<br/>
        /// Creates a new topic if it does not exist, or updates an existing topic if it already exists. Use ?failIfExists=true to prevent updates.
        /// </summary>
        /// <param name="failIfExists"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpsertTopicResponse> CreateAsync(

            global::Novu.CreateUpdateTopicRequestDto request,
            bool? failIfExists = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a topic<br/>
        /// Creates a new topic if it does not exist, or updates an existing topic if it already exists. Use ?failIfExists=true to prevent updates.
        /// </summary>
        /// <param name="failIfExists"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerUpsertTopicResponse>> CreateAsResponseAsync(

            global::Novu.CreateUpdateTopicRequestDto request,
            bool? failIfExists = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a topic<br/>
        /// Creates a new topic if it does not exist, or updates an existing topic if it already exists. Use ?failIfExists=true to prevent updates.
        /// </summary>
        /// <param name="failIfExists"></param>
        /// <param name="key">
        /// The unique key identifier for the topic. The key must contain only alphanumeric characters (a-z, A-Z, 0-9), hyphens (-), underscores (_), colons (:), or be a valid email address.<br/>
        /// Example: task:12345
        /// </param>
        /// <param name="name">
        /// The display name for the topic<br/>
        /// Example: Task Title
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpsertTopicResponse> CreateAsync(
            string key,
            bool? failIfExists = default,
            string? name = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}