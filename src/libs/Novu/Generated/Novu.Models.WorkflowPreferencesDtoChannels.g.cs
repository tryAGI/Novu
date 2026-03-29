
#nullable enable

namespace Novu
{
    /// <summary>
    /// Preferences for different communication channels<br/>
    /// Example: {"email":{"enabled":true},"sms":{"enabled":false}}
    /// </summary>
    public sealed partial class WorkflowPreferencesDtoChannels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}