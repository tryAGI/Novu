
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestDomainRouteDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TestDomainRouteFromDto From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// When true, returns the payload that would be delivered without invoking outbound webhooks or the agent HTTP endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteDto" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="subject"></param>
        /// <param name="text"></param>
        /// <param name="html"></param>
        /// <param name="dryRun">
        /// When true, returns the payload that would be delivered without invoking outbound webhooks or the agent HTTP endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDomainRouteDto(
            global::Novu.TestDomainRouteFromDto from,
            string subject,
            string? text,
            string? html,
            bool? dryRun)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Text = text;
            this.Html = html;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteDto" /> class.
        /// </summary>
        public TestDomainRouteDto()
        {
        }
    }
}