
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutControlValuesDto
    {
        /// <summary>
        /// Email layout controls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public global::Novu.EmailControlsDto? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutControlValuesDto" /> class.
        /// </summary>
        /// <param name="email">
        /// Email layout controls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutControlValuesDto(
            global::Novu.EmailControlsDto? email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutControlValuesDto" /> class.
        /// </summary>
        public LayoutControlValuesDto()
        {
        }
    }
}