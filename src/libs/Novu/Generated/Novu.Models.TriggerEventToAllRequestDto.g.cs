
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerEventToAllRequestDto
    {
        /// <summary>
        /// The trigger identifier associated for the template you wish to send. This identifier can be found on the template page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The payload object is used to pass additional information that <br/>
        ///     could be used to render the template, or perform routing rules based on it. <br/>
        ///       For In-App channel, payload data are also available in &lt;Inbox /&gt;<br/>
        /// Example: {"comment_id":"string","post":{"text":"string"}}
        /// </summary>
        /// <example>{"comment_id":"string","post":{"text":"string"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// This could be used to override provider specific configurations<br/>
        /// Example: {"fcm":{"data":{"key":"value"}}}
        /// </summary>
        /// <example>{"fcm":{"data":{"key":"value"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::Novu.TriggerOverrides? Overrides { get; set; }

        /// <summary>
        /// A unique identifier for this transaction, we will generated a UUID if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// It is used to display the Avatar of the provided actor's subscriber id or actor object.<br/>
        ///     If a new actor object is provided, we will create a new subscriber in our system<br/>
        ///     
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>))]
        public global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? Actor { get; set; }

        /// <summary>
        /// It is used to specify a tenant context during trigger event.<br/>
        ///     If a new tenant object is provided, we will create a new tenant.<br/>
        ///     
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>))]
        public global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventToAllRequestDto" /> class.
        /// </summary>
        /// <param name="name">
        /// The trigger identifier associated for the template you wish to send. This identifier can be found on the template page.
        /// </param>
        /// <param name="payload">
        /// The payload object is used to pass additional information that <br/>
        ///     could be used to render the template, or perform routing rules based on it. <br/>
        ///       For In-App channel, payload data are also available in &lt;Inbox /&gt;<br/>
        /// Example: {"comment_id":"string","post":{"text":"string"}}
        /// </param>
        /// <param name="overrides">
        /// This could be used to override provider specific configurations<br/>
        /// Example: {"fcm":{"data":{"key":"value"}}}
        /// </param>
        /// <param name="transactionId">
        /// A unique identifier for this transaction, we will generated a UUID if not provided.
        /// </param>
        /// <param name="actor">
        /// It is used to display the Avatar of the provided actor's subscriber id or actor object.<br/>
        ///     If a new actor object is provided, we will create a new subscriber in our system<br/>
        ///     
        /// </param>
        /// <param name="tenant">
        /// It is used to specify a tenant context during trigger event.<br/>
        ///     If a new tenant object is provided, we will create a new tenant.<br/>
        ///     
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerEventToAllRequestDto(
            string name,
            object payload,
            global::Novu.TriggerOverrides? overrides,
            string? transactionId,
            global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? actor,
            global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? tenant,
            object? context)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Overrides = overrides;
            this.TransactionId = transactionId;
            this.Actor = actor;
            this.Tenant = tenant;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventToAllRequestDto" /> class.
        /// </summary>
        public TriggerEventToAllRequestDto()
        {
        }
    }
}