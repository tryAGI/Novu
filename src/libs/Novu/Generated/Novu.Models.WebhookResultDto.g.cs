
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookResultDto
    {
        /// <summary>
        /// Unique identifier for the webhook result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Event body containing the webhook event data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.EventBody Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResultDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the webhook result
        /// </param>
        /// <param name="event">
        /// Event body containing the webhook event data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookResultDto(
            string id,
            global::Novu.EventBody @event)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResultDto" /> class.
        /// </summary>
        public WebhookResultDto()
        {
        }
    }
}