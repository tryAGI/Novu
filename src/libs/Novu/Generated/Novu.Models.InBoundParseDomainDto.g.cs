
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InBoundParseDomainDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inboundParseDomain")]
        public string? InboundParseDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InBoundParseDomainDto" /> class.
        /// </summary>
        /// <param name="inboundParseDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InBoundParseDomainDto(
            string? inboundParseDomain)
        {
            this.InboundParseDomain = inboundParseDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InBoundParseDomainDto" /> class.
        /// </summary>
        public InBoundParseDomainDto()
        {
        }
    }
}