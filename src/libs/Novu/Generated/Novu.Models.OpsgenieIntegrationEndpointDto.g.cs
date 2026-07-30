
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpsgenieIntegrationEndpointDto
    {
        /// <summary>
        /// Opsgenie API integration key (GenieKey) in UUID format. Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: abcdefg-a25a-4652-883c-73703b12345
        /// </summary>
        /// <example>abcdefg-a25a-4652-883c-73703b12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Opsgenie account region that determines the alert API data-center endpoint.<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OpsgenieIntegrationEndpointDtoRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OpsgenieIntegrationEndpointDtoRegion Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpsgenieIntegrationEndpointDto" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Opsgenie API integration key (GenieKey) in UUID format. Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: abcdefg-a25a-4652-883c-73703b12345
        /// </param>
        /// <param name="region">
        /// Opsgenie account region that determines the alert API data-center endpoint.<br/>
        /// Example: us
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpsgenieIntegrationEndpointDto(
            string apiKey,
            global::Novu.OpsgenieIntegrationEndpointDtoRegion region)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpsgenieIntegrationEndpointDto" /> class.
        /// </summary>
        public OpsgenieIntegrationEndpointDto()
        {
        }

    }
}