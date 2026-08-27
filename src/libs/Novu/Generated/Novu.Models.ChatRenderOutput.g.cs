
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatRenderOutput
    {
        /// <summary>
        /// Body of the chat message. Mutually exclusive with `card`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Rich Chat: compiled provider-agnostic card DSL. Mutually exclusive with `body`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public object? Card { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRenderOutput" /> class.
        /// </summary>
        /// <param name="body">
        /// Body of the chat message. Mutually exclusive with `card`.
        /// </param>
        /// <param name="card">
        /// Rich Chat: compiled provider-agnostic card DSL. Mutually exclusive with `body`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRenderOutput(
            string? body,
            object? card)
        {
            this.Body = body;
            this.Card = card;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRenderOutput" /> class.
        /// </summary>
        public ChatRenderOutput()
        {
        }

    }
}