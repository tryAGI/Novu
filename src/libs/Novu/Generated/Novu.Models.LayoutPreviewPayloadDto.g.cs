
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutPreviewPayloadDto
    {
        /// <summary>
        /// Partial subscriber information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.SubscriberResponseDtoOptional? Subscriber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutPreviewPayloadDto" /> class.
        /// </summary>
        /// <param name="subscriber">
        /// Partial subscriber information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutPreviewPayloadDto(
            global::Novu.SubscriberResponseDtoOptional? subscriber)
        {
            this.Subscriber = subscriber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutPreviewPayloadDto" /> class.
        /// </summary>
        public LayoutPreviewPayloadDto()
        {
        }
    }
}