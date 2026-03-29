
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateChatOAuthUrlResponseDto
    {
        /// <summary>
        /// The OAuth authorization URL for the chat provider. For Slack: https://slack.com/oauth/v2/authorize?... For MS Teams: https://login.microsoftonline.com/.../adminconsent?... This URL should be presented to the user to authorize the integration. Expires after 5 minutes.<br/>
        /// Example: https://slack.com/oauth/v2/authorize?state=...
        /// </summary>
        /// <example>https://slack.com/oauth/v2/authorize?state=...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateChatOAuthUrlResponseDto" /> class.
        /// </summary>
        /// <param name="url">
        /// The OAuth authorization URL for the chat provider. For Slack: https://slack.com/oauth/v2/authorize?... For MS Teams: https://login.microsoftonline.com/.../adminconsent?... This URL should be presented to the user to authorize the integration. Expires after 5 minutes.<br/>
        /// Example: https://slack.com/oauth/v2/authorize?state=...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateChatOAuthUrlResponseDto(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateChatOAuthUrlResponseDto" /> class.
        /// </summary>
        public GenerateChatOAuthUrlResponseDto()
        {
        }
    }
}