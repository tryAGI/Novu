
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupPreferenceFilterDto
    {
        /// <summary>
        /// Whether the preference is enabled. Used when condition is not provided.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional condition using JSON Logic rules<br/>
        /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
        /// </summary>
        /// <example>{"and":[{"===":[{"var":"tier"},"premium"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public object? Condition { get; set; }

        /// <summary>
        /// Filter criteria for workflow IDs and tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.GroupPreferenceFilterDetailsDto Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPreferenceFilterDto" /> class.
        /// </summary>
        /// <param name="filter">
        /// Filter criteria for workflow IDs and tags
        /// </param>
        /// <param name="enabled">
        /// Whether the preference is enabled. Used when condition is not provided.<br/>
        /// Example: true
        /// </param>
        /// <param name="condition">
        /// Optional condition using JSON Logic rules<br/>
        /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupPreferenceFilterDto(
            global::Novu.GroupPreferenceFilterDetailsDto filter,
            bool? enabled,
            object? condition)
        {
            this.Enabled = enabled;
            this.Condition = condition;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPreferenceFilterDto" /> class.
        /// </summary>
        public GroupPreferenceFilterDto()
        {
        }
    }
}