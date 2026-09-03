
#nullable enable

namespace Novu
{
    /// <summary>
    /// JSONLogic used at send time to select this integration. Takes precedence over `conditions`.<br/>
    /// Example: {"==":[{"var":"context.tenant.id"},"acme"]}
    /// </summary>
    public sealed partial class UpdateIntegrationRequestDtoRules
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}