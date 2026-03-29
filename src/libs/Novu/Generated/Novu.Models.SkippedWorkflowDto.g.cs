
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkippedWorkflowDto
    {
        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Resource name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceName { get; set; }

        /// <summary>
        /// Reason for skipping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkippedWorkflowDto" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the layout
        /// </param>
        /// <param name="resourceId">
        /// Resource ID
        /// </param>
        /// <param name="resourceName">
        /// Resource name
        /// </param>
        /// <param name="reason">
        /// Reason for skipping
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkippedWorkflowDto(
            global::Novu.ResourceTypeEnum resourceType,
            string resourceId,
            string resourceName,
            string reason)
        {
            this.ResourceType = resourceType;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkippedWorkflowDto" /> class.
        /// </summary>
        public SkippedWorkflowDto()
        {
        }
    }
}