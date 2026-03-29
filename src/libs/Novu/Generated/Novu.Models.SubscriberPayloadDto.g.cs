
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberPayloadDto
    {
        /// <summary>
        /// First name of the subscriber<br/>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the subscriber<br/>
        /// Example: Doe
        /// </summary>
        /// <example>Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the subscriber<br/>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the subscriber<br/>
        /// Example: +1234567890
        /// </summary>
        /// <example>+1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Avatar URL or identifier<br/>
        /// Example: https://example.com/avatar.jpg
        /// </summary>
        /// <example>https://example.com/avatar.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Locale of the subscriber<br/>
        /// Example: en-US
        /// </summary>
        /// <example>en-US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Timezone of the subscriber<br/>
        /// Example: America/New_York
        /// </summary>
        /// <example>America/New_York</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional custom data associated with the subscriber
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The internal identifier you used to create this subscriber, usually correlates to the id the user in your systems
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// An optional array of subscriber channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Novu.SubscriberChannelDto>? Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberPayloadDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// The internal identifier you used to create this subscriber, usually correlates to the id the user in your systems
        /// </param>
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
        /// <param name="channels">
        /// An optional array of subscriber channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberPayloadDto(
            string subscriberId,
            string? firstName,
            string? lastName,
            string? email,
            string? phone,
            string? avatar,
            string? locale,
            string? timezone,
            object? data,
            global::System.Collections.Generic.IList<global::Novu.SubscriberChannelDto>? channels)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Avatar = avatar;
            this.Locale = locale;
            this.Timezone = timezone;
            this.Data = data;
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberPayloadDto" /> class.
        /// </summary>
        public SubscriberPayloadDto()
        {
        }
    }
}