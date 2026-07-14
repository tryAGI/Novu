
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentIntegrationsControllerListAgentIntegrationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Novu.ListAgentIntegrationsResponseDto? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationsControllerListAgentIntegrationsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentIntegrationsControllerListAgentIntegrationsResponse(
            global::Novu.ListAgentIntegrationsResponseDto? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationsControllerListAgentIntegrationsResponse" /> class.
        /// </summary>
        public AgentIntegrationsControllerListAgentIntegrationsResponse()
        {
        }

    }
}