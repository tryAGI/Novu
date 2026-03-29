
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedResponseDto
    {
        /// <summary>
        /// Total number of notifications available.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// Indicates if there are more notifications to load.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Array of notifications returned in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto> Data { get; set; }

        /// <summary>
        /// The number of notifications returned in this response.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// The current page number of the notifications.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedResponseDto" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Indicates if there are more notifications to load.<br/>
        /// Example: true
        /// </param>
        /// <param name="data">
        /// Array of notifications returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// The number of notifications returned in this response.<br/>
        /// Example: 2
        /// </param>
        /// <param name="page">
        /// The current page number of the notifications.<br/>
        /// Example: 1
        /// </param>
        /// <param name="totalCount">
        /// Total number of notifications available.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedResponseDto(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto> data,
            double pageSize,
            double page,
            double? totalCount)
        {
            this.TotalCount = totalCount;
            this.HasMore = hasMore;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedResponseDto" /> class.
        /// </summary>
        public FeedResponseDto()
        {
        }
    }
}