
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAllSubscriberNotificationsDto
    {
        /// <summary>
        /// Filter notifications by workflow tags (OR for string[], or { and: [{ or: string[] }, ...] } for AND of OR-groups).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Filter notifications by data attributes (JSON string)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Context keys for filtering notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAllSubscriberNotificationsDto" /> class.
        /// </summary>
        /// <param name="tags">
        /// Filter notifications by workflow tags (OR for string[], or { and: [{ or: string[] }, ...] } for AND of OR-groups).
        /// </param>
        /// <param name="data">
        /// Filter notifications by data attributes (JSON string)
        /// </param>
        /// <param name="contextKeys">
        /// Context keys for filtering notifications
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAllSubscriberNotificationsDto(
            object? tags,
            string? data,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.Tags = tags;
            this.Data = data;
            this.ContextKeys = contextKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAllSubscriberNotificationsDto" /> class.
        /// </summary>
        public UpdateAllSubscriberNotificationsDto()
        {
        }
    }
}