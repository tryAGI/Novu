
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStepUpsertDto
    {
        /// <summary>
        /// Database identifier of the step. Used for updating the step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique identifier for the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepId")]
        public string? StepId { get; set; }

        /// <summary>
        /// Name of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.StepTypeEnum Type { get; set; }

        /// <summary>
        /// Control values for the Chat step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlValues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>))]
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? ControlValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStepUpsertDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the step
        /// </param>
        /// <param name="type">
        /// Type of the step
        /// </param>
        /// <param name="id">
        /// Database identifier of the step. Used for updating the step.
        /// </param>
        /// <param name="stepId">
        /// Unique identifier for the step
        /// </param>
        /// <param name="controlValues">
        /// Control values for the Chat step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStepUpsertDto(
            string name,
            global::Novu.StepTypeEnum type,
            string? id,
            string? stepId,
            global::Novu.OneOf<global::Novu.ChatControlDto, object>? controlValues)
        {
            this.Id = id;
            this.StepId = stepId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.ControlValues = controlValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStepUpsertDto" /> class.
        /// </summary>
        public ChatStepUpsertDto()
        {
        }
    }
}