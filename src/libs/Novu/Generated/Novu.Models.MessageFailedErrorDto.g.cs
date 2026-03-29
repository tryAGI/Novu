
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageFailedErrorDto
    {
        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Push error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageFailedPushDto Push { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFailedErrorDto" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message
        /// </param>
        /// <param name="push">
        /// Push error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageFailedErrorDto(
            string message,
            global::Novu.MessageFailedPushDto push)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Push = push ?? throw new global::System.ArgumentNullException(nameof(push));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFailedErrorDto" /> class.
        /// </summary>
        public MessageFailedErrorDto()
        {
        }
    }
}