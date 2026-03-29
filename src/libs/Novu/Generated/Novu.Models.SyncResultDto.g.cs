
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SyncResultDto
    {
        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Successfully synced resources
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto> Successful { get; set; }

        /// <summary>
        /// Failed resource syncs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto> Failed { get; set; }

        /// <summary>
        /// Skipped resources
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto> Skipped { get; set; }

        /// <summary>
        /// Total number of resources processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalProcessed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalProcessed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncResultDto" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the layout
        /// </param>
        /// <param name="successful">
        /// Successfully synced resources
        /// </param>
        /// <param name="failed">
        /// Failed resource syncs
        /// </param>
        /// <param name="skipped">
        /// Skipped resources
        /// </param>
        /// <param name="totalProcessed">
        /// Total number of resources processed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncResultDto(
            global::Novu.ResourceTypeEnum resourceType,
            global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto> successful,
            global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto> failed,
            global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto> skipped,
            double totalProcessed)
        {
            this.ResourceType = resourceType;
            this.Successful = successful ?? throw new global::System.ArgumentNullException(nameof(successful));
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
            this.Skipped = skipped ?? throw new global::System.ArgumentNullException(nameof(skipped));
            this.TotalProcessed = totalProcessed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncResultDto" /> class.
        /// </summary>
        public SyncResultDto()
        {
        }
    }
}