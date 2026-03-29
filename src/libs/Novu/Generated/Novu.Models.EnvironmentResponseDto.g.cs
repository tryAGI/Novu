
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentResponseDto
    {
        /// <summary>
        /// Unique identifier of the environment<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a1
        /// </summary>
        /// <example>60d5ecb8b3b3a30015f3e1a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the environment<br/>
        /// Example: Production Environment
        /// </summary>
        /// <example>Production Environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Organization ID associated with the environment<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a2
        /// </summary>
        /// <example>60d5ecb8b3b3a30015f3e1a2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Unique identifier for the environment<br/>
        /// Example: prod-env-01
        /// </summary>
        /// <example>prod-env-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Type of the environment<br/>
        /// Example: prod
        /// </summary>
        /// <example>prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter))]
        public global::Novu.EnvironmentResponseDtoType? Type { get; set; }

        /// <summary>
        /// List of API keys associated with the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeys")]
        public global::System.Collections.Generic.IList<global::Novu.ApiKeyDto>? ApiKeys { get; set; }

        /// <summary>
        /// Parent environment ID<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a3
        /// </summary>
        /// <example>60d5ecb8b3b3a30015f3e1a3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// URL-friendly slug for the environment<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the environment<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a1
        /// </param>
        /// <param name="name">
        /// Name of the environment<br/>
        /// Example: Production Environment
        /// </param>
        /// <param name="organizationId">
        /// Organization ID associated with the environment<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a2
        /// </param>
        /// <param name="identifier">
        /// Unique identifier for the environment<br/>
        /// Example: prod-env-01
        /// </param>
        /// <param name="type">
        /// Type of the environment<br/>
        /// Example: prod
        /// </param>
        /// <param name="apiKeys">
        /// List of API keys associated with the environment
        /// </param>
        /// <param name="parentId">
        /// Parent environment ID<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a3
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug for the environment<br/>
        /// Example: production
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentResponseDto(
            string id,
            string name,
            string organizationId,
            string identifier,
            global::Novu.EnvironmentResponseDtoType? type,
            global::System.Collections.Generic.IList<global::Novu.ApiKeyDto>? apiKeys,
            string? parentId,
            string? slug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Type = type;
            this.ApiKeys = apiKeys;
            this.ParentId = parentId;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResponseDto" /> class.
        /// </summary>
        public EnvironmentResponseDto()
        {
        }
    }
}