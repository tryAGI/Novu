
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MsTeamsUserEndpointDto
    {
        /// <summary>
        /// MS Teams user ID<br/>
        /// Example: 29:1234567890abcdef
        /// </summary>
        /// <example>29:1234567890abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MsTeamsUserEndpointDto" /> class.
        /// </summary>
        /// <param name="userId">
        /// MS Teams user ID<br/>
        /// Example: 29:1234567890abcdef
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MsTeamsUserEndpointDto(
            string userId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MsTeamsUserEndpointDto" /> class.
        /// </summary>
        public MsTeamsUserEndpointDto()
        {
        }
    }
}