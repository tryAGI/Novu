
#nullable enable

namespace Novu
{
    /// <summary>
    /// A record of validation errors keyed by field name<br/>
    /// Example: {"fieldName1":{"messages":["Field is required","Must be a valid email address"],"value":"invalidEmail"},"fieldName2":{"messages":["Must be at least 18 years old"],"value":17},"fieldName3":{"messages":["Must be a boolean value"],"value":true},"fieldName4":{"messages":["Must be a valid object"],"value":{"key":"value"}},"fieldName5":{"messages":["Field is missing"],"value":null},"fieldName6":{"messages":["Undefined value"]}}
    /// </summary>
    public sealed partial class ValidationErrorDtoErrors
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}