
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlackChannelEndpointDto
    {
        /// <summary>
        /// Slack channel ID<br/>
        /// Example: C123456789
        /// </summary>
        /// <example>C123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelEndpointDto" /> class.
        /// </summary>
        /// <param name="channelId">
        /// Slack channel ID<br/>
        /// Example: C123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelEndpointDto(
            string channelId)
        {
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelEndpointDto" /> class.
        /// </summary>
        public SlackChannelEndpointDto()
        {
        }
    }
}