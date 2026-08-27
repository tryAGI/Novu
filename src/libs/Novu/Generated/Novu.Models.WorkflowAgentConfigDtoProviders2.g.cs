
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowAgentConfigDtoProviders2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replyTo")]
        public string? ReplyTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAgentConfigDtoProviders2" /> class.
        /// </summary>
        /// <param name="replyTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowAgentConfigDtoProviders2(
            string? replyTo)
        {
            this.ReplyTo = replyTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAgentConfigDtoProviders2" /> class.
        /// </summary>
        public WorkflowAgentConfigDtoProviders2()
        {
        }

    }
}