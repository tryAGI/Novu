
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutResponseDto
    {
        /// <summary>
        /// Unique internal identifier of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier for the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layoutId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutId { get; set; }

        /// <summary>
        /// Slug of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Name of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the layout is the default layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Whether the layout translations are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTranslationEnabled { get; set; }

        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// User who last updated the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public global::Novu.UserResponseDto? UpdatedBy { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Origin of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceOriginEnum Origin { get; set; }

        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum Type { get; set; }

        /// <summary>
        /// The variables JSON Schema for the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Controls metadata for the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.LayoutControlsDto Controls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique internal identifier of the layout
        /// </param>
        /// <param name="layoutId">
        /// Unique identifier for the layout
        /// </param>
        /// <param name="slug">
        /// Slug of the layout
        /// </param>
        /// <param name="name">
        /// Name of the layout
        /// </param>
        /// <param name="isDefault">
        /// Whether the layout is the default layout
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Whether the layout translations are enabled
        /// </param>
        /// <param name="updatedAt">
        /// Last updated timestamp
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
        /// <param name="type">
        /// Type of the layout
        /// </param>
        /// <param name="controls">
        /// Controls metadata for the layout
        /// </param>
        /// <param name="updatedBy">
        /// User who last updated the layout
        /// </param>
        /// <param name="variables">
        /// The variables JSON Schema for the layout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutResponseDto(
            string id,
            string layoutId,
            string slug,
            string name,
            bool isDefault,
            bool isTranslationEnabled,
            string updatedAt,
            string createdAt,
            global::Novu.ResourceOriginEnum origin,
            global::Novu.ResourceTypeEnum type,
            global::Novu.LayoutControlsDto controls,
            global::Novu.UserResponseDto? updatedBy,
            object? variables)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LayoutId = layoutId ?? throw new global::System.ArgumentNullException(nameof(layoutId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsDefault = isDefault;
            this.IsTranslationEnabled = isTranslationEnabled;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.UpdatedBy = updatedBy;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Origin = origin;
            this.Type = type;
            this.Variables = variables;
            this.Controls = controls ?? throw new global::System.ArgumentNullException(nameof(controls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutResponseDto" /> class.
        /// </summary>
        public LayoutResponseDto()
        {
        }
    }
}