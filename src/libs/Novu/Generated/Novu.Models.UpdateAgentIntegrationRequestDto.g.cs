
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentIntegrationRequestDto
    {
        /// <summary>
        /// The integration identifier this link should point to (not the internal document _id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentIntegrationRequestDto" /> class.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// The integration identifier this link should point to (not the internal document _id).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentIntegrationRequestDto(
            string integrationIdentifier)
        {
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentIntegrationRequestDto" /> class.
        /// </summary>
        public UpdateAgentIntegrationRequestDto()
        {
        }

    }
}