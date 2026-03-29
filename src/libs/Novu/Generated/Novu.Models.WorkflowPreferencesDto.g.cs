
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPreferencesDto
    {
        /// <summary>
        /// A preference for the workflow. The values specified here will be used if no preference is specified for a channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowPreferenceDto All { get; set; }

        /// <summary>
        /// Preferences for different communication channels<br/>
        /// Example: {"email":{"enabled":true},"sms":{"enabled":false}}
        /// </summary>
        /// <example>{"email":{"enabled":true},"sms":{"enabled":false}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto> Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferencesDto" /> class.
        /// </summary>
        /// <param name="all">
        /// A preference for the workflow. The values specified here will be used if no preference is specified for a channel.
        /// </param>
        /// <param name="channels">
        /// Preferences for different communication channels<br/>
        /// Example: {"email":{"enabled":true},"sms":{"enabled":false}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowPreferencesDto(
            global::Novu.WorkflowPreferenceDto all,
            global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto> channels)
        {
            this.All = all ?? throw new global::System.ArgumentNullException(nameof(all));
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferencesDto" /> class.
        /// </summary>
        public WorkflowPreferencesDto()
        {
        }
    }
}