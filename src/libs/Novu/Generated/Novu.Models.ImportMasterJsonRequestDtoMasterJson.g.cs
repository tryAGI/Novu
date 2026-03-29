
#nullable enable

namespace Novu
{
    /// <summary>
    /// Master JSON object containing all translations organized by workflow identifier<br/>
    /// Example: {"workflows":{"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}}
    /// </summary>
    public sealed partial class ImportMasterJsonRequestDtoMasterJson
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}