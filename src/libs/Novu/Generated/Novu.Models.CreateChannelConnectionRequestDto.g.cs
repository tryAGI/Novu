
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
        /// Connection mode that determines how the channel connection is scoped. Use "subscriber" (default) to associate the connection with a specific subscriber. Use "shared" to associate the connection with a context instead of a subscriber — subscriberId will not be stored on the connection.<br/>
        /// Example: shared
        /// </summary>
        /// <example>shared</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter))]
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? ConnectionMode { get; set; }

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
        /// <param name="connectionMode">
        /// Connection mode that determines how the channel connection is scoped. Use "subscriber" (default) to associate the connection with a specific subscriber. Use "shared" to associate the connection with a context instead of a subscriber — subscriberId will not be stored on the connection.<br/>
        /// Example: shared
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChannelConnectionRequestDto(
            string integrationIdentifier,
            global::Novu.WorkspaceDto workspace,
            global::Novu.AuthDto auth,
            string? identifier,
            string? subscriberId,
            object? context,
            global::Novu.CreateChannelConnectionRequestDtoConnectionMode? connectionMode)
        {
            this.Identifier = identifier;
            this.SubscriberId = subscriberId;
            this.Context = context;
            this.ConnectionMode = connectionMode;
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