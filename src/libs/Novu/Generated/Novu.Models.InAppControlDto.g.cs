
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppControlDto
    {
        /// <summary>
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </summary>
        /// <example>{"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public object? Skip { get; set; }

        /// <summary>
        /// Content/body of the in-app message. Required if subject is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Subject/title of the in-app message. Required if body is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// URL for an avatar image. Must be a valid URL or start with / or {{ variable }}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Primary action button details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryAction")]
        public global::Novu.ActionDto? PrimaryAction { get; set; }

        /// <summary>
        /// Secondary action button details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryAction")]
        public global::Novu.ActionDto? SecondaryAction { get; set; }

        /// <summary>
        /// Redirection URL configuration for the main content click (if no actions defined/clicked)..
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Novu.RedirectDto? Redirect { get; set; }

        /// <summary>
        /// Disable sanitization of the output.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableOutputSanitization")]
        public bool? DisableOutputSanitization { get; set; }

        /// <summary>
        /// Additional data payload for the step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppControlDto" /> class.
        /// </summary>
        /// <param name="skip">
        /// JSONLogic filter conditions for conditionally skipping the step execution. Supports complex logical operations with AND, OR, and comparison operators. See https://jsonlogic.com/ for full typing reference.<br/>
        /// Example: {"and":[{"==":[{"var":"payload.tier"},"pro"]},{"==":[{"var":"subscriber.data.role"},"admin"]},{"\u003E":[{"var":"payload.amount"},"4"]}]}
        /// </param>
        /// <param name="body">
        /// Content/body of the in-app message. Required if subject is empty.
        /// </param>
        /// <param name="subject">
        /// Subject/title of the in-app message. Required if body is empty.
        /// </param>
        /// <param name="avatar">
        /// URL for an avatar image. Must be a valid URL or start with / or {{ variable }}.
        /// </param>
        /// <param name="primaryAction">
        /// Primary action button details.
        /// </param>
        /// <param name="secondaryAction">
        /// Secondary action button details.
        /// </param>
        /// <param name="redirect">
        /// Redirection URL configuration for the main content click (if no actions defined/clicked)..
        /// </param>
        /// <param name="disableOutputSanitization">
        /// Disable sanitization of the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data">
        /// Additional data payload for the step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppControlDto(
            object? skip,
            string? body,
            string? subject,
            string? avatar,
            global::Novu.ActionDto? primaryAction,
            global::Novu.ActionDto? secondaryAction,
            global::Novu.RedirectDto? redirect,
            bool? disableOutputSanitization,
            object? data)
        {
            this.Skip = skip;
            this.Body = body;
            this.Subject = subject;
            this.Avatar = avatar;
            this.PrimaryAction = primaryAction;
            this.SecondaryAction = secondaryAction;
            this.Redirect = redirect;
            this.DisableOutputSanitization = disableOutputSanitization;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppControlDto" /> class.
        /// </summary>
        public InAppControlDto()
        {
        }
    }
}