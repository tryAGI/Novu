
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRequestsResponseDto
    {
        /// <summary>
        /// Request log data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.RequestLogResponseDto> Data { get; set; }

        /// <summary>
        /// Total number of requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public double? PageSize { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public double? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestsResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// Request log data
        /// </param>
        /// <param name="total">
        /// Total number of requests
        /// </param>
        /// <param name="pageSize">
        /// Page size
        /// </param>
        /// <param name="page">
        /// Current page number
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRequestsResponseDto(
            global::System.Collections.Generic.IList<global::Novu.RequestLogResponseDto> data,
            double total,
            double? pageSize,
            double? page)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Total = total;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestsResponseDto" /> class.
        /// </summary>
        public GetRequestsResponseDto()
        {
        }
    }
}