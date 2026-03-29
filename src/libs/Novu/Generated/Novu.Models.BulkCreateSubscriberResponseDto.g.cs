
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkCreateSubscriberResponseDto
    {
        /// <summary>
        /// An array of subscribers that were successfully updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto> Updated { get; set; }

        /// <summary>
        /// An array of subscribers that were successfully created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto> Created { get; set; }

        /// <summary>
        /// An array of failed operations with error messages and optional subscriber IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.FailedOperationDto> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateSubscriberResponseDto" /> class.
        /// </summary>
        /// <param name="updated">
        /// An array of subscribers that were successfully updated.
        /// </param>
        /// <param name="created">
        /// An array of subscribers that were successfully created.
        /// </param>
        /// <param name="failed">
        /// An array of failed operations with error messages and optional subscriber IDs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkCreateSubscriberResponseDto(
            global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto> updated,
            global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto> created,
            global::System.Collections.Generic.IList<global::Novu.FailedOperationDto> failed)
        {
            this.Updated = updated ?? throw new global::System.ArgumentNullException(nameof(updated));
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateSubscriberResponseDto" /> class.
        /// </summary>
        public BulkCreateSubscriberResponseDto()
        {
        }
    }
}