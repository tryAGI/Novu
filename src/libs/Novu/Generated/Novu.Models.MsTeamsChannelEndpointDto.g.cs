
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MsTeamsChannelEndpointDto
    {
        /// <summary>
        /// MS Teams team ID<br/>
        /// Example: 19:abc123...@thread.tacv2
        /// </summary>
        /// <example>19:abc123...@thread.tacv2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// MS Teams channel ID<br/>
        /// Example: 19:def456...@thread.tacv2
        /// </summary>
        /// <example>19:def456...@thread.tacv2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MsTeamsChannelEndpointDto" /> class.
        /// </summary>
        /// <param name="teamId">
        /// MS Teams team ID<br/>
        /// Example: 19:abc123...@thread.tacv2
        /// </param>
        /// <param name="channelId">
        /// MS Teams channel ID<br/>
        /// Example: 19:def456...@thread.tacv2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MsTeamsChannelEndpointDto(
            string teamId,
            string channelId)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MsTeamsChannelEndpointDto" /> class.
        /// </summary>
        public MsTeamsChannelEndpointDto()
        {
        }
    }
}