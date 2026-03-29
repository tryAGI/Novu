
#nullable enable

namespace Novu
{
    /// <summary>
    /// This could be used to override provider specific configurations or layout at the step level<br/>
    /// Example: {"email-step":{"providers":{"sendgrid":{"templateId":"1234567890"}},"layoutId":"step-specific-layout"}}
    /// </summary>
    public sealed partial class TriggerOverridesSteps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}