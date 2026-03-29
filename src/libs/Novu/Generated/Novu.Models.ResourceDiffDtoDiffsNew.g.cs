
#nullable enable

namespace Novu
{
    /// <summary>
    /// New state of the resource (null for deleted resources)
    /// </summary>
    public sealed partial class ResourceDiffDtoDiffsNew
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}