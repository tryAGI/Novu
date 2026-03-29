
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishEnvironmentRequestDto
    {
        /// <summary>
        /// Source environment ID to sync from. Defaults to the Development environment if not provided.<br/>
        /// Example: 507f1f77bcf86cd799439011
        /// </summary>
        /// <example>507f1f77bcf86cd799439011</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceEnvironmentId")]
        public string? SourceEnvironmentId { get; set; }

        /// <summary>
        /// Perform a dry run without making actual changes<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Array of specific resources to publish. If not provided, all resources will be published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishEnvironmentRequestDto" /> class.
        /// </summary>
        /// <param name="sourceEnvironmentId">
        /// Source environment ID to sync from. Defaults to the Development environment if not provided.<br/>
        /// Example: 507f1f77bcf86cd799439011
        /// </param>
        /// <param name="dryRun">
        /// Perform a dry run without making actual changes<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resources">
        /// Array of specific resources to publish. If not provided, all resources will be published.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishEnvironmentRequestDto(
            string? sourceEnvironmentId,
            bool? dryRun,
            global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? resources)
        {
            this.SourceEnvironmentId = sourceEnvironmentId;
            this.DryRun = dryRun;
            this.Resources = resources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishEnvironmentRequestDto" /> class.
        /// </summary>
        public PublishEnvironmentRequestDto()
        {
        }
    }
}