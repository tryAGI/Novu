
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTopicResponseDto
    {
        /// <summary>
        /// Indicates if the operation was acknowledged<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Acknowledged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicResponseDto" /> class.
        /// </summary>
        /// <param name="acknowledged">
        /// Indicates if the operation was acknowledged<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTopicResponseDto(
            bool acknowledged)
        {
            this.Acknowledged = acknowledged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicResponseDto" /> class.
        /// </summary>
        public DeleteTopicResponseDto()
        {
        }
    }
}