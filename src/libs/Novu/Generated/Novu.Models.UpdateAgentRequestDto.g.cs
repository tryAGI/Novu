
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        public global::Novu.AgentBehaviorDto? Behavior { get; set; }

        /// <summary>
        /// Production bridge URL for this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bridgeUrl")]
        public string? BridgeUrl { get; set; }

        /// <summary>
        /// Development bridge URL (set by npx novu dev)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devBridgeUrl")]
        public string? DevBridgeUrl { get; set; }

        /// <summary>
        /// Whether the dev bridge override is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devBridgeActive")]
        public bool? DevBridgeActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequestDto" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        /// <param name="behavior"></param>
        /// <param name="bridgeUrl">
        /// Production bridge URL for this agent
        /// </param>
        /// <param name="devBridgeUrl">
        /// Development bridge URL (set by npx novu dev)
        /// </param>
        /// <param name="devBridgeActive">
        /// Whether the dev bridge override is active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRequestDto(
            string? name,
            string? description,
            bool? active,
            global::Novu.AgentBehaviorDto? behavior,
            string? bridgeUrl,
            string? devBridgeUrl,
            bool? devBridgeActive)
        {
            this.Name = name;
            this.Description = description;
            this.Active = active;
            this.Behavior = behavior;
            this.BridgeUrl = bridgeUrl;
            this.DevBridgeUrl = devBridgeUrl;
            this.DevBridgeActive = devBridgeActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequestDto" /> class.
        /// </summary>
        public UpdateAgentRequestDto()
        {
        }

    }
}