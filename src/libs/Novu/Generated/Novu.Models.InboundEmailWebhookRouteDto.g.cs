
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboundEmailWebhookRouteDto
    {
        /// <summary>
        /// Route address, meaning the local part of the receiving email address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Custom data configured on the route, for example a tenant identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookRouteDto" /> class.
        /// </summary>
        /// <param name="address">
        /// Route address, meaning the local part of the receiving email address
        /// </param>
        /// <param name="data">
        /// Custom data configured on the route, for example a tenant identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboundEmailWebhookRouteDto(
            string address,
            object data)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookRouteDto" /> class.
        /// </summary>
        public InboundEmailWebhookRouteDto()
        {
        }

    }
}