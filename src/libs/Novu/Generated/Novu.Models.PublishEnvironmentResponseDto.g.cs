
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishEnvironmentResponseDto
    {
        /// <summary>
        /// Sync results by resource type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SyncResultDto> Results { get; set; }

        /// <summary>
        /// Summary of the sync operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PublishSummaryDto Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishEnvironmentResponseDto" /> class.
        /// </summary>
        /// <param name="results">
        /// Sync results by resource type
        /// </param>
        /// <param name="summary">
        /// Summary of the sync operation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishEnvironmentResponseDto(
            global::System.Collections.Generic.IList<global::Novu.SyncResultDto> results,
            global::Novu.PublishSummaryDto summary)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishEnvironmentResponseDto" /> class.
        /// </summary>
        public PublishEnvironmentResponseDto()
        {
        }
    }
}