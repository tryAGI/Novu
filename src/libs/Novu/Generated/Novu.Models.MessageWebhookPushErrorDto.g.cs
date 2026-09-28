
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageWebhookPushErrorDto
    {
        /// <summary>
        /// Why the push send failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MessageWebhookPushFailureReasonEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageWebhookPushFailureReasonEnum Reason { get; set; }

        /// <summary>
        /// Device token that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookPushErrorDto" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the push send failed
        /// </param>
        /// <param name="deviceToken">
        /// Device token that failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageWebhookPushErrorDto(
            global::Novu.MessageWebhookPushFailureReasonEnum reason,
            string deviceToken)
        {
            this.Reason = reason;
            this.DeviceToken = deviceToken ?? throw new global::System.ArgumentNullException(nameof(deviceToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookPushErrorDto" /> class.
        /// </summary>
        public MessageWebhookPushErrorDto()
        {
        }

    }
}