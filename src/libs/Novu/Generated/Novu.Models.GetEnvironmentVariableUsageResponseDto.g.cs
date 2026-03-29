
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEnvironmentVariableUsageResponseDto
    {
        /// <summary>
        /// Array of workflows that reference this environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto> Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentVariableUsageResponseDto" /> class.
        /// </summary>
        /// <param name="workflows">
        /// Array of workflows that reference this environment variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEnvironmentVariableUsageResponseDto(
            global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto> workflows)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentVariableUsageResponseDto" /> class.
        /// </summary>
        public GetEnvironmentVariableUsageResponseDto()
        {
        }
    }
}