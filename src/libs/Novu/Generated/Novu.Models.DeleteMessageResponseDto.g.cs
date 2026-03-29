
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMessageResponseDto
    {
        /// <summary>
        /// A boolean stating the success of the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Acknowledged { get; set; }

        /// <summary>
        /// The status enum for the performed action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter))]
        public global::Novu.DeleteMessageResponseDtoStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessageResponseDto" /> class.
        /// </summary>
        /// <param name="acknowledged">
        /// A boolean stating the success of the action
        /// </param>
        /// <param name="status">
        /// The status enum for the performed action
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMessageResponseDto(
            bool acknowledged,
            global::Novu.DeleteMessageResponseDtoStatus status)
        {
            this.Acknowledged = acknowledged;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessageResponseDto" /> class.
        /// </summary>
        public DeleteMessageResponseDto()
        {
        }
    }
}