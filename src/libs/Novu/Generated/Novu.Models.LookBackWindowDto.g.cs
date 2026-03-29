
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LookBackWindowDto
    {
        /// <summary>
        /// Amount of time for the look-back window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Unit of time for the look-back window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.LookBackWindowDtoUnit Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookBackWindowDto" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount of time for the look-back window.
        /// </param>
        /// <param name="unit">
        /// Unit of time for the look-back window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LookBackWindowDto(
            double amount,
            global::Novu.LookBackWindowDtoUnit unit)
        {
            this.Amount = amount;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookBackWindowDto" /> class.
        /// </summary>
        public LookBackWindowDto()
        {
        }
    }
}