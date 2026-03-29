
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageActionResult
    {
        /// <summary>
        /// Payload of the action result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Type of button for the action result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ButtonTypeEnumJsonConverter))]
        public global::Novu.ButtonTypeEnum? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageActionResult" /> class.
        /// </summary>
        /// <param name="payload">
        /// Payload of the action result
        /// </param>
        /// <param name="type">
        /// Type of button for the action result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageActionResult(
            object? payload,
            global::Novu.ButtonTypeEnum? type)
        {
            this.Payload = payload;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageActionResult" /> class.
        /// </summary>
        public MessageActionResult()
        {
        }
    }
}