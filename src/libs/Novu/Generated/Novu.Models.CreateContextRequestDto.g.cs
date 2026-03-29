
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContextRequestDto
    {
        /// <summary>
        /// Context type (e.g., tenant, app, workspace). Must be lowercase alphanumeric with optional separators.<br/>
        /// Example: tenant
        /// </summary>
        /// <example>tenant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Unique identifier for this context. Must be lowercase alphanumeric with optional separators.<br/>
        /// Example: org-acme
        /// </summary>
        /// <example>org-acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional custom data to associate with this context.<br/>
        /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
        /// </summary>
        /// <example>{"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContextRequestDto" /> class.
        /// </summary>
        /// <param name="type">
        /// Context type (e.g., tenant, app, workspace). Must be lowercase alphanumeric with optional separators.<br/>
        /// Example: tenant
        /// </param>
        /// <param name="id">
        /// Unique identifier for this context. Must be lowercase alphanumeric with optional separators.<br/>
        /// Example: org-acme
        /// </param>
        /// <param name="data">
        /// Optional custom data to associate with this context.<br/>
        /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContextRequestDto(
            string type,
            string id,
            object? data)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContextRequestDto" /> class.
        /// </summary>
        public CreateContextRequestDto()
        {
        }
    }
}