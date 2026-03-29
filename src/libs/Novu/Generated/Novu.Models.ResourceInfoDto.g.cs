
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceInfoDto
    {
        /// <summary>
        /// Resource ID (workflow ID or step ID)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Resource name (workflow name or step name)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// User who last updated the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public global::Novu.UserInfoDto? UpdatedBy { get; set; }

        /// <summary>
        /// When the resource was last updated<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInfoDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Resource ID (workflow ID or step ID)
        /// </param>
        /// <param name="name">
        /// Resource name (workflow name or step name)
        /// </param>
        /// <param name="updatedBy">
        /// User who last updated the resource
        /// </param>
        /// <param name="updatedAt">
        /// When the resource was last updated<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceInfoDto(
            string? id,
            string? name,
            global::Novu.UserInfoDto? updatedBy,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.UpdatedBy = updatedBy;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInfoDto" /> class.
        /// </summary>
        public ResourceInfoDto()
        {
        }
    }
}