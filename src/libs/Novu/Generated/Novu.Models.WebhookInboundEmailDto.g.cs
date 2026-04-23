
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInboundEmailDto
    {
        /// <summary>
        /// Domain that received the email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WebhookInboundEmailDomainDto Domain { get; set; }

        /// <summary>
        /// Matched route info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public global::Novu.WebhookInboundEmailRouteDto? Route { get; set; }

        /// <summary>
        /// Inbound email details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WebhookInboundEmailMailDto Mail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInboundEmailDto" /> class.
        /// </summary>
        /// <param name="domain">
        /// Domain that received the email
        /// </param>
        /// <param name="mail">
        /// Inbound email details
        /// </param>
        /// <param name="route">
        /// Matched route info
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInboundEmailDto(
            global::Novu.WebhookInboundEmailDomainDto domain,
            global::Novu.WebhookInboundEmailMailDto mail,
            global::Novu.WebhookInboundEmailRouteDto? route)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Route = route;
            this.Mail = mail ?? throw new global::System.ArgumentNullException(nameof(mail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInboundEmailDto" /> class.
        /// </summary>
        public WebhookInboundEmailDto()
        {
        }
    }
}