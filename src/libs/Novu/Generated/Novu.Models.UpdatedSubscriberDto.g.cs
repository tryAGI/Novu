
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatedSubscriberDto
    {
        /// <summary>
        /// The ID of the subscriber that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedSubscriberDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// The ID of the subscriber that was updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatedSubscriberDto(
            string subscriberId)
        {
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedSubscriberDto" /> class.
        /// </summary>
        public UpdatedSubscriberDto()
        {
        }
    }
}