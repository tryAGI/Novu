
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEnvironmentRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dns")]
        public global::Novu.InBoundParseDomainDto? Dns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bridge")]
        public global::Novu.BridgeConfigurationDto? Bridge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequestDto" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="identifier"></param>
        /// <param name="parentId"></param>
        /// <param name="color"></param>
        /// <param name="dns"></param>
        /// <param name="bridge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentRequestDto(
            string? name,
            string? identifier,
            string? parentId,
            string? color,
            global::Novu.InBoundParseDomainDto? dns,
            global::Novu.BridgeConfigurationDto? bridge)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.ParentId = parentId;
            this.Color = color;
            this.Dns = dns;
            this.Bridge = bridge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequestDto" /> class.
        /// </summary>
        public UpdateEnvironmentRequestDto()
        {
        }
    }
}