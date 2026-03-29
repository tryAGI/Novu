
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional custom data to associate with this context.<br/>
    /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
    /// </summary>
    public sealed partial class CreateContextRequestDtoData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}