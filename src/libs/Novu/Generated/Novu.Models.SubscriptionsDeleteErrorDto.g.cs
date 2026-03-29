
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionsDeleteErrorDto
    {
        /// <summary>
        /// The subscriber ID that failed<br/>
        /// Example: invalid-subscriber-id
        /// </summary>
        /// <example>invalid-subscriber-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// The error code<br/>
        /// Example: SUBSCRIBER_NOT_FOUND
        /// </summary>
        /// <example>SUBSCRIBER_NOT_FOUND</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The error message<br/>
        /// Example: Subscriber with ID invalid-subscriber-id could not be found
        /// </summary>
        /// <example>Subscriber with ID invalid-subscriber-id could not be found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsDeleteErrorDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// The subscriber ID that failed<br/>
        /// Example: invalid-subscriber-id
        /// </param>
        /// <param name="code">
        /// The error code<br/>
        /// Example: SUBSCRIBER_NOT_FOUND
        /// </param>
        /// <param name="message">
        /// The error message<br/>
        /// Example: Subscriber with ID invalid-subscriber-id could not be found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionsDeleteErrorDto(
            string subscriberId,
            string code,
            string message)
        {
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsDeleteErrorDto" /> class.
        /// </summary>
        public SubscriptionsDeleteErrorDto()
        {
        }
    }
}