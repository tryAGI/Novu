
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepIssuesDto
    {
        /// <summary>
        /// Controls-related issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Controls { get; set; }

        /// <summary>
        /// Integration-related issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepIssuesDto" /> class.
        /// </summary>
        /// <param name="controls">
        /// Controls-related issues
        /// </param>
        /// <param name="integration">
        /// Integration-related issues
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepIssuesDto(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? controls,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? integration)
        {
            this.Controls = controls;
            this.Integration = integration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepIssuesDto" /> class.
        /// </summary>
        public StepIssuesDto()
        {
        }
    }
}