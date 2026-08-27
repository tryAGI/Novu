
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
        /// Example: Workspace refresh token
        /// </summary>
        /// <example>Workspace refresh token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshToken")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Example: 2026-06-15T12:00:00.000Z
        /// </summary>
        /// <example>2026-06-15T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Example: 2026-09-15T12:00:00.000Z
        /// </summary>
        /// <example>2026-09-15T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenExpiresAt")]
        public string? RefreshTokenExpiresAt { get; set; }

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
        /// <param name="refreshToken">
        /// Example: Workspace refresh token
        /// </param>
        /// <param name="expiresAt">
        /// Example: 2026-06-15T12:00:00.000Z
        /// </param>
        /// <param name="refreshTokenExpiresAt">
        /// Example: 2026-09-15T12:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthDto(
            string accessToken,
            string? refreshToken,
            string? expiresAt,
            string? refreshTokenExpiresAt)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.RefreshToken = refreshToken;
            this.ExpiresAt = expiresAt;
            this.RefreshTokenExpiresAt = refreshTokenExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDto" /> class.
        /// </summary>
        public AuthDto()
        {
        }

    }
}