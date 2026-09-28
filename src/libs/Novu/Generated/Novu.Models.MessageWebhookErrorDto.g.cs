
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageWebhookErrorDto
    {
        /// <summary>
        /// Error message from the provider or send attempt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        public global::Novu.MessageWebhookPushErrorDto? Push { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookErrorDto" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message from the provider or send attempt
        /// </param>
        /// <param name="push"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageWebhookErrorDto(
            string message,
            global::Novu.MessageWebhookPushErrorDto? push)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Push = push;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookErrorDto" /> class.
        /// </summary>
        public MessageWebhookErrorDto()
        {
        }

    }
}