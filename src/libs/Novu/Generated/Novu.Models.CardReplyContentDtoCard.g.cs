
#nullable enable

namespace Novu
{
    /// <summary>
    /// Interactive card as a Chat SDK element tree (`type: "card"`). Prefer building with `@novu/framework` Card helpers when using TypeScript.<br/>
    /// Example: {"type":"card","title":"Order #123","children":[{"type":"text","content":"Your order is ready for pickup."},{"type":"button","id":"confirm","label":"Confirm","style":"primary"}]}
    /// </summary>
    public sealed partial class CardReplyContentDtoCard
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}