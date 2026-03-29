
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMessageFailedDto
    {
        /// <summary>
        /// Current message state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Object { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MessageFailedErrorDto Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMessageFailedDto" /> class.
        /// </summary>
        /// <param name="object">
        /// Current message state
        /// </param>
        /// <param name="error">
        /// Error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMessageFailedDto(
            object @object,
            global::Novu.MessageFailedErrorDto error)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMessageFailedDto" /> class.
        /// </summary>
        public WebhookMessageFailedDto()
        {
        }
    }
}