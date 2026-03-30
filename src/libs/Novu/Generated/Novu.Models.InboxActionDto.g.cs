
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InboxActionDto
    {
        /// <summary>
        /// Label of the action button
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Whether the action has been completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCompleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCompleted { get; set; }

        /// <summary>
        /// Redirect configuration for the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Novu.RedirectDto? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxActionDto" /> class.
        /// </summary>
        /// <param name="label">
        /// Label of the action button
        /// </param>
        /// <param name="isCompleted">
        /// Whether the action has been completed
        /// </param>
        /// <param name="redirect">
        /// Redirect configuration for the action
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxActionDto(
            string label,
            bool isCompleted,
            global::Novu.RedirectDto? redirect)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.IsCompleted = isCompleted;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxActionDto" /> class.
        /// </summary>
        public InboxActionDto()
        {
        }
    }
}