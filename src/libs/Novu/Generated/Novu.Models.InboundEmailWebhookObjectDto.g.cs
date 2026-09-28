
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboundEmailWebhookObjectDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.InboundEmailWebhookDomainDto Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.InboundEmailWebhookRouteDto Route { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.InboundEmailWebhookMailDto Mail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookObjectDto" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="route"></param>
        /// <param name="mail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboundEmailWebhookObjectDto(
            global::Novu.InboundEmailWebhookDomainDto domain,
            global::Novu.InboundEmailWebhookRouteDto route,
            global::Novu.InboundEmailWebhookMailDto mail)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Mail = mail ?? throw new global::System.ArgumentNullException(nameof(mail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookObjectDto" /> class.
        /// </summary>
        public InboundEmailWebhookObjectDto()
        {
        }

    }
}