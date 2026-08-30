
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HumanSignalDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.HumanSignalDtoTypeJsonConverter))]
        public global::Novu.HumanSignalDtoType Type { get; set; }

        /// <summary>
        /// Interaction verb queued by `ctx.ask` / `ctx.approve` / `ctx.choose` / `ctx.tell`.<br/>
        /// Example: approve
        /// </summary>
        /// <example>approve</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.HumanSignalDtoKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.HumanSignalDtoKind Kind { get; set; }

        /// <summary>
        /// Question, action description, or one-way message shown to the human.<br/>
        /// Example: Deploy v2.4.1 to production?
        /// </summary>
        /// <example>Deploy v2.4.1 to production?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Client-minted id returned by the framework helper; echoed on `ctx.humanResponse.requestId`.<br/>
        /// Example: hr_7c2e1a3b-4d5f-6789-abcd-ef0123456789
        /// </summary>
        /// <example>hr_7c2e1a3b-4d5f-6789-abcd-ef0123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Choice labels — required for `choose`, ignored otherwise.<br/>
        /// Example: [us-east, eu-west]
        /// </summary>
        /// <example>[us-east, eu-west]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// Attribution label rendered in the card.<br/>
        /// Example: deploy-bot
        /// </summary>
        /// <example>deploy-bot</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Seconds until the interaction expires. Default 86400 (24h), max 259200.<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttlSeconds")]
        public double? TtlSeconds { get; set; }

        /// <summary>
        /// Novu subscriberId(s) allowed to settle this interaction (max 50). First valid answer wins. When omitted, the conversation subscriber is used. Subscriber ids only — not workflow topic recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanSignalDto" /> class.
        /// </summary>
        /// <param name="kind">
        /// Interaction verb queued by `ctx.ask` / `ctx.approve` / `ctx.choose` / `ctx.tell`.<br/>
        /// Example: approve
        /// </param>
        /// <param name="prompt">
        /// Question, action description, or one-way message shown to the human.<br/>
        /// Example: Deploy v2.4.1 to production?
        /// </param>
        /// <param name="requestId">
        /// Client-minted id returned by the framework helper; echoed on `ctx.humanResponse.requestId`.<br/>
        /// Example: hr_7c2e1a3b-4d5f-6789-abcd-ef0123456789
        /// </param>
        /// <param name="type"></param>
        /// <param name="options">
        /// Choice labels — required for `choose`, ignored otherwise.<br/>
        /// Example: [us-east, eu-west]
        /// </param>
        /// <param name="from">
        /// Attribution label rendered in the card.<br/>
        /// Example: deploy-bot
        /// </param>
        /// <param name="ttlSeconds">
        /// Seconds until the interaction expires. Default 86400 (24h), max 259200.<br/>
        /// Example: 3600
        /// </param>
        /// <param name="to">
        /// Novu subscriberId(s) allowed to settle this interaction (max 50). First valid answer wins. When omitted, the conversation subscriber is used. Subscriber ids only — not workflow topic recipients.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HumanSignalDto(
            global::Novu.HumanSignalDtoKind kind,
            string prompt,
            string requestId,
            global::Novu.HumanSignalDtoType type,
            global::System.Collections.Generic.IList<string>? options,
            string? from,
            double? ttlSeconds,
            global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? to)
        {
            this.Type = type;
            this.Kind = kind;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Options = options;
            this.From = from;
            this.TtlSeconds = ttlSeconds;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanSignalDto" /> class.
        /// </summary>
        public HumanSignalDto()
        {
        }

    }
}