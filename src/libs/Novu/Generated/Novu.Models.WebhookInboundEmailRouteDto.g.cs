
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInboundEmailRouteDto
    {
        /// <summary>
        /// Route address (local part of the email address)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInboundEmailRouteDto" /> class.
        /// </summary>
        /// <param name="address">
        /// Route address (local part of the email address)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInboundEmailRouteDto(
            string address)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInboundEmailRouteDto" /> class.
        /// </summary>
        public WebhookInboundEmailRouteDto()
        {
        }
    }
}