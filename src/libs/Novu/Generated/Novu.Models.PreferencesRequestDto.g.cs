
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreferencesRequestDto
    {
        /// <summary>
        /// User workflow preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Novu.WorkflowPreferencesDto? User { get; set; }

        /// <summary>
        /// Workflow-specific preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Novu.WorkflowPreferencesDto? Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferencesRequestDto" /> class.
        /// </summary>
        /// <param name="user">
        /// User workflow preferences
        /// </param>
        /// <param name="workflow">
        /// Workflow-specific preferences
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferencesRequestDto(
            global::Novu.WorkflowPreferencesDto? user,
            global::Novu.WorkflowPreferencesDto? workflow)
        {
            this.User = user;
            this.Workflow = workflow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferencesRequestDto" /> class.
        /// </summary>
        public PreferencesRequestDto()
        {
        }
    }
}