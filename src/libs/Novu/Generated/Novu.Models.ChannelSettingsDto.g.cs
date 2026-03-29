
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelSettingsDto
    {
        /// <summary>
        /// The provider identifier for the credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChatOrPushProviderEnum ProviderId { get; set; }

        /// <summary>
        /// The integration identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        public string? IntegrationIdentifier { get; set; }

        /// <summary>
        /// Credentials payload for the specified provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChannelCredentials Credentials { get; set; }

        /// <summary>
        /// The unique identifier of the integration associated with this channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelSettingsDto" /> class.
        /// </summary>
        /// <param name="providerId">
        /// The provider identifier for the credentials
        /// </param>
        /// <param name="credentials">
        /// Credentials payload for the specified provider
        /// </param>
        /// <param name="integrationId">
        /// The unique identifier of the integration associated with this channel.
        /// </param>
        /// <param name="integrationIdentifier">
        /// The integration identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelSettingsDto(
            global::Novu.ChatOrPushProviderEnum providerId,
            global::Novu.ChannelCredentials credentials,
            string integrationId,
            string? integrationIdentifier)
        {
            this.ProviderId = providerId;
            this.IntegrationIdentifier = integrationIdentifier;
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelSettingsDto" /> class.
        /// </summary>
        public ChannelSettingsDto()
        {
        }
    }
}