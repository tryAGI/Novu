
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSkillInputDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AgentSkillInputDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.AgentSkillInputDtoType Type { get; set; }

        /// <summary>
        /// Skill identifier, e.g. "xlsx" or "skill_01XJ5..."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skillId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// Version to pin. Omit for latest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public object? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkillInputDto" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="skillId">
        /// Skill identifier, e.g. "xlsx" or "skill_01XJ5..."
        /// </param>
        /// <param name="version">
        /// Version to pin. Omit for latest.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSkillInputDto(
            global::Novu.AgentSkillInputDtoType type,
            string skillId,
            object? version)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkillInputDto" /> class.
        /// </summary>
        public AgentSkillInputDto()
        {
        }

    }
}