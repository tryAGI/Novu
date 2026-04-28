
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDomainDto
    {
        /// <summary>
        /// The domain name (e.g. "recent.dev")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional string key-value metadata (max 10 keys, 500 characters total for keys+values).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, string>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainDto" /> class.
        /// </summary>
        /// <param name="name">
        /// The domain name (e.g. "recent.dev")
        /// </param>
        /// <param name="data">
        /// Optional string key-value metadata (max 10 keys, 500 characters total for keys+values).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDomainDto(
            string name,
            global::System.Collections.Generic.Dictionary<string, string>? data)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainDto" /> class.
        /// </summary>
        public CreateDomainDto()
        {
        }
    }
}