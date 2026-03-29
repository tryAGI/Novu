
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLayoutDto
    {
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
        /// Control values for the layout. Omit to leave unchanged, or set to null to clear stored control values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlValues")]
        public global::Novu.LayoutControlValuesDto? ControlValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLayoutDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the layout
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this layout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="controlValues">
        /// Control values for the layout. Omit to leave unchanged, or set to null to clear stored control values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLayoutDto(
            string name,
            bool? isTranslationEnabled,
            global::Novu.LayoutControlValuesDto? controlValues)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsTranslationEnabled = isTranslationEnabled;
            this.ControlValues = controlValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLayoutDto" /> class.
        /// </summary>
        public UpdateLayoutDto()
        {
        }
    }
}