
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageFailedPushDto
    {
        /// <summary>
        /// Is invalid token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInvalidToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInvalidToken { get; set; }

        /// <summary>
        /// Device token
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
        /// Initializes a new instance of the <see cref="MessageFailedPushDto" /> class.
        /// </summary>
        /// <param name="isInvalidToken">
        /// Is invalid token
        /// </param>
        /// <param name="deviceToken">
        /// Device token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageFailedPushDto(
            bool isInvalidToken,
            string deviceToken)
        {
            this.IsInvalidToken = isInvalidToken;
            this.DeviceToken = deviceToken ?? throw new global::System.ArgumentNullException(nameof(deviceToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFailedPushDto" /> class.
        /// </summary>
        public MessageFailedPushDto()
        {
        }
    }
}