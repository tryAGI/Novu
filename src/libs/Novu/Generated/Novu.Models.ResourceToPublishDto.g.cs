
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceToPublishDto
    {
        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Unique identifier of the resource to publish<br/>
        /// Example: workflow-id-1
        /// </summary>
        /// <example>workflow-id-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceToPublishDto" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the layout
        /// </param>
        /// <param name="resourceId">
        /// Unique identifier of the resource to publish<br/>
        /// Example: workflow-id-1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceToPublishDto(
            global::Novu.ResourceTypeEnum resourceType,
            string resourceId)
        {
            this.ResourceType = resourceType;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceToPublishDto" /> class.
        /// </summary>
        public ResourceToPublishDto()
        {
        }
    }
}