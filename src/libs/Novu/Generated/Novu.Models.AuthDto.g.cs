
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthDto
    {
        /// <summary>
        /// Example: Workspace access token
        /// </summary>
        /// <example>Workspace access token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDto" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// Example: Workspace access token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthDto(
            string accessToken)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDto" /> class.
        /// </summary>
        public AuthDto()
        {
        }
    }
}