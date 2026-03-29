
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkSubscriberCreateDto
    {
        /// <summary>
        /// An array of subscribers to be created in bulk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto> Subscribers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSubscriberCreateDto" /> class.
        /// </summary>
        /// <param name="subscribers">
        /// An array of subscribers to be created in bulk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkSubscriberCreateDto(
            global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto> subscribers)
        {
            this.Subscribers = subscribers ?? throw new global::System.ArgumentNullException(nameof(subscribers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSubscriberCreateDto" /> class.
        /// </summary>
        public BulkSubscriberCreateDto()
        {
        }
    }
}