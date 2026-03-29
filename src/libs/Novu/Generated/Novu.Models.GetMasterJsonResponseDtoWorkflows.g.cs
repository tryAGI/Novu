
#nullable enable

namespace Novu
{
    /// <summary>
    /// All translations for given locale organized by workflow identifier<br/>
    /// Example: {"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}
    /// </summary>
    public sealed partial class GetMasterJsonResponseDtoWorkflows
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}