
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConstraintValidation
    {
        /// <summary>
        /// List of validation error messages<br/>
        /// Example: [Field is required, Invalid format]
        /// </summary>
        /// <example>[Field is required, Invalid format]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Messages { get; set; }

        /// <summary>
        /// Value that failed validation<br/>
        /// Example: xx xx xx 
        /// </summary>
        /// <example>xx xx xx </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>))]
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintValidation" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of validation error messages<br/>
        /// Example: [Field is required, Invalid format]
        /// </param>
        /// <param name="value">
        /// Value that failed validation<br/>
        /// Example: xx xx xx 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConstraintValidation(
            global::System.Collections.Generic.IList<string> messages,
            global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? value)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintValidation" /> class.
        /// </summary>
        public ConstraintValidation()
        {
        }
    }
}