
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishSummaryDto
    {
        /// <summary>
        /// Number of resources processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Resources { get; set; }

        /// <summary>
        /// Number of successful syncs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Successful { get; set; }

        /// <summary>
        /// Number of failed syncs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        /// Number of skipped resources
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Skipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishSummaryDto" /> class.
        /// </summary>
        /// <param name="resources">
        /// Number of resources processed
        /// </param>
        /// <param name="successful">
        /// Number of successful syncs
        /// </param>
        /// <param name="failed">
        /// Number of failed syncs
        /// </param>
        /// <param name="skipped">
        /// Number of skipped resources
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishSummaryDto(
            double resources,
            double successful,
            double failed,
            double skipped)
        {
            this.Resources = resources;
            this.Successful = successful;
            this.Failed = failed;
            this.Skipped = skipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishSummaryDto" /> class.
        /// </summary>
        public PublishSummaryDto()
        {
        }
    }
}