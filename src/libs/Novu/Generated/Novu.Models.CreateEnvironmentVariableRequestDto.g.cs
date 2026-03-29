
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEnvironmentVariableRequestDto
    {
        /// <summary>
        /// Unique key for the variable. Must start with a letter and contain only letters, digits, and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The type of the variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter))]
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type { get; set; }

        /// <summary>
        /// Whether this variable is a secret (encrypted at rest, masked in responses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSecret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentVariableRequestDto" /> class.
        /// </summary>
        /// <param name="key">
        /// Unique key for the variable. Must start with a letter and contain only letters, digits, and underscores.
        /// </param>
        /// <param name="type">
        /// The type of the variable
        /// </param>
        /// <param name="isSecret">
        /// Whether this variable is a secret (encrypted at rest, masked in responses)
        /// </param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentVariableRequestDto(
            string key,
            global::Novu.CreateEnvironmentVariableRequestDtoType? type,
            bool? isSecret,
            global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? values)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.IsSecret = isSecret;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentVariableRequestDto" /> class.
        /// </summary>
        public CreateEnvironmentVariableRequestDto()
        {
        }
    }
}