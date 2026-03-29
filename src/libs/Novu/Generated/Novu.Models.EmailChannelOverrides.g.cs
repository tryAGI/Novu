
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailChannelOverrides
    {
        /// <summary>
        /// Override or remove the layout for all email steps in the workflow<br/>
        /// Example: promotional-layout-2024
        /// </summary>
        /// <example>promotional-layout-2024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layoutId")]
        public string? LayoutId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailChannelOverrides" /> class.
        /// </summary>
        /// <param name="layoutId">
        /// Override or remove the layout for all email steps in the workflow<br/>
        /// Example: promotional-layout-2024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailChannelOverrides(
            string? layoutId)
        {
            this.LayoutId = layoutId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailChannelOverrides" /> class.
        /// </summary>
        public EmailChannelOverrides()
        {
        }
    }
}