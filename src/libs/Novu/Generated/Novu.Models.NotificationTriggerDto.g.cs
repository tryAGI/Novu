
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotificationTriggerDto
    {
        /// <summary>
        /// Type of the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter))]
        public global::Novu.NotificationTriggerDtoType Type { get; set; }

        /// <summary>
        /// Identifier of the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Variables of the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable> Variables { get; set; }

        /// <summary>
        /// Subscriber variables of the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberVariables")]
        public global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>? SubscriberVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTriggerDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Identifier of the trigger
        /// </param>
        /// <param name="variables">
        /// Variables of the trigger
        /// </param>
        /// <param name="type">
        /// Type of the trigger
        /// </param>
        /// <param name="subscriberVariables">
        /// Subscriber variables of the trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationTriggerDto(
            string identifier,
            global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable> variables,
            global::Novu.NotificationTriggerDtoType type,
            global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>? subscriberVariables)
        {
            this.Type = type;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.SubscriberVariables = subscriberVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTriggerDto" /> class.
        /// </summary>
        public NotificationTriggerDto()
        {
        }
    }
}