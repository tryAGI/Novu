
#nullable enable

namespace Novu
{
    /// <summary>
    /// Provider-specific metadata returned alongside the link URL<br/>
    /// Example: {"botUsername":"MyBot","expiresAt":"2026-06-23T12:00:00.000Z"}
    /// </summary>
    public sealed partial class LinkChannelEndpointResponseDtoProviderMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}