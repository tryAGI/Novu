
#nullable enable

namespace Novu
{
    /// <summary>
    /// The payload object is used to pass additional custom information that could be <br/>
    ///     used to render the workflow, or perform routing rules based on it. <br/>
    ///       This data will also be available when fetching the notifications feed from the API to display certain parts of the UI.<br/>
    /// Example: {"comment_id":"string","post":{"text":"string"}}
    /// </summary>
    public sealed partial class TriggerEventRequestDtoPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}