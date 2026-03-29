
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberPreferenceOverrideDto
    {
        /// <summary>
        /// Channel type through which the message is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ChannelTypeEnum Channel { get; set; }

        /// <summary>
        /// The source of overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferenceOverrideSourceEnum Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberPreferenceOverrideDto" /> class.
        /// </summary>
        /// <param name="channel">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="source">
        /// The source of overrides
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberPreferenceOverrideDto(
            global::Novu.ChannelTypeEnum channel,
            global::Novu.PreferenceOverrideSourceEnum source)
        {
            this.Channel = channel;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberPreferenceOverrideDto" /> class.
        /// </summary>
        public SubscriberPreferenceOverrideDto()
        {
        }
    }
}