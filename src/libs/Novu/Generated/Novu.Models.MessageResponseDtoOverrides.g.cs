
#nullable enable

namespace Novu
{
    /// <summary>
    /// Provider specific overrides used when triggering the notification
    /// </summary>
    public sealed partial class MessageResponseDtoOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}