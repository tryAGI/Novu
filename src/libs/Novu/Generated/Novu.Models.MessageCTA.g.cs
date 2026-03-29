
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageCTA
    {
        /// <summary>
        /// Type of call to action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter))]
        public global::Novu.ChannelCTATypeEnum? Type { get; set; }

        /// <summary>
        /// Data associated with the call to action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Novu.MessageCTAData? Data { get; set; }

        /// <summary>
        /// Action associated with the call to action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Novu.MessageAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCTA" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of call to action
        /// </param>
        /// <param name="data">
        /// Data associated with the call to action
        /// </param>
        /// <param name="action">
        /// Action associated with the call to action
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageCTA(
            global::Novu.ChannelCTATypeEnum? type,
            global::Novu.MessageCTAData? data,
            global::Novu.MessageAction? action)
        {
            this.Type = type;
            this.Data = data;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCTA" /> class.
        /// </summary>
        public MessageCTA()
        {
        }
    }
}