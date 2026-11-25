
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoConfigureIntegrationResponseDto
    {
        /// <summary>
        /// Indicates whether the auto-configuration was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Optional message describing the result or any errors that occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The updated configurations after auto-configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        public object? Integration { get; set; }

        /// <summary>
        /// The URL the provider sends delivery events to. Set it in the provider yourself when auto-configuration fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoConfigureIntegrationResponseDto" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates whether the auto-configuration was successful
        /// </param>
        /// <param name="message">
        /// Optional message describing the result or any errors that occurred
        /// </param>
        /// <param name="integration">
        /// The updated configurations after auto-configuration
        /// </param>
        /// <param name="webhookUrl">
        /// The URL the provider sends delivery events to. Set it in the provider yourself when auto-configuration fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoConfigureIntegrationResponseDto(
            bool success,
            string? message,
            object? integration,
            string? webhookUrl)
        {
            this.Success = success;
            this.Message = message;
            this.Integration = integration;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoConfigureIntegrationResponseDto" /> class.
        /// </summary>
        public AutoConfigureIntegrationResponseDto()
        {
        }

    }
}