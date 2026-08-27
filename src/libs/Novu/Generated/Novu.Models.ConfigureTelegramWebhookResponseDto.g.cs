
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConfigureTelegramWebhookResponseDto
    {
        /// <summary>
        /// URL Novu registered with Telegram for incoming updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// ISO-8601 timestamp the webhook was configured at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfiguredAt { get; set; }

        /// <summary>
        /// Resolved bot username from getMe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botUsername")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTelegramWebhookResponseDto" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// URL Novu registered with Telegram for incoming updates
        /// </param>
        /// <param name="configuredAt">
        /// ISO-8601 timestamp the webhook was configured at
        /// </param>
        /// <param name="botUsername">
        /// Resolved bot username from getMe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureTelegramWebhookResponseDto(
            string webhookUrl,
            string configuredAt,
            string botUsername)
        {
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.ConfiguredAt = configuredAt ?? throw new global::System.ArgumentNullException(nameof(configuredAt));
            this.BotUsername = botUsername ?? throw new global::System.ArgumentNullException(nameof(botUsername));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTelegramWebhookResponseDto" /> class.
        /// </summary>
        public ConfigureTelegramWebhookResponseDto()
        {
        }

    }
}