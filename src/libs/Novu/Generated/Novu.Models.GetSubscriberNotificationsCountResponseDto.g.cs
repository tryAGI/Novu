
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriberNotificationsCountResponseDto
    {
        /// <summary>
        /// The count of notifications matching the filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// The filter applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriberNotificationsCountResponseDto" /> class.
        /// </summary>
        /// <param name="count">
        /// The count of notifications matching the filter
        /// </param>
        /// <param name="filter">
        /// The filter applied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSubscriberNotificationsCountResponseDto(
            double count,
            object filter)
        {
            this.Count = count;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriberNotificationsCountResponseDto" /> class.
        /// </summary>
        public GetSubscriberNotificationsCountResponseDto()
        {
        }
    }
}