
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchPreferenceChannelsDto
    {
        /// <summary>
        /// Email channel preference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// SMS channel preference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms")]
        public bool? Sms { get; set; }

        /// <summary>
        /// In-app channel preference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_app")]
        public bool? InApp { get; set; }

        /// <summary>
        /// Push channel preference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        public bool? Push { get; set; }

        /// <summary>
        /// Chat channel preference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public bool? Chat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPreferenceChannelsDto" /> class.
        /// </summary>
        /// <param name="email">
        /// Email channel preference
        /// </param>
        /// <param name="sms">
        /// SMS channel preference
        /// </param>
        /// <param name="inApp">
        /// In-app channel preference
        /// </param>
        /// <param name="push">
        /// Push channel preference
        /// </param>
        /// <param name="chat">
        /// Chat channel preference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchPreferenceChannelsDto(
            bool? email,
            bool? sms,
            bool? inApp,
            bool? push,
            bool? chat)
        {
            this.Email = email;
            this.Sms = sms;
            this.InApp = inApp;
            this.Push = push;
            this.Chat = chat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPreferenceChannelsDto" /> class.
        /// </summary>
        public PatchPreferenceChannelsDto()
        {
        }
    }
}