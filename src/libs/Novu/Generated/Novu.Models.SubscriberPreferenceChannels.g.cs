
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberPreferenceChannels
    {
        /// <summary>
        /// Email channel preference<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// SMS channel preference<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms")]
        public bool? Sms { get; set; }

        /// <summary>
        /// In-app channel preference<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_app")]
        public bool? InApp { get; set; }

        /// <summary>
        /// Chat channel preference<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public bool? Chat { get; set; }

        /// <summary>
        /// Push notification channel preference<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        public bool? Push { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberPreferenceChannels" /> class.
        /// </summary>
        /// <param name="email">
        /// Email channel preference<br/>
        /// Example: true
        /// </param>
        /// <param name="sms">
        /// SMS channel preference<br/>
        /// Example: false
        /// </param>
        /// <param name="inApp">
        /// In-app channel preference<br/>
        /// Example: true
        /// </param>
        /// <param name="chat">
        /// Chat channel preference<br/>
        /// Example: false
        /// </param>
        /// <param name="push">
        /// Push notification channel preference<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberPreferenceChannels(
            bool? email,
            bool? sms,
            bool? inApp,
            bool? chat,
            bool? push)
        {
            this.Email = email;
            this.Sms = sms;
            this.InApp = inApp;
            this.Chat = chat;
            this.Push = push;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberPreferenceChannels" /> class.
        /// </summary>
        public SubscriberPreferenceChannels()
        {
        }
    }
}