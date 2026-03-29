
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UiSchemaProperty
    {
        /// <summary>
        /// Placeholder for the UI Schema Property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>))]
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Placeholder { get; set; }

        /// <summary>
        /// Component type for the UI Schema Property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.UiComponentEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.UiComponentEnum Component { get; set; }

        /// <summary>
        /// Properties of the UI Schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UiSchemaProperty" /> class.
        /// </summary>
        /// <param name="component">
        /// Component type for the UI Schema Property
        /// </param>
        /// <param name="placeholder">
        /// Placeholder for the UI Schema Property
        /// </param>
        /// <param name="properties">
        /// Properties of the UI Schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UiSchemaProperty(
            global::Novu.UiComponentEnum component,
            global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? placeholder,
            global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? properties)
        {
            this.Placeholder = placeholder;
            this.Component = component;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiSchemaProperty" /> class.
        /// </summary>
        public UiSchemaProperty()
        {
        }
    }
}