
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceDependencyDto
    {
        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// ID of the dependent resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Name of the dependent resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceName { get; set; }

        /// <summary>
        /// Whether this dependency blocks the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBlocking { get; set; }

        /// <summary>
        /// Reason for the dependency
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DependencyReasonEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DependencyReasonEnum Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDependencyDto" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the layout
        /// </param>
        /// <param name="resourceId">
        /// ID of the dependent resource
        /// </param>
        /// <param name="resourceName">
        /// Name of the dependent resource
        /// </param>
        /// <param name="isBlocking">
        /// Whether this dependency blocks the operation
        /// </param>
        /// <param name="reason">
        /// Reason for the dependency
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceDependencyDto(
            global::Novu.ResourceTypeEnum resourceType,
            string resourceId,
            string resourceName,
            bool isBlocking,
            global::Novu.DependencyReasonEnum reason)
        {
            this.ResourceType = resourceType;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
            this.IsBlocking = isBlocking;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDependencyDto" /> class.
        /// </summary>
        public ResourceDependencyDto()
        {
        }
    }
}