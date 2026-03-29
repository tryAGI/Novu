
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateSubscriberPreferencesDto
    {
        /// <summary>
        /// Array of workflow preferences to update (maximum 100 items)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto> Preferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSubscriberPreferencesDto" /> class.
        /// </summary>
        /// <param name="preferences">
        /// Array of workflow preferences to update (maximum 100 items)
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateSubscriberPreferencesDto(
            global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto> preferences,
            object? context)
        {
            this.Preferences = preferences ?? throw new global::System.ArgumentNullException(nameof(preferences));
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSubscriberPreferencesDto" /> class.
        /// </summary>
        public BulkUpdateSubscriberPreferencesDto()
        {
        }
    }
}