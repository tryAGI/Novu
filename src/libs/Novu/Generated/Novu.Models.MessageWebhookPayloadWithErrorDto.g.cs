
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageWebhookPayloadWithErrorDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageWebhookResponseDto Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Novu.MessageWebhookErrorDto? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookPayloadWithErrorDto" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageWebhookPayloadWithErrorDto(
            global::Novu.MessageWebhookResponseDto @object,
            global::Novu.MessageWebhookErrorDto? error)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookPayloadWithErrorDto" /> class.
        /// </summary>
        public MessageWebhookPayloadWithErrorDto()
        {
        }

    }
}