
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationGroupDto
    {
        /// <summary>
        /// Resource identifier (slugified ID)<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TranslationGroupDtoResourceType ResourceType { get; set; }

        /// <summary>
        /// Resource name (e.g., workflow name)<br/>
        /// Example: Welcome Email Workflow
        /// </summary>
        /// <example>Welcome Email Workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceName { get; set; }

        /// <summary>
        /// Array of available locales for this resource<br/>
        /// Example: [en_US, es_ES, fr_FR]
        /// </summary>
        /// <example>[en_US, es_ES, fr_FR]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locales")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Locales { get; set; }

        /// <summary>
        /// Locales that are outdated compared to the default locale (only present when there are outdated locales)<br/>
        /// Example: [es_ES, fr_FR]
        /// </summary>
        /// <example>[es_ES, fr_FR]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outdatedLocales")]
        public global::System.Collections.Generic.IList<string>? OutdatedLocales { get; set; }

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
        /// Initializes a new instance of the <see cref="TranslationGroupDto" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// Resource identifier (slugified ID)<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// Resource type<br/>
        /// Example: workflow
        /// </param>
        /// <param name="resourceName">
        /// Resource name (e.g., workflow name)<br/>
        /// Example: Welcome Email Workflow
        /// </param>
        /// <param name="locales">
        /// Array of available locales for this resource<br/>
        /// Example: [en_US, es_ES, fr_FR]
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="outdatedLocales">
        /// Locales that are outdated compared to the default locale (only present when there are outdated locales)<br/>
        /// Example: [es_ES, fr_FR]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationGroupDto(
            string resourceId,
            global::Novu.TranslationGroupDtoResourceType resourceType,
            string resourceName,
            global::System.Collections.Generic.IList<string> locales,
            string createdAt,
            string updatedAt,
            global::System.Collections.Generic.IList<string>? outdatedLocales)
        {
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceType = resourceType;
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
            this.Locales = locales ?? throw new global::System.ArgumentNullException(nameof(locales));
            this.OutdatedLocales = outdatedLocales;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationGroupDto" /> class.
        /// </summary>
        public TranslationGroupDto()
        {
        }
    }
}