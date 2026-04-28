
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateLinkUserOauthUrlRequestDto
    {
        /// <summary>
        /// The subscriber ID to link to their chat identity. Required — this operation always binds a specific subscriber to a user identity in the chat provider.<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Integration identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// Identifier of the existing channel connection to associate this user endpoint with. Generated automatically if not provided.<br/>
        /// Example: slack-connection-abc123
        /// </summary>
        /// <example>slack-connection-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionIdentifier")]
        public string? ConnectionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// **Slack only**: User-level OAuth scopes for "Sign in with Slack". Defaults to: identity.basic. **MS Teams**: ignored — uses delegated OpenID scopes (openid, profile, User.Read).<br/>
        /// Example: [identity.basic]
        /// </summary>
        /// <example>[identity.basic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScope")]
        public global::System.Collections.Generic.IList<string>? UserScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLinkUserOauthUrlRequestDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// The subscriber ID to link to their chat identity. Required — this operation always binds a specific subscriber to a user identity in the chat provider.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="integrationIdentifier">
        /// Integration identifier
        /// </param>
        /// <param name="connectionIdentifier">
        /// Identifier of the existing channel connection to associate this user endpoint with. Generated automatically if not provided.<br/>
        /// Example: slack-connection-abc123
        /// </param>
        /// <param name="context"></param>
        /// <param name="userScope">
        /// **Slack only**: User-level OAuth scopes for "Sign in with Slack". Defaults to: identity.basic. **MS Teams**: ignored — uses delegated OpenID scopes (openid, profile, User.Read).<br/>
        /// Example: [identity.basic]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateLinkUserOauthUrlRequestDto(
            string subscriberId,
            string integrationIdentifier,
            string? connectionIdentifier,
            object? context,
            global::System.Collections.Generic.IList<string>? userScope)
        {
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.ConnectionIdentifier = connectionIdentifier;
            this.Context = context;
            this.UserScope = userScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLinkUserOauthUrlRequestDto" /> class.
        /// </summary>
        public GenerateLinkUserOauthUrlRequestDto()
        {
        }
    }
}