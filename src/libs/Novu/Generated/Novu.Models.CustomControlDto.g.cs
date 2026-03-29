
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomControlDto
    {
        /// <summary>
        /// Custom control values for the step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public object? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomControlDto" /> class.
        /// </summary>
        /// <param name="custom">
        /// Custom control values for the step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomControlDto(
            object? custom)
        {
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomControlDto" /> class.
        /// </summary>
        public CustomControlDto()
        {
        }
    }
}