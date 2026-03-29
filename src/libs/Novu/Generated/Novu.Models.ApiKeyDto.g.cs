
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyDto
    {
        /// <summary>
        /// API key<br/>
        /// Example: sk_test_1234567890abcdef
        /// </summary>
        /// <example>sk_test_1234567890abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// User ID associated with the API key<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a4
        /// </summary>
        /// <example>60d5ecb8b3b3a30015f3e1a4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Hashed representation of the API key<br/>
        /// Example: hash_value_here
        /// </summary>
        /// <example>hash_value_here</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyDto" /> class.
        /// </summary>
        /// <param name="key">
        /// API key<br/>
        /// Example: sk_test_1234567890abcdef
        /// </param>
        /// <param name="userId">
        /// User ID associated with the API key<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a4
        /// </param>
        /// <param name="hash">
        /// Hashed representation of the API key<br/>
        /// Example: hash_value_here
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyDto(
            string key,
            string userId,
            string? hash)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Hash = hash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyDto" /> class.
        /// </summary>
        public ApiKeyDto()
        {
        }
    }
}