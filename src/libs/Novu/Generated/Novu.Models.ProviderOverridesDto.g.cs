
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderOverridesDto
    {
        /// <summary>
        /// PagerDuty content overrides. Merged over the default step body at send time. Supported keys are documented in the PagerDuty override schema.<br/>
        /// Example: {"severity":"warning","source":"novu","summary":"{{payload.title}}"}
        /// </summary>
        /// <example>{"severity":"warning","source":"novu","summary":"{{payload.title}}"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagerduty")]
        public object? Pagerduty { get; set; }

        /// <summary>
        /// Opsgenie content overrides. Merged over the default step body at send time. Supported keys are documented in the Opsgenie override schema.<br/>
        /// Example: {"priority":"P2","message":"{{payload.title}}"}
        /// </summary>
        /// <example>{"priority":"P2","message":"{{payload.title}}"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opsgenie")]
        public object? Opsgenie { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderOverridesDto" /> class.
        /// </summary>
        /// <param name="pagerduty">
        /// PagerDuty content overrides. Merged over the default step body at send time. Supported keys are documented in the PagerDuty override schema.<br/>
        /// Example: {"severity":"warning","source":"novu","summary":"{{payload.title}}"}
        /// </param>
        /// <param name="opsgenie">
        /// Opsgenie content overrides. Merged over the default step body at send time. Supported keys are documented in the Opsgenie override schema.<br/>
        /// Example: {"priority":"P2","message":"{{payload.title}}"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderOverridesDto(
            object? pagerduty,
            object? opsgenie)
        {
            this.Pagerduty = pagerduty;
            this.Opsgenie = opsgenie;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderOverridesDto" /> class.
        /// </summary>
        public ProviderOverridesDto()
        {
        }

    }
}