
#nullable enable

namespace Novu
{
    /// <summary>
    /// Translation content as JSON object<br/>
    /// Example: {"welcome.title":"Welcome","welcome.message":"Hello there!"}
    /// </summary>
    public sealed partial class TranslationResponseDtoContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}