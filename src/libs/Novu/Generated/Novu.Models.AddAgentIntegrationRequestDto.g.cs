
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddAgentIntegrationRequestDto
    {
        /// <summary>
        /// The integration identifier (same as in the integration store), not the internal document _id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        public string? IntegrationIdentifier { get; set; }

        /// <summary>
        /// Provider ID to auto-create a dedicated integration (e.g. novu-agent-email). When set, the server creates the integration if one does not already exist for this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAgentIntegrationRequestDto" /> class.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// The integration identifier (same as in the integration store), not the internal document _id.
        /// </param>
        /// <param name="providerId">
        /// Provider ID to auto-create a dedicated integration (e.g. novu-agent-email). When set, the server creates the integration if one does not already exist for this agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddAgentIntegrationRequestDto(
            string? integrationIdentifier,
            string? providerId)
        {
            this.IntegrationIdentifier = integrationIdentifier;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAgentIntegrationRequestDto" /> class.
        /// </summary>
        public AddAgentIntegrationRequestDto()
        {
        }

    }
}