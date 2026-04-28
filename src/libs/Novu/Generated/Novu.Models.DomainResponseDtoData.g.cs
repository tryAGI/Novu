
#nullable enable

namespace Novu
{
    /// <summary>
    /// String key-value metadata (max 10 keys, 500 characters total when set via API).
    /// </summary>
    public sealed partial class DomainResponseDtoData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}