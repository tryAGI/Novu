
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserResponseDto
    {
        /// <summary>
        /// User ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// User external ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// User ID
        /// </param>
        /// <param name="firstName">
        /// User first name
        /// </param>
        /// <param name="lastName">
        /// User last name
        /// </param>
        /// <param name="externalId">
        /// User external ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserResponseDto(
            string id,
            string? firstName,
            string? lastName,
            string? externalId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseDto" /> class.
        /// </summary>
        public UserResponseDto()
        {
        }
    }
}