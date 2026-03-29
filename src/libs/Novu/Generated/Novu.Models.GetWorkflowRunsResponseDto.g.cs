
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowRunsResponseDto
    {
        /// <summary>
        /// Workflow runs data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.GetWorkflowRunsDto> Data { get; set; }

        /// <summary>
        /// Next cursor for pagination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public object? Next { get; set; }

        /// <summary>
        /// Previous cursor for pagination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public object? Previous { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowRunsResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// Workflow runs data
        /// </param>
        /// <param name="next">
        /// Next cursor for pagination
        /// </param>
        /// <param name="previous">
        /// Previous cursor for pagination
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowRunsResponseDto(
            global::System.Collections.Generic.IList<global::Novu.GetWorkflowRunsDto> data,
            object? next,
            object? previous)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Next = next;
            this.Previous = previous;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowRunsResponseDto" /> class.
        /// </summary>
        public GetWorkflowRunsResponseDto()
        {
        }
    }
}