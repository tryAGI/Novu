
#nullable enable

namespace Novu
{
    /// <summary>
    /// JSON-serializable value to store.<br/>
    /// Example: TCK-1001
    /// </summary>
    public sealed partial class MetadataSetSignalDtoValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}