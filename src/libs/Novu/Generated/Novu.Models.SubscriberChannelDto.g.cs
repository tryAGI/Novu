
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberChannelDto
    {
        /// <summary>
        /// The ID of the chat or push provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberChannelDtoProviderId ProviderId { get; set; }

        /// <summary>
        /// An optional identifier for the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        public string? IntegrationIdentifier { get; set; }

        /// <summary>
        /// Credentials for the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChannelCredentialsDto Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberChannelDto" /> class.
        /// </summary>
        /// <param name="providerId">
        /// The ID of the chat or push provider.
        /// </param>
        /// <param name="credentials">
        /// Credentials for the channel.
        /// </param>
        /// <param name="integrationIdentifier">
        /// An optional identifier for the integration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberChannelDto(
            global::Novu.SubscriberChannelDtoProviderId providerId,
            global::Novu.ChannelCredentialsDto credentials,
            string? integrationIdentifier)
        {
            this.ProviderId = providerId;
            this.IntegrationIdentifier = integrationIdentifier;
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberChannelDto" /> class.
        /// </summary>
        public SubscriberChannelDto()
        {
        }
    }
}