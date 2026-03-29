
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityNotificationTemplateResponseDto
    {
        /// <summary>
        /// Unique identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Origin of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        public global::Novu.ResourceOriginEnum? Origin { get; set; }

        /// <summary>
        /// Triggers of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.NotificationTriggerDto> Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationTemplateResponseDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the template
        /// </param>
        /// <param name="triggers">
        /// Triggers of the template
        /// </param>
        /// <param name="id">
        /// Unique identifier of the template
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityNotificationTemplateResponseDto(
            string name,
            global::System.Collections.Generic.IList<global::Novu.NotificationTriggerDto> triggers,
            string? id,
            global::Novu.ResourceOriginEnum? origin)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Origin = origin;
            this.Triggers = triggers ?? throw new global::System.ArgumentNullException(nameof(triggers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationTemplateResponseDto" /> class.
        /// </summary>
        public ActivityNotificationTemplateResponseDto()
        {
        }
    }
}