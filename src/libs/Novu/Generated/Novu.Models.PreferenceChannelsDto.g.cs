
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceChannelsDto
    {
        /// <summary>
        /// Whether email notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// Whether SMS notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms")]
        public bool? Sms { get; set; }

        /// <summary>
        /// Whether Inbox notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_app")]
        public bool? InApp { get; set; }

        /// <summary>
        /// Whether chat notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public bool? Chat { get; set; }

        /// <summary>
        /// Whether push notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        public bool? Push { get; set; }

        /// <summary>
        /// Whether tool notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        public bool? Tool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceChannelsDto" /> class.
        /// </summary>
        /// <param name="email">
        /// Whether email notifications are enabled
        /// </param>
        /// <param name="sms">
        /// Whether SMS notifications are enabled
        /// </param>
        /// <param name="inApp">
        /// Whether Inbox notifications are enabled
        /// </param>
        /// <param name="chat">
        /// Whether chat notifications are enabled
        /// </param>
        /// <param name="push">
        /// Whether push notifications are enabled
        /// </param>
        /// <param name="tool">
        /// Whether tool notifications are enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceChannelsDto(
            bool? email,
            bool? sms,
            bool? inApp,
            bool? chat,
            bool? push,
            bool? tool)
        {
            this.Email = email;
            this.Sms = sms;
            this.InApp = inApp;
            this.Chat = chat;
            this.Push = push;
            this.Tool = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceChannelsDto" /> class.
        /// </summary>
        public PreferenceChannelsDto()
        {
        }

    }
}