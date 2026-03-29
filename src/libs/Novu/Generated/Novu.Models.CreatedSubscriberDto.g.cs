
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatedSubscriberDto
    {
        /// <summary>
        /// The ID of the subscriber that was created.
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
        /// Initializes a new instance of the <see cref="CreatedSubscriberDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// The ID of the subscriber that was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatedSubscriberDto(
            string subscriberId)
        {
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedSubscriberDto" /> class.
        /// </summary>
        public CreatedSubscriberDto()
        {
        }
    }
}