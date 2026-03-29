
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChannelConnectionRequestDto
    {
        /// <summary>
        /// The unique identifier for the channel connection. If not provided, one will be generated automatically.<br/>
        /// Example: slack-prod-user123-abc4
        /// </summary>
        /// <example>slack-prod-user123-abc4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The subscriber ID to link the channel connection to<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// The identifier of the integration to use for this channel connection.<br/>
        /// Example: slack-prod
        /// </summary>
        /// <example>slack-prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkspaceDto Workspace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.AuthDto Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelConnectionRequestDto" /> class.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// The identifier of the integration to use for this channel connection.<br/>
        /// Example: slack-prod
        /// </param>
        /// <param name="workspace"></param>
        /// <param name="auth"></param>
        /// <param name="identifier">
        /// The unique identifier for the channel connection. If not provided, one will be generated automatically.<br/>
        /// Example: slack-prod-user123-abc4
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID to link the channel connection to<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChannelConnectionRequestDto(
            string integrationIdentifier,
            global::Novu.WorkspaceDto workspace,
            global::Novu.AuthDto auth,
            string? identifier,
            string? subscriberId,
            object? context)
        {
            this.Identifier = identifier;
            this.SubscriberId = subscriberId;
            this.Context = context;
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelConnectionRequestDto" /> class.
        /// </summary>
        public CreateChannelConnectionRequestDto()
        {
        }
    }
}