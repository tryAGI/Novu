
#nullable enable

namespace Novu
{
    /// <summary>
    /// The payload object is used to pass additional information that <br/>
    ///     could be used to render the template, or perform routing rules based on it. <br/>
    ///       For In-App channel, payload data are also available in &lt;Inbox /&gt;<br/>
    /// Example: {"comment_id":"string","post":{"text":"string"}}
    /// </summary>
    public sealed partial class TriggerEventToAllRequestDtoPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}