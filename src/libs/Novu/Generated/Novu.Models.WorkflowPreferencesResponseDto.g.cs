
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPreferencesResponseDto
    {
        /// <summary>
        /// User-specific workflow preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Novu.WorkflowPreferencesDto? User { get; set; }

        /// <summary>
        /// Default workflow preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowPreferencesDto Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferencesResponseDto" /> class.
        /// </summary>
        /// <param name="default">
        /// Default workflow preferences
        /// </param>
        /// <param name="user">
        /// User-specific workflow preferences
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowPreferencesResponseDto(
            global::Novu.WorkflowPreferencesDto @default,
            global::Novu.WorkflowPreferencesDto? user)
        {
            this.User = user;
            this.Default = @default ?? throw new global::System.ArgumentNullException(nameof(@default));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferencesResponseDto" /> class.
        /// </summary>
        public WorkflowPreferencesResponseDto()
        {
        }
    }
}