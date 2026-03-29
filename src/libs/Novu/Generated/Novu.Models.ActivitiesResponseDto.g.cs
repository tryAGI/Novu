
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivitiesResponseDto
    {
        /// <summary>
        /// Indicates if there are more activities in the result set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Array of activity notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.ActivityNotificationResponseDto> Data { get; set; }

        /// <summary>
        /// Page size of the activities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// Current page of the activities
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
        /// Initializes a new instance of the <see cref="ActivitiesResponseDto" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Indicates if there are more activities in the result set
        /// </param>
        /// <param name="data">
        /// Array of activity notifications
        /// </param>
        /// <param name="pageSize">
        /// Page size of the activities
        /// </param>
        /// <param name="page">
        /// Current page of the activities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivitiesResponseDto(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Novu.ActivityNotificationResponseDto> data,
            double pageSize,
            double page)
        {
            this.HasMore = hasMore;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesResponseDto" /> class.
        /// </summary>
        public ActivitiesResponseDto()
        {
        }
    }
}