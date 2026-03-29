
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationRequestDto
    {
        /// <summary>
        /// The resource ID to associate translation with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </summary>
        /// <example>welcome-email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// The resource type to associate translation with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.CreateTranslationRequestDtoResourceType ResourceType { get; set; }

        /// <summary>
        /// Locale code (e.g., en_US, es_ES)<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationRequestDto" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// The resource ID to associate translation with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// The resource type to associate translation with
        /// </param>
        /// <param name="locale">
        /// Locale code (e.g., en_US, es_ES)<br/>
        /// Example: en_US
        /// </param>
        /// <param name="content">
        /// Translation content as JSON object<br/>
        /// Example: {"welcome.title":"Welcome","welcome.message":"Hello there!"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslationRequestDto(
            string resourceId,
            global::Novu.CreateTranslationRequestDtoResourceType resourceType,
            string locale,
            object content)
        {
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceType = resourceType;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationRequestDto" /> class.
        /// </summary>
        public CreateTranslationRequestDto()
        {
        }
    }
}