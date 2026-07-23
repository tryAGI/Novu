
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkChannelEndpointRequestDto
    {
        /// <summary>
        /// Integration identifier for the chat provider integration<br/>
        /// Example: telegram-bot
        /// </summary>
        /// <example>telegram-bot</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// External subscriber identifier to link to their chat identity<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkChannelEndpointRequestDto" /> class.
        /// </summary>
        /// <param name="integrationIdentifier">
        /// Integration identifier for the chat provider integration<br/>
        /// Example: telegram-bot
        /// </param>
        /// <param name="subscriberId">
        /// External subscriber identifier to link to their chat identity<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkChannelEndpointRequestDto(
            string integrationIdentifier,
            string subscriberId,
            object? context)
        {
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkChannelEndpointRequestDto" /> class.
        /// </summary>
        public LinkChannelEndpointRequestDto()
        {
        }

    }
}