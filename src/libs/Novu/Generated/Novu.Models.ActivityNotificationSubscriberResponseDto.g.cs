
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityNotificationSubscriberResponseDto
    {
        /// <summary>
        /// First name of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// External unique identifier of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Internal to Novu unique identifier of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Last name of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationSubscriberResponseDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// External unique identifier of the subscriber
        /// </param>
        /// <param name="id">
        /// Internal to Novu unique identifier of the subscriber
        /// </param>
        /// <param name="firstName">
        /// First name of the subscriber
        /// </param>
        /// <param name="lastName">
        /// Last name of the subscriber
        /// </param>
        /// <param name="email">
        /// Email address of the subscriber
        /// </param>
        /// <param name="phone">
        /// Phone number of the subscriber
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityNotificationSubscriberResponseDto(
            string subscriberId,
            string id,
            string? firstName,
            string? lastName,
            string? email,
            string? phone)
        {
            this.FirstName = firstName;
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationSubscriberResponseDto" /> class.
        /// </summary>
        public ActivityNotificationSubscriberResponseDto()
        {
        }
    }
}