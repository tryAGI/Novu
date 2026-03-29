
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListLayoutResponseDto
    {
        /// <summary>
        /// List of layouts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto> Layouts { get; set; }

        /// <summary>
        /// Total number of layouts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLayoutResponseDto" /> class.
        /// </summary>
        /// <param name="layouts">
        /// List of layouts
        /// </param>
        /// <param name="totalCount">
        /// Total number of layouts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLayoutResponseDto(
            global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto> layouts,
            double totalCount)
        {
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLayoutResponseDto" /> class.
        /// </summary>
        public ListLayoutResponseDto()
        {
        }
    }
}