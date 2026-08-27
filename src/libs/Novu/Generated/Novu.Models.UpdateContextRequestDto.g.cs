
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateContextRequestDto
    {
        /// <summary>
        /// Custom data to associate with this context. Replaces existing data.<br/>
        /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
        /// </summary>
        /// <example>{"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Optional bridge URL override for agent connect. When an inbound agent turn resolves this context, its bridge call is routed here instead of the agent default bridge URL. Must be a publicly reachable URL. Pass null to clear an existing override.<br/>
        /// Example: https://tenant-acme.example.com/api/novu
        /// </summary>
        /// <example>https://tenant-acme.example.com/api/novu</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bridgeUrl")]
        public string? BridgeUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContextRequestDto" /> class.
        /// </summary>
        /// <param name="data">
        /// Custom data to associate with this context. Replaces existing data.<br/>
        /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
        /// </param>
        /// <param name="bridgeUrl">
        /// Optional bridge URL override for agent connect. When an inbound agent turn resolves this context, its bridge call is routed here instead of the agent default bridge URL. Must be a publicly reachable URL. Pass null to clear an existing override.<br/>
        /// Example: https://tenant-acme.example.com/api/novu
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContextRequestDto(
            object data,
            string? bridgeUrl)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.BridgeUrl = bridgeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContextRequestDto" /> class.
        /// </summary>
        public UpdateContextRequestDto()
        {
        }

    }
}