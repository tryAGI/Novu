
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTopicSubscriptionsResponseDto
    {
        /// <summary>
        /// The list of successfully deleted subscriptions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SubscriptionDto> Data { get; set; }

        /// <summary>
        /// Metadata about the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MetaDto Meta { get; set; }

        /// <summary>
        /// The list of errors for failed deletion attempts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicSubscriptionsResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of successfully deleted subscriptions
        /// </param>
        /// <param name="meta">
        /// Metadata about the operation
        /// </param>
        /// <param name="errors">
        /// The list of errors for failed deletion attempts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTopicSubscriptionsResponseDto(
            global::System.Collections.Generic.IList<global::Novu.SubscriptionDto> data,
            global::Novu.MetaDto meta,
            global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? errors)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicSubscriptionsResponseDto" /> class.
        /// </summary>
        public DeleteTopicSubscriptionsResponseDto()
        {
        }
    }
}