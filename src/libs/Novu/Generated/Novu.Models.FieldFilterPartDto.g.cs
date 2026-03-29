
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldFilterPartDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.FieldFilterPartDtoOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.FieldFilterPartDtoOn On { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterPartDto" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        /// <param name="on"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldFilterPartDto(
            string field,
            string value,
            global::Novu.FieldFilterPartDtoOperator @operator,
            global::Novu.FieldFilterPartDtoOn on)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Operator = @operator;
            this.On = on;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterPartDto" /> class.
        /// </summary>
        public FieldFilterPartDto()
        {
        }
    }
}