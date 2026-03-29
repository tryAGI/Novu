
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SyncWorkflowDto
    {
        /// <summary>
        /// Target environment identifier to sync the workflow to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetEnvironmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetEnvironmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncWorkflowDto" /> class.
        /// </summary>
        /// <param name="targetEnvironmentId">
        /// Target environment identifier to sync the workflow to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncWorkflowDto(
            string targetEnvironmentId)
        {
            this.TargetEnvironmentId = targetEnvironmentId ?? throw new global::System.ArgumentNullException(nameof(targetEnvironmentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncWorkflowDto" /> class.
        /// </summary>
        public SyncWorkflowDto()
        {
        }
    }
}