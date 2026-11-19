
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSubscriberTokenRequestDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Profile fields saved on the subscriber when the token is exchanged for an Inbox session. The subscriberId comes from the path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.BaseSubscriberFieldsDto? Subscriber { get; set; }

        /// <summary>
        /// Extra permissions granted to the session the token is exchanged for. Defaults to none.<br/>
        /// Example: [channels:shared]
        /// </summary>
        /// <example>[channels:shared]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::Novu.SubscriberTokenScopeEnum>? Scope { get; set; }

        /// <summary>
        /// Token lifetime in seconds, from 1 to 3600.<br/>
        /// Default Value: 3600<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresIn")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriberTokenRequestDto" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="subscriber">
        /// Profile fields saved on the subscriber when the token is exchanged for an Inbox session. The subscriberId comes from the path.
        /// </param>
        /// <param name="scope">
        /// Extra permissions granted to the session the token is exchanged for. Defaults to none.<br/>
        /// Example: [channels:shared]
        /// </param>
        /// <param name="expiresIn">
        /// Token lifetime in seconds, from 1 to 3600.<br/>
        /// Default Value: 3600<br/>
        /// Example: 600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubscriberTokenRequestDto(
            object? context,
            global::Novu.BaseSubscriberFieldsDto? subscriber,
            global::System.Collections.Generic.IList<global::Novu.SubscriberTokenScopeEnum>? scope,
            int? expiresIn)
        {
            this.Context = context;
            this.Subscriber = subscriber;
            this.Scope = scope;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriberTokenRequestDto" /> class.
        /// </summary>
        public CreateSubscriberTokenRequestDto()
        {
        }

    }
}