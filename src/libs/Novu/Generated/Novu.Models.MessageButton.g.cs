
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageButton
    {
        /// <summary>
        /// Type of button for the action result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ButtonTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ButtonTypeEnum Type { get; set; }

        /// <summary>
        /// Content of the button
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Content of the result when the button is clicked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultContent")]
        public string? ResultContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageButton" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of button for the action result
        /// </param>
        /// <param name="content">
        /// Content of the button
        /// </param>
        /// <param name="resultContent">
        /// Content of the result when the button is clicked
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageButton(
            global::Novu.ButtonTypeEnum type,
            string content,
            string? resultContent)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ResultContent = resultContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageButton" /> class.
        /// </summary>
        public MessageButton()
        {
        }
    }
}