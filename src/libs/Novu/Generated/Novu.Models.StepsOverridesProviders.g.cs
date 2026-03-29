
#nullable enable

namespace Novu
{
    /// <summary>
    /// Passing the provider id and the provider specific configurations<br/>
    /// Example: {"sendgrid":{"templateId":"1234567890"}}
    /// </summary>
    public sealed partial class StepsOverridesProviders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}