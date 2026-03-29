
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlackUserEndpointDto
    {
        /// <summary>
        /// Slack user ID<br/>
        /// Example: U123456789
        /// </summary>
        /// <example>U123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackUserEndpointDto" /> class.
        /// </summary>
        /// <param name="userId">
        /// Slack user ID<br/>
        /// Example: U123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackUserEndpointDto(
            string userId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackUserEndpointDto" /> class.
        /// </summary>
        public SlackUserEndpointDto()
        {
        }
    }
}