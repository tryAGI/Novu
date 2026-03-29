
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberDto
    {
        /// <summary>
        /// The identifier of the subscriber<br/>
        /// Example: 64da692e9a94fb2e6449ad07
        /// </summary>
        /// <example>64da692e9a94fb2e6449ad07</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The external identifier of the subscriber<br/>
        /// Example: user-123
        /// </summary>
        /// <example>user-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// The avatar URL of the subscriber<br/>
        /// Example: https://example.com/avatar.png
        /// </summary>
        /// <example>https://example.com/avatar.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The first name of the subscriber<br/>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the subscriber<br/>
        /// Example: Doe
        /// </summary>
        /// <example>Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// The email of the subscriber<br/>
        /// Example: john@example.com
        /// </summary>
        /// <example>john@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the subscriber<br/>
        /// Example: 64da692e9a94fb2e6449ad07
        /// </param>
        /// <param name="subscriberId">
        /// The external identifier of the subscriber<br/>
        /// Example: user-123
        /// </param>
        /// <param name="avatar">
        /// The avatar URL of the subscriber<br/>
        /// Example: https://example.com/avatar.png
        /// </param>
        /// <param name="firstName">
        /// The first name of the subscriber<br/>
        /// Example: John
        /// </param>
        /// <param name="lastName">
        /// The last name of the subscriber<br/>
        /// Example: Doe
        /// </param>
        /// <param name="email">
        /// The email of the subscriber<br/>
        /// Example: john@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberDto(
            string id,
            string subscriberId,
            string? avatar,
            string? firstName,
            string? lastName,
            string? email)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Avatar = avatar;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberDto" /> class.
        /// </summary>
        public SubscriberDto()
        {
        }
    }
}