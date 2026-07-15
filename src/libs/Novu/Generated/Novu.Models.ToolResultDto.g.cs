
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResultDto
    {
        /// <summary>
        /// Id of the tool call this result resolves.<br/>
        /// Example: call_abc123
        /// </summary>
        /// <example>call_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Name of the tool that produced this result.<br/>
        /// Example: lookup_order
        /// </summary>
        /// <example>lookup_order</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// JSON-serializable tool output (or the execution-denied marker).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Human-readable preview for the display timeline.<br/>
        /// Example: Order ORD-42 is shipped
        /// </summary>
        /// <example>Order ORD-42 is shipped</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultDto" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Id of the tool call this result resolves.<br/>
        /// Example: call_abc123
        /// </param>
        /// <param name="toolName">
        /// Name of the tool that produced this result.<br/>
        /// Example: lookup_order
        /// </param>
        /// <param name="output">
        /// JSON-serializable tool output (or the execution-denied marker).
        /// </param>
        /// <param name="preview">
        /// Human-readable preview for the display timeline.<br/>
        /// Example: Order ORD-42 is shipped
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResultDto(
            string toolCallId,
            string? toolName,
            object? output,
            string? preview)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolName = toolName;
            this.Output = output;
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultDto" /> class.
        /// </summary>
        public ToolResultDto()
        {
        }

    }
}