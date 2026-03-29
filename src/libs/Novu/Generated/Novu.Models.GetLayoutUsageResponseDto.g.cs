
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLayoutUsageResponseDto
    {
        /// <summary>
        /// Array of workflows that use this layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto> Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLayoutUsageResponseDto" /> class.
        /// </summary>
        /// <param name="workflows">
        /// Array of workflows that use this layout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLayoutUsageResponseDto(
            global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto> workflows)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLayoutUsageResponseDto" /> class.
        /// </summary>
        public GetLayoutUsageResponseDto()
        {
        }
    }
}