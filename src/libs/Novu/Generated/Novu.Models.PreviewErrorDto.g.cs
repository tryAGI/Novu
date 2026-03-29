
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewErrorDto
    {
        /// <summary>
        /// Short error title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Detailed error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Actionable hint for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewErrorDto" /> class.
        /// </summary>
        /// <param name="title">
        /// Short error title
        /// </param>
        /// <param name="message">
        /// Detailed error message
        /// </param>
        /// <param name="hint">
        /// Actionable hint for the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewErrorDto(
            string title,
            string message,
            string hint)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Hint = hint ?? throw new global::System.ArgumentNullException(nameof(hint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewErrorDto" /> class.
        /// </summary>
        public PreviewErrorDto()
        {
        }
    }
}