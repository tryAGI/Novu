
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSubscriptionsResponseDto
    {
        /// <summary>
        /// The list of successfully created subscriptions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto> Data { get; set; }

        /// <summary>
        /// Metadata about the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.MetaDto Meta { get; set; }

        /// <summary>
        /// The list of errors for failed subscription attempts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionsResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of successfully created subscriptions
        /// </param>
        /// <param name="meta">
        /// Metadata about the operation
        /// </param>
        /// <param name="errors">
        /// The list of errors for failed subscription attempts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubscriptionsResponseDto(
            global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto> data,
            global::Novu.MetaDto meta,
            global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? errors)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionsResponseDto" /> class.
        /// </summary>
        public CreateSubscriptionsResponseDto()
        {
        }
    }
}