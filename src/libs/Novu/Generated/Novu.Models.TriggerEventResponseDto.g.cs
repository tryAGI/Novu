
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerEventResponseDto
    {
        /// <summary>
        /// Indicates whether the trigger was acknowledged or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Acknowledged { get; set; }

        /// <summary>
        /// Status of the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TriggerEventResponseDtoStatus Status { get; set; }

        /// <summary>
        /// In case of an error, this field will contain the error message(s)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::System.Collections.Generic.IList<string>? Error { get; set; }

        /// <summary>
        /// The returned transaction ID of the trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Link to the activity feed for this trigger event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activityFeedLink")]
        public string? ActivityFeedLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobData")]
        public object? JobData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventResponseDto" /> class.
        /// </summary>
        /// <param name="acknowledged">
        /// Indicates whether the trigger was acknowledged or not
        /// </param>
        /// <param name="status">
        /// Status of the trigger
        /// </param>
        /// <param name="error">
        /// In case of an error, this field will contain the error message(s)
        /// </param>
        /// <param name="transactionId">
        /// The returned transaction ID of the trigger
        /// </param>
        /// <param name="activityFeedLink">
        /// Link to the activity feed for this trigger event
        /// </param>
        /// <param name="jobData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerEventResponseDto(
            bool acknowledged,
            global::Novu.TriggerEventResponseDtoStatus status,
            global::System.Collections.Generic.IList<string>? error,
            string? transactionId,
            string? activityFeedLink,
            object? jobData)
        {
            this.Acknowledged = acknowledged;
            this.Status = status;
            this.Error = error;
            this.TransactionId = transactionId;
            this.ActivityFeedLink = activityFeedLink;
            this.JobData = jobData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventResponseDto" /> class.
        /// </summary>
        public TriggerEventResponseDto()
        {
        }
    }
}