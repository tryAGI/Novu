
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailedOperationDto
    {
        /// <summary>
        /// The error message associated with the failed operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The subscriber ID associated with the failed operation. This field is optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedOperationDto" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message associated with the failed operation.
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID associated with the failed operation. This field is optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FailedOperationDto(
            string? message,
            string? subscriberId)
        {
            this.Message = message;
            this.SubscriberId = subscriberId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedOperationDto" /> class.
        /// </summary>
        public FailedOperationDto()
        {
        }
    }
}