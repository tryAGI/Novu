
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatControlDto
    {
        /// <summary>
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </summary>
        /// <example>{"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public object? Skip { get; set; }

        /// <summary>
        /// Content of the chat message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Type of editor to use for the body. When omitted, inferred from the body: Maily JSON is "block", otherwise "text".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChatControlDtoEditorTypeJsonConverter))]
        public global::Novu.ChatControlDtoEditorType? EditorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatControlDto" /> class.
        /// </summary>
        /// <param name="skip">
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </param>
        /// <param name="body">
        /// Content of the chat message.
        /// </param>
        /// <param name="editorType">
        /// Type of editor to use for the body. When omitted, inferred from the body: Maily JSON is "block", otherwise "text".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatControlDto(
            object? skip,
            string? body,
            global::Novu.ChatControlDtoEditorType? editorType)
        {
            this.Skip = skip;
            this.Body = body;
            this.EditorType = editorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatControlDto" /> class.
        /// </summary>
        public ChatControlDto()
        {
        }

    }
}