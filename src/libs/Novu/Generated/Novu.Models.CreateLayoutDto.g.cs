
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLayoutDto
    {
        /// <summary>
        /// Unique identifier for the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layoutId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutId { get; set; }

        /// <summary>
        /// Name of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Enable or disable translations for this layout<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        public bool? IsTranslationEnabled { get; set; }

        /// <summary>
        /// Source of layout creation<br/>
        /// Default Value: dashboard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter))]
        public global::Novu.LayoutCreationSourceEnum? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLayoutDto" /> class.
        /// </summary>
        /// <param name="layoutId">
        /// Unique identifier for the layout
        /// </param>
        /// <param name="name">
        /// Name of the layout
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this layout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="source">
        /// Source of layout creation<br/>
        /// Default Value: dashboard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLayoutDto(
            string layoutId,
            string name,
            bool? isTranslationEnabled,
            global::Novu.LayoutCreationSourceEnum? source)
        {
            this.LayoutId = layoutId ?? throw new global::System.ArgumentNullException(nameof(layoutId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsTranslationEnabled = isTranslationEnabled;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLayoutDto" /> class.
        /// </summary>
        public CreateLayoutDto()
        {
        }
    }
}