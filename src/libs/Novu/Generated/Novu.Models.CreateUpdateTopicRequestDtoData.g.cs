
#nullable enable

namespace Novu
{
    /// <summary>
    /// Additional custom data associated with the topic. Flat key-value pairs of scalars (string, number, boolean, string[]). Maximum size: 64KB.<br/>
    /// Example: {"category":"product","priority":1}
    /// </summary>
    public sealed partial class CreateUpdateTopicRequestDtoData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}