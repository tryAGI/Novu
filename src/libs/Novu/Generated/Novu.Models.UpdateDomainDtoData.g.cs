
#nullable enable

namespace Novu
{
    /// <summary>
    /// Replaces domain metadata when provided (max 10 keys, 500 characters total for keys+values).
    /// </summary>
    public sealed partial class UpdateDomainDtoData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}