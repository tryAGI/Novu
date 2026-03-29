
#nullable enable

namespace Novu
{
    /// <summary>
    /// Custom data to associate with this context. Replaces existing data.<br/>
    /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
    /// </summary>
    public sealed partial class UpdateContextRequestDtoData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}