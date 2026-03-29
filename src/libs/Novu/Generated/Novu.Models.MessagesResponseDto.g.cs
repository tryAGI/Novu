
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResponseDto
    {
        /// <summary>
        /// Total number of messages available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// Indicates if there are more messages available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// List of messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.MessageResponseDto> Data { get; set; }

        /// <summary>
        /// Number of messages per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponseDto" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Indicates if there are more messages available
        /// </param>
        /// <param name="data">
        /// List of messages
        /// </param>
        /// <param name="pageSize">
        /// Number of messages per page
        /// </param>
        /// <param name="page">
        /// Current page number
        /// </param>
        /// <param name="totalCount">
        /// Total number of messages available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResponseDto(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Novu.MessageResponseDto> data,
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
        /// Initializes a new instance of the <see cref="MessagesResponseDto" /> class.
        /// </summary>
        public MessagesResponseDto()
        {
        }
    }
}