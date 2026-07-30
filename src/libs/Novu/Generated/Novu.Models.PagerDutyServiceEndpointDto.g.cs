
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagerDutyServiceEndpointDto
    {
        /// <summary>
        /// PagerDuty Events API v2 integration key (32-character alphanumeric string). Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: R0UTINGK3YEXAMPLE000000000000000
        /// </summary>
        /// <example>R0UTINGK3YEXAMPLE000000000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("routingKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutingKey { get; set; }

        /// <summary>
        /// PagerDuty account region — determines the events API data-center endpoint.<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.PagerDutyServiceEndpointDtoRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PagerDutyServiceEndpointDtoRegion Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagerDutyServiceEndpointDto" /> class.
        /// </summary>
        /// <param name="routingKey">
        /// PagerDuty Events API v2 integration key (32-character alphanumeric string). Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: R0UTINGK3YEXAMPLE000000000000000
        /// </param>
        /// <param name="region">
        /// PagerDuty account region — determines the events API data-center endpoint.<br/>
        /// Example: us
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagerDutyServiceEndpointDto(
            string routingKey,
            global::Novu.PagerDutyServiceEndpointDtoRegion region)
        {
            this.RoutingKey = routingKey ?? throw new global::System.ArgumentNullException(nameof(routingKey));
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagerDutyServiceEndpointDto" /> class.
        /// </summary>
        public PagerDutyServiceEndpointDto()
        {
        }

    }
}