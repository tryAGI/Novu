
#nullable enable

namespace Novu
{
    /// <summary>
    /// The JSON schema that was used for validation<br/>
    /// Example: {"type":"object","properties":{"name":{"type":"string"},"age":{"type":"number"}},"required":["name"]}
    /// </summary>
    public sealed partial class PayloadValidationExceptionDtoSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}