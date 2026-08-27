
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TypingStatusDto
    {
        /// <summary>
        /// Status text shown while the agent works. Omit for the default "Thinking…".<br/>
        /// Example: Looking up your order…
        /// </summary>
        /// <example>Looking up your order…</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypingStatusDto" /> class.
        /// </summary>
        /// <param name="status">
        /// Status text shown while the agent works. Omit for the default "Thinking…".<br/>
        /// Example: Looking up your order…
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypingStatusDto(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypingStatusDto" /> class.
        /// </summary>
        public TypingStatusDto()
        {
        }

    }
}