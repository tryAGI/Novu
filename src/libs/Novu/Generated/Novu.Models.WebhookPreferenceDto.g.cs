
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPreferenceDto
    {
        /// <summary>
        /// Current preference state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Object { get; set; }

        /// <summary>
        /// Subscriber ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPreferenceDto" /> class.
        /// </summary>
        /// <param name="object">
        /// Current preference state
        /// </param>
        /// <param name="subscriberId">
        /// Subscriber ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPreferenceDto(
            object @object,
            string subscriberId)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPreferenceDto" /> class.
        /// </summary>
        public WebhookPreferenceDto()
        {
        }
    }
}