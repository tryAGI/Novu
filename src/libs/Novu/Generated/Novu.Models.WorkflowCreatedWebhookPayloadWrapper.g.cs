
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowCreatedWebhookPayloadWrapper
    {
        /// <summary>
        /// Unique identifier of the webhook event (evt_✱).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of the webhook event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowCreatedWebhookPayloadWrapperTypeJsonConverter))]
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowCreatedWebhookPayloadDto Data { get; set; }

        /// <summary>
        /// ISO timestamp of when the event occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The identifier of the environment associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// The type of object the event relates to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowCreatedWebhookPayloadWrapperObjectJsonConverter))]
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCreatedWebhookPayloadWrapper" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the webhook event (evt_✱).
        /// </param>
        /// <param name="data"></param>
        /// <param name="timestamp">
        /// ISO timestamp of when the event occurred.
        /// </param>
        /// <param name="environmentId">
        /// The identifier of the environment associated with the event.
        /// </param>
        /// <param name="type">
        /// The type of the webhook event.
        /// </param>
        /// <param name="object">
        /// The type of object the event relates to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowCreatedWebhookPayloadWrapper(
            string id,
            global::Novu.WorkflowCreatedWebhookPayloadDto data,
            global::System.DateTime timestamp,
            string environmentId,
            global::Novu.WorkflowCreatedWebhookPayloadWrapperType type,
            global::Novu.WorkflowCreatedWebhookPayloadWrapperObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Timestamp = timestamp;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCreatedWebhookPayloadWrapper" /> class.
        /// </summary>
        public WorkflowCreatedWebhookPayloadWrapper()
        {
        }

    }
}