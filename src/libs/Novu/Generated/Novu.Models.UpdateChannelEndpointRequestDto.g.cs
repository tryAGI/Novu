
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChannelEndpointRequestDto
    {
        /// <summary>
        /// Updated endpoint data. The structure must match the existing channel endpoint type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto> Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelEndpointRequestDto" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// Updated endpoint data. The structure must match the existing channel endpoint type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelEndpointRequestDto(
            global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto> endpoint)
        {
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelEndpointRequestDto" /> class.
        /// </summary>
        public UpdateChannelEndpointRequestDto()
        {
        }
    }
}