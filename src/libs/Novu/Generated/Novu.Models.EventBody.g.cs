
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventBody
    {
        /// <summary>
        /// Status of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.EventBodyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.EventBodyStatus Status { get; set; }

        /// <summary>
        /// Date of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// External ID from the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Number of attempts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        public double? Attempts { get; set; }

        /// <summary>
        /// Response from the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public string? Response { get; set; }

        /// <summary>
        /// Raw content from the provider webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public string? Row { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBody" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the event
        /// </param>
        /// <param name="date">
        /// Date of the event
        /// </param>
        /// <param name="externalId">
        /// External ID from the provider
        /// </param>
        /// <param name="attempts">
        /// Number of attempts
        /// </param>
        /// <param name="response">
        /// Response from the provider
        /// </param>
        /// <param name="row">
        /// Raw content from the provider webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventBody(
            global::Novu.EventBodyStatus status,
            string date,
            string? externalId,
            double? attempts,
            string? response,
            string? row)
        {
            this.Status = status;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.ExternalId = externalId;
            this.Attempts = attempts;
            this.Response = response;
            this.Row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBody" /> class.
        /// </summary>
        public EventBody()
        {
        }
    }
}