
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayloadValidationErrorDto
    {
        /// <summary>
        /// Field path that failed validation<br/>
        /// Example: user.name
        /// </summary>
        /// <example>user.name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Validation error message<br/>
        /// Example: must have required property 'name'
        /// </summary>
        /// <example>must have required property 'name'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The actual value that failed validation<br/>
        /// Example: {"age":25}
        /// </summary>
        /// <example>{"age":25}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>))]
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Value { get; set; }

        /// <summary>
        /// JSON Schema path where the validation failed<br/>
        /// Example: #/required
        /// </summary>
        /// <example>#/required</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaPath")]
        public string? SchemaPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadValidationErrorDto" /> class.
        /// </summary>
        /// <param name="field">
        /// Field path that failed validation<br/>
        /// Example: user.name
        /// </param>
        /// <param name="message">
        /// Validation error message<br/>
        /// Example: must have required property 'name'
        /// </param>
        /// <param name="value">
        /// The actual value that failed validation<br/>
        /// Example: {"age":25}
        /// </param>
        /// <param name="schemaPath">
        /// JSON Schema path where the validation failed<br/>
        /// Example: #/required
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayloadValidationErrorDto(
            string field,
            string message,
            global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? value,
            string? schemaPath)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Value = value;
            this.SchemaPath = schemaPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadValidationErrorDto" /> class.
        /// </summary>
        public PayloadValidationErrorDto()
        {
        }
    }
}