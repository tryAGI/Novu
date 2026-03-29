
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurationsDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inboundWebhookEnabled")]
        public bool? InboundWebhookEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inboundWebhookSigningKey")]
        public string? InboundWebhookSigningKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationsDto" /> class.
        /// </summary>
        /// <param name="inboundWebhookEnabled"></param>
        /// <param name="inboundWebhookSigningKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationsDto(
            bool? inboundWebhookEnabled,
            string? inboundWebhookSigningKey)
        {
            this.InboundWebhookEnabled = inboundWebhookEnabled;
            this.InboundWebhookSigningKey = inboundWebhookSigningKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationsDto" /> class.
        /// </summary>
        public ConfigurationsDto()
        {
        }
    }
}