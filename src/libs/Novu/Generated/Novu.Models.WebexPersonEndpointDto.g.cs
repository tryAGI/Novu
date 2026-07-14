
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebexPersonEndpointDto
    {
        /// <summary>
        /// Webex person ID. Provide exactly one of personId or personEmail.<br/>
        /// Example: Y2lzY29zcGFyazovL3VzL1BFT1BMRS8...
        /// </summary>
        /// <example>Y2lzY29zcGFyazovL3VzL1BFT1BMRS8...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("personId")]
        public string? PersonId { get; set; }

        /// <summary>
        /// Webex person email. Provide exactly one of personId or personEmail.<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("personEmail")]
        public string? PersonEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebexPersonEndpointDto" /> class.
        /// </summary>
        /// <param name="personId">
        /// Webex person ID. Provide exactly one of personId or personEmail.<br/>
        /// Example: Y2lzY29zcGFyazovL3VzL1BFT1BMRS8...
        /// </param>
        /// <param name="personEmail">
        /// Webex person email. Provide exactly one of personId or personEmail.<br/>
        /// Example: user@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebexPersonEndpointDto(
            string? personId,
            string? personEmail)
        {
            this.PersonId = personId;
            this.PersonEmail = personEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebexPersonEndpointDto" /> class.
        /// </summary>
        public WebexPersonEndpointDto()
        {
        }

    }
}