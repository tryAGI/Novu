
#nullable enable

namespace Novu
{
    /// <summary>
    /// Overrides the provider configuration for the entire workflow and all steps<br/>
    /// Example: {"sendgrid":{"templateId":"1234567890"}}
    /// </summary>
    public sealed partial class TriggerOverridesProviders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}