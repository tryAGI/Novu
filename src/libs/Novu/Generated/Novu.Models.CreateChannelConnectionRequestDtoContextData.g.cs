
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional additional context data<br/>
    /// Example: {"name":"Acme Corp","region":"us-east-1"}
    /// </summary>
    public sealed partial class CreateChannelConnectionRequestDtoContextData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}