
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkAllMessageAsRequestDto
    {
        /// <summary>
        /// Optional feed identifier or array of feed identifiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedIdentifier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? FeedIdentifier { get; set; }

        /// <summary>
        /// Mark all subscriber messages as read, unread, seen or unseen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markAs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MarkAllMessageAsRequestDtoMarkAs MarkAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkAllMessageAsRequestDto" /> class.
        /// </summary>
        /// <param name="markAs">
        /// Mark all subscriber messages as read, unread, seen or unseen
        /// </param>
        /// <param name="feedIdentifier">
        /// Optional feed identifier or array of feed identifiers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkAllMessageAsRequestDto(
            global::Novu.MarkAllMessageAsRequestDtoMarkAs markAs,
            global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? feedIdentifier)
        {
            this.FeedIdentifier = feedIdentifier;
            this.MarkAs = markAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkAllMessageAsRequestDto" /> class.
        /// </summary>
        public MarkAllMessageAsRequestDto()
        {
        }
    }
}