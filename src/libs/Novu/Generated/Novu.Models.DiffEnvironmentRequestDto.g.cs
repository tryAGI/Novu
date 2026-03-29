
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiffEnvironmentRequestDto
    {
        /// <summary>
        /// Source environment ID to compare from. Defaults to the Development environment if not provided.<br/>
        /// Example: 507f1f77bcf86cd799439011
        /// </summary>
        /// <example>507f1f77bcf86cd799439011</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceEnvironmentId")]
        public string? SourceEnvironmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffEnvironmentRequestDto" /> class.
        /// </summary>
        /// <param name="sourceEnvironmentId">
        /// Source environment ID to compare from. Defaults to the Development environment if not provided.<br/>
        /// Example: 507f1f77bcf86cd799439011
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiffEnvironmentRequestDto(
            string? sourceEnvironmentId)
        {
            this.SourceEnvironmentId = sourceEnvironmentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffEnvironmentRequestDto" /> class.
        /// </summary>
        public DiffEnvironmentRequestDto()
        {
        }
    }
}