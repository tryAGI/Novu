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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpsertTopicResponse> TopicsControllerUpsertTopicAsync(

            global::Novu.CreateUpdateTopicRequestDto request,
            bool? failIfExists = default,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpsertTopicResponse> TopicsControllerUpsertTopicAsync(
            string key,
            bool? failIfExists = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}