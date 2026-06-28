
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkChannelEndpointResponseDto
    {
        /// <summary>
        /// URL the subscriber opens to link their chat identity (OAuth URL or deep link)<br/>
        /// Example: https://t.me/MyBot?start=AbCdEfGhIjKlMnOpQrStUvWxYz012345
        /// </summary>
        /// <example>https://t.me/MyBot?start=AbCdEfGhIjKlMnOpQrStUvWxYz012345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Provider-specific metadata returned alongside the link URL<br/>
        /// Example: {"botUsername":"MyBot","expiresAt":"2026-06-23T12:00:00.000Z"}
        /// </summary>
        /// <example>{"botUsername":"MyBot","expiresAt":"2026-06-23T12:00:00.000Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerMetadata")]
        public object? ProviderMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkChannelEndpointResponseDto" /> class.
        /// </summary>
        /// <param name="url">
        /// URL the subscriber opens to link their chat identity (OAuth URL or deep link)<br/>
        /// Example: https://t.me/MyBot?start=AbCdEfGhIjKlMnOpQrStUvWxYz012345
        /// </param>
        /// <param name="providerMetadata">
        /// Provider-specific metadata returned alongside the link URL<br/>
        /// Example: {"botUsername":"MyBot","expiresAt":"2026-06-23T12:00:00.000Z"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkChannelEndpointResponseDto(
            string url,
            object? providerMetadata)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProviderMetadata = providerMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkChannelEndpointResponseDto" /> class.
        /// </summary>
        public LinkChannelEndpointResponseDto()
        {
        }

    }
}