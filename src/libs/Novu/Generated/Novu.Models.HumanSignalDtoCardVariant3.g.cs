
#nullable enable

namespace Novu
{
    /// <summary>
    /// Chat SDK Card element.<br/>
    /// Example: {"type":"card","title":"Refund $25?","children":[{"type":"button","id":"human:hr_1:approve","label":"OK","style":"primary"}]}
    /// </summary>
    public sealed partial class HumanSignalDtoCardVariant3
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}