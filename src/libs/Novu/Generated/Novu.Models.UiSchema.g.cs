
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UiSchema
    {
        /// <summary>
        /// Group of the UI Schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter))]
        public global::Novu.UiSchemaGroupEnum? Group { get; set; }

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
        /// Initializes a new instance of the <see cref="UiSchema" /> class.
        /// </summary>
        /// <param name="group">
        /// Group of the UI Schema
        /// </param>
        /// <param name="properties">
        /// Properties of the UI Schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UiSchema(
            global::Novu.UiSchemaGroupEnum? group,
            global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? properties)
        {
            this.Group = group;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiSchema" /> class.
        /// </summary>
        public UiSchema()
        {
        }
    }
}