
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationResponseDto
    {
        /// <summary>
        /// Resource identifier<br/>
        /// Example: welcome-email
        /// </summary>
        /// <example>welcome-email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Resource type<br/>
        /// Example: workflow
        /// </summary>
        /// <example>workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TranslationResponseDtoResourceType ResourceType { get; set; }

        /// <summary>
        /// Locale code<br/>
        /// Example: en_US
        /// </summary>
        /// <example>en_US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Translation content as JSON object<br/>
        /// Example: {"welcome.title":"Welcome","welcome.message":"Hello there!"}
        /// </summary>
        /// <example>{"welcome.title":"Welcome","welcome.message":"Hello there!"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// Creation timestamp<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponseDto" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// Resource identifier<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// Resource type<br/>
        /// Example: workflow
        /// </param>
        /// <param name="locale">
        /// Locale code<br/>
        /// Example: en_US
        /// </param>
        /// <param name="content">
        /// Translation content as JSON object<br/>
        /// Example: {"welcome.title":"Welcome","welcome.message":"Hello there!"}
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationResponseDto(
            string resourceId,
            global::Novu.TranslationResponseDtoResourceType resourceType,
            string locale,
            object content,
            string createdAt,
            string updatedAt)
        {
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceType = resourceType;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponseDto" /> class.
        /// </summary>
        public TranslationResponseDto()
        {
        }
    }
}