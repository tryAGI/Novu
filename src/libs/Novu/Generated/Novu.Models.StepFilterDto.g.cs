
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepFilterDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNegated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNegated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.BuilderFieldTypeEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepFilterDtoValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.StepFilterDtoValue Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.FieldFilterPartDto> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepFilterDto" /> class.
        /// </summary>
        /// <param name="isNegated"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="children"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepFilterDto(
            bool isNegated,
            global::Novu.BuilderFieldTypeEnum type,
            global::Novu.StepFilterDtoValue value,
            global::System.Collections.Generic.IList<global::Novu.FieldFilterPartDto> children)
        {
            this.IsNegated = isNegated;
            this.Type = type;
            this.Value = value;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepFilterDto" /> class.
        /// </summary>
        public StepFilterDto()
        {
        }
    }
}