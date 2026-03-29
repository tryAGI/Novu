
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepListResponseDto
    {
        /// <summary>
        /// Slug of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Type of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.StepTypeEnum Type { get; set; }

        /// <summary>
        /// Issues associated with the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::Novu.StepIssuesDto? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepListResponseDto" /> class.
        /// </summary>
        /// <param name="slug">
        /// Slug of the step
        /// </param>
        /// <param name="type">
        /// Type of the step
        /// </param>
        /// <param name="issues">
        /// Issues associated with the step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepListResponseDto(
            string slug,
            global::Novu.StepTypeEnum type,
            global::Novu.StepIssuesDto? issues)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Type = type;
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepListResponseDto" /> class.
        /// </summary>
        public StepListResponseDto()
        {
        }
    }
}