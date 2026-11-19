
#nullable enable

namespace Novu
{
    /// <summary>
    /// JSON Logic rule evaluated over subscriber.* and context.* when subscriberAccess is "rule". Present only when subscriberAccess is "rule". A missing field evaluates as JSON Logic says, so `null` is less than any positive number. "==" and "!=" compare strictly, without type coercion. At most 16 KB, with objects and arrays nested at most 32 levels deep.<br/>
    /// Example: {"in":[{"var":"context.tenant.data.plan"},["pro","enterprise"]]}
    /// </summary>
    public sealed partial class AgentBehaviorDtoAccessRule
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}