
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentVariableWorkflowInfoDto
    {
        /// <summary>
        /// The name of the workflow<br/>
        /// Example: Welcome Email
        /// </summary>
        /// <example>Welcome Email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The unique identifier of the workflow<br/>
        /// Example: welcome-email
        /// </summary>
        /// <example>welcome-email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableWorkflowInfoDto" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the workflow<br/>
        /// Example: Welcome Email
        /// </param>
        /// <param name="workflowId">
        /// The unique identifier of the workflow<br/>
        /// Example: welcome-email
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentVariableWorkflowInfoDto(
            string name,
            string workflowId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableWorkflowInfoDto" /> class.
        /// </summary>
        public EnvironmentVariableWorkflowInfoDto()
        {
        }
    }
}