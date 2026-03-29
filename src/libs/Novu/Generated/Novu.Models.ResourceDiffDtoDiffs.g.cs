
#nullable enable

namespace Novu
{
    /// <summary>
    /// Detailed changes (only for modified resources)
    /// </summary>
    public sealed partial class ResourceDiffDtoDiffs
    {
        /// <summary>
        /// Previous state of the resource (null for added resources)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public object? Previous { get; set; }

        /// <summary>
        /// New state of the resource (null for deleted resources)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new")]
        public object? New { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDiffDtoDiffs" /> class.
        /// </summary>
        /// <param name="previous">
        /// Previous state of the resource (null for added resources)
        /// </param>
        /// <param name="new">
        /// New state of the resource (null for deleted resources)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceDiffDtoDiffs(
            object? previous,
            object? @new)
        {
            this.Previous = previous;
            this.New = @new;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDiffDtoDiffs" /> class.
        /// </summary>
        public ResourceDiffDtoDiffs()
        {
        }
    }
}