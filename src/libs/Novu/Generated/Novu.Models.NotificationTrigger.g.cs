
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotificationTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter))]
        public global::Novu.NotificationTriggerType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable> Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberVariables")]
        public global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>? SubscriberVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTrigger" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="variables"></param>
        /// <param name="type"></param>
        /// <param name="subscriberVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationTrigger(
            string identifier,
            global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable> variables,
            global::Novu.NotificationTriggerType type,
            global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>? subscriberVariables)
        {
            this.Type = type;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.SubscriberVariables = subscriberVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTrigger" /> class.
        /// </summary>
        public NotificationTrigger()
        {
        }
    }
}