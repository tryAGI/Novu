
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDomainConnectApplyUrlDto
    {
        /// <summary>
        /// Dashboard URL to return to after the DNS provider consent flow completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainConnectApplyUrlDto" /> class.
        /// </summary>
        /// <param name="redirectUri">
        /// Dashboard URL to return to after the DNS provider consent flow completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDomainConnectApplyUrlDto(
            string? redirectUri)
        {
            this.RedirectUri = redirectUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainConnectApplyUrlDto" /> class.
        /// </summary>
        public CreateDomainConnectApplyUrlDto()
        {
        }
    }
}