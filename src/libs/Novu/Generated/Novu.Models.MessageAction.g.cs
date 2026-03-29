
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageAction
    {
        /// <summary>
        /// Status of the message action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter))]
        public global::Novu.MessageActionStatusEnum? Status { get; set; }

        /// <summary>
        /// List of buttons associated with the message action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buttons")]
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Buttons { get; set; }

        /// <summary>
        /// Result of the message action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Novu.MessageActionResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAction" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the message action
        /// </param>
        /// <param name="buttons">
        /// List of buttons associated with the message action
        /// </param>
        /// <param name="result">
        /// Result of the message action
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageAction(
            global::Novu.MessageActionStatusEnum? status,
            global::System.Collections.Generic.IList<global::Novu.MessageButton>? buttons,
            global::Novu.MessageActionResult? result)
        {
            this.Status = status;
            this.Buttons = buttons;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAction" /> class.
        /// </summary>
        public MessageAction()
        {
        }
    }
}