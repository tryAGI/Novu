
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppRenderOutput
    {
        /// <summary>
        /// Subject of the in-app notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Body of the in-app notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Avatar for the in-app notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Primary action details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryAction")]
        public global::Novu.ActionDto? PrimaryAction { get; set; }

        /// <summary>
        /// Secondary action details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryAction")]
        public global::Novu.ActionDto? SecondaryAction { get; set; }

        /// <summary>
        /// Additional data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Redirect details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Novu.RedirectDto? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppRenderOutput" /> class.
        /// </summary>
        /// <param name="body">
        /// Body of the in-app notification
        /// </param>
        /// <param name="subject">
        /// Subject of the in-app notification
        /// </param>
        /// <param name="avatar">
        /// Avatar for the in-app notification
        /// </param>
        /// <param name="primaryAction">
        /// Primary action details
        /// </param>
        /// <param name="secondaryAction">
        /// Secondary action details
        /// </param>
        /// <param name="data">
        /// Additional data
        /// </param>
        /// <param name="redirect">
        /// Redirect details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppRenderOutput(
            string body,
            string? subject,
            string? avatar,
            global::Novu.ActionDto? primaryAction,
            global::Novu.ActionDto? secondaryAction,
            object? data,
            global::Novu.RedirectDto? redirect)
        {
            this.Subject = subject;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Avatar = avatar;
            this.PrimaryAction = primaryAction;
            this.SecondaryAction = secondaryAction;
            this.Data = data;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppRenderOutput" /> class.
        /// </summary>
        public InAppRenderOutput()
        {
        }
    }
}