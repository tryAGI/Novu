
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupPreferenceFilterDetailsDto
    {
        /// <summary>
        /// List of workflow identifiers<br/>
        /// Example: [workflow-1, workflow-2]
        /// </summary>
        /// <example>[workflow-1, workflow-2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowIds")]
        public global::System.Collections.Generic.IList<string>? WorkflowIds { get; set; }

        /// <summary>
        /// List of tags<br/>
        /// Example: [tag1, tag2]
        /// </summary>
        /// <example>[tag1, tag2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPreferenceFilterDetailsDto" /> class.
        /// </summary>
        /// <param name="workflowIds">
        /// List of workflow identifiers<br/>
        /// Example: [workflow-1, workflow-2]
        /// </param>
        /// <param name="tags">
        /// List of tags<br/>
        /// Example: [tag1, tag2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupPreferenceFilterDetailsDto(
            global::System.Collections.Generic.IList<string>? workflowIds,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.WorkflowIds = workflowIds;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPreferenceFilterDetailsDto" /> class.
        /// </summary>
        public GroupPreferenceFilterDetailsDto()
        {
        }
    }
}