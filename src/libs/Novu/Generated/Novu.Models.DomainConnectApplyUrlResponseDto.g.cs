
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainConnectApplyUrlResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApplyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainConnectApplyUrlResponseDto" /> class.
        /// </summary>
        /// <param name="applyUrl"></param>
        /// <param name="providerName"></param>
        /// <param name="redirectUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainConnectApplyUrlResponseDto(
            string applyUrl,
            string providerName,
            string redirectUri)
        {
            this.ApplyUrl = applyUrl ?? throw new global::System.ArgumentNullException(nameof(applyUrl));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.RedirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainConnectApplyUrlResponseDto" /> class.
        /// </summary>
        public DomainConnectApplyUrlResponseDto()
        {
        }
    }
}