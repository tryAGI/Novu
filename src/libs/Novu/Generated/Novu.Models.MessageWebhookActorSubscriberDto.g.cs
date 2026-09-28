
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageWebhookActorSubscriberDto
    {
        /// <summary>
        /// Database identifier of the actor subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// External subscriber identifier of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// First name of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Avatar URL of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Locale of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Custom actor subscriber data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookActorSubscriberDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Database identifier of the actor subscriber
        /// </param>
        /// <param name="subscriberId">
        /// External subscriber identifier of the actor
        /// </param>
        /// <param name="firstName">
        /// First name of the actor
        /// </param>
        /// <param name="lastName">
        /// Last name of the actor
        /// </param>
        /// <param name="email">
        /// Email of the actor
        /// </param>
        /// <param name="phone">
        /// Phone number of the actor
        /// </param>
        /// <param name="avatar">
        /// Avatar URL of the actor
        /// </param>
        /// <param name="locale">
        /// Locale of the actor
        /// </param>
        /// <param name="data">
        /// Custom actor subscriber data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageWebhookActorSubscriberDto(
            string id,
            string subscriberId,
            string? firstName,
            string? lastName,
            string? email,
            string? phone,
            string? avatar,
            string? locale,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Avatar = avatar;
            this.Locale = locale;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookActorSubscriberDto" /> class.
        /// </summary>
        public MessageWebhookActorSubscriberDto()
        {
        }

    }
}