
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerOverrides
    {
        /// <summary>
        /// This could be used to override provider specific configurations or layout at the step level<br/>
        /// Example: {"email-step":{"providers":{"sendgrid":{"templateId":"1234567890"}},"layoutId":"step-specific-layout"}}
        /// </summary>
        /// <example>{"email-step":{"providers":{"sendgrid":{"templateId":"1234567890"}},"layoutId":"step-specific-layout"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.Dictionary<string, global::Novu.StepsOverrides>? Steps { get; set; }

        /// <summary>
        /// Channel-specific overrides that apply to all steps of a particular channel type. Step-level overrides take precedence over channel-level overrides.<br/>
        /// Example: {"email":{"layoutId":"promotional-layout-2024"}}
        /// </summary>
        /// <example>{"email":{"layoutId":"promotional-layout-2024"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::Novu.ChannelOverrides? Channels { get; set; }

        /// <summary>
        /// Overrides the provider configuration for the entire workflow and all steps<br/>
        /// Example: {"sendgrid":{"templateId":"1234567890"}}
        /// </summary>
        /// <example>{"sendgrid":{"templateId":"1234567890"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, object>? Providers { get; set; }

        /// <summary>
        /// Override the email provider specific configurations for the entire workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Email { get; set; }

        /// <summary>
        /// Override the push provider specific configurations for the entire workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Push { get; set; }

        /// <summary>
        /// Override the sms provider specific configurations for the entire workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Sms { get; set; }

        /// <summary>
        /// Override the chat provider specific configurations for the entire workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Chat { get; set; }

        /// <summary>
        /// Override the layout identifier for the entire workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layoutIdentifier")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? LayoutIdentifier { get; set; }

        /// <summary>
        /// Severity of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        public global::Novu.SeverityLevelEnum? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerOverrides" /> class.
        /// </summary>
        /// <param name="steps">
        /// This could be used to override provider specific configurations or layout at the step level<br/>
        /// Example: {"email-step":{"providers":{"sendgrid":{"templateId":"1234567890"}},"layoutId":"step-specific-layout"}}
        /// </param>
        /// <param name="channels">
        /// Channel-specific overrides that apply to all steps of a particular channel type. Step-level overrides take precedence over channel-level overrides.<br/>
        /// Example: {"email":{"layoutId":"promotional-layout-2024"}}
        /// </param>
        /// <param name="providers">
        /// Overrides the provider configuration for the entire workflow and all steps<br/>
        /// Example: {"sendgrid":{"templateId":"1234567890"}}
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerOverrides(
            global::System.Collections.Generic.Dictionary<string, global::Novu.StepsOverrides>? steps,
            global::Novu.ChannelOverrides? channels,
            global::System.Collections.Generic.Dictionary<string, object>? providers,
            global::Novu.SeverityLevelEnum? severity)
        {
            this.Steps = steps;
            this.Channels = channels;
            this.Providers = providers;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerOverrides" /> class.
        /// </summary>
        public TriggerOverrides()
        {
        }
    }
}