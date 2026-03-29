
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkMessageActionAsSeenDto
    {
        /// <summary>
        /// Message action status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MarkMessageActionAsSeenDtoStatus Status { get; set; }

        /// <summary>
        /// Message action payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkMessageActionAsSeenDto" /> class.
        /// </summary>
        /// <param name="status">
        /// Message action status
        /// </param>
        /// <param name="payload">
        /// Message action payload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkMessageActionAsSeenDto(
            global::Novu.MarkMessageActionAsSeenDtoStatus status,
            object? payload)
        {
            this.Status = status;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkMessageActionAsSeenDto" /> class.
        /// </summary>
        public MarkMessageActionAsSeenDto()
        {
        }
    }
}