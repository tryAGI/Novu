
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspaceDto
    {
        /// <summary>
        /// Example: T123456
        /// </summary>
        /// <example>T123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: Acme HQ
        /// </summary>
        /// <example>Acme HQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: U0123456789
        /// </summary>
        /// <example>U0123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("botUserId")]
        public string? BotUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: T123456
        /// </param>
        /// <param name="name">
        /// Example: Acme HQ
        /// </param>
        /// <param name="botUserId">
        /// Example: U0123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceDto(
            string id,
            string? name,
            string? botUserId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.BotUserId = botUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceDto" /> class.
        /// </summary>
        public WorkspaceDto()
        {
        }

    }
}