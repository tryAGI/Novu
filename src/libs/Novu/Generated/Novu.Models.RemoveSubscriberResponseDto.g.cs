
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveSubscriberResponseDto
    {
        /// <summary>
        /// Indicates whether the operation was acknowledged by the server<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Acknowledged { get; set; }

        /// <summary>
        /// Status of the subscriber removal operation<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSubscriberResponseDto" /> class.
        /// </summary>
        /// <param name="acknowledged">
        /// Indicates whether the operation was acknowledged by the server<br/>
        /// Example: true
        /// </param>
        /// <param name="status">
        /// Status of the subscriber removal operation<br/>
        /// Example: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveSubscriberResponseDto(
            bool acknowledged,
            string status)
        {
            this.Acknowledged = acknowledged;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSubscriberResponseDto" /> class.
        /// </summary>
        public RemoveSubscriberResponseDto()
        {
        }
    }
}