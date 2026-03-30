
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InboxSubscriberResponseDto
    {
        /// <summary>
        /// Unique identifier of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// First name of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Avatar URL of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// External subscriber identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxSubscriberResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the subscriber
        /// </param>
        /// <param name="subscriberId">
        /// External subscriber identifier
        /// </param>
        /// <param name="firstName">
        /// First name of the subscriber
        /// </param>
        /// <param name="lastName">
        /// Last name of the subscriber
        /// </param>
        /// <param name="avatar">
        /// Avatar URL of the subscriber
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxSubscriberResponseDto(
            string id,
            string subscriberId,
            string? firstName,
            string? lastName,
            string? avatar)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Avatar = avatar;
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxSubscriberResponseDto" /> class.
        /// </summary>
        public InboxSubscriberResponseDto()
        {
        }
    }
}