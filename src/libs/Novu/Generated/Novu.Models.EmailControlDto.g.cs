
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmailControlDto
    {
        /// <summary>
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </summary>
        /// <example>{"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public object? Skip { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// Body content of the email, either a valid Maily JSON object, or html string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Type of editor to use for the body.<br/>
        /// Default Value: block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter))]
        public global::Novu.EmailControlDtoEditorType? EditorType { get; set; }

        /// <summary>
        /// Disable sanitization of the output.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableOutputSanitization")]
        public bool? DisableOutputSanitization { get; set; }

        /// <summary>
        /// Layout ID to use for the email. Null means no layout, undefined means default layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layoutId")]
        public string? LayoutId { get; set; }

        /// <summary>
        /// Sender name and email overrides for this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public global::Novu.EmailFromControlDto? From { get; set; }

        /// <summary>
        /// When true, sender name/email use the primary email integration defaults and skip workflow agent defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useProviderDefaults")]
        public bool? UseProviderDefaults { get; set; }

        /// <summary>
        /// Step-level Reply-To override. When unset, inherits the workflow agent reply-to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replyTo")]
        public string? ReplyTo { get; set; }

        /// <summary>
        /// One-line inbox preview text shown next to the subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preheader")]
        public string? Preheader { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailControlDto" /> class.
        /// </summary>
        /// <param name="subject">
        /// Subject of the email.
        /// </param>
        /// <param name="body">
        /// Body content of the email, either a valid Maily JSON object, or html string.
        /// </param>
        /// <param name="skip">
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </param>
        /// <param name="editorType">
        /// Type of editor to use for the body.<br/>
        /// Default Value: block
        /// </param>
        /// <param name="disableOutputSanitization">
        /// Disable sanitization of the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="layoutId">
        /// Layout ID to use for the email. Null means no layout, undefined means default layout.
        /// </param>
        /// <param name="from">
        /// Sender name and email overrides for this step.
        /// </param>
        /// <param name="useProviderDefaults">
        /// When true, sender name/email use the primary email integration defaults and skip workflow agent defaults.
        /// </param>
        /// <param name="replyTo">
        /// Step-level Reply-To override. When unset, inherits the workflow agent reply-to.
        /// </param>
        /// <param name="preheader">
        /// One-line inbox preview text shown next to the subject.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailControlDto(
            string subject,
            string body,
            object? skip,
            global::Novu.EmailControlDtoEditorType? editorType,
            bool? disableOutputSanitization,
            string? layoutId,
            global::Novu.EmailFromControlDto? from,
            bool? useProviderDefaults,
            string? replyTo,
            string? preheader)
        {
            this.Skip = skip;
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.EditorType = editorType;
            this.DisableOutputSanitization = disableOutputSanitization;
            this.LayoutId = layoutId;
            this.From = from;
            this.UseProviderDefaults = useProviderDefaults;
            this.ReplyTo = replyTo;
            this.Preheader = preheader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailControlDto" /> class.
        /// </summary>
        public EmailControlDto()
        {
        }

    }
}