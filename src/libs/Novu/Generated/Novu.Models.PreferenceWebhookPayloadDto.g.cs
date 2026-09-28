
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceWebhookPayloadDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferenceWebhookObjectDto Object { get; set; }

        /// <summary>
        /// Identifier of the subscriber whose preference changed
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
        /// Initializes a new instance of the <see cref="PreferenceWebhookPayloadDto" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="subscriberId">
        /// Identifier of the subscriber whose preference changed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceWebhookPayloadDto(
            global::Novu.PreferenceWebhookObjectDto @object,
            string subscriberId)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookPayloadDto" /> class.
        /// </summary>
        public PreferenceWebhookPayloadDto()
        {
        }

    }
}