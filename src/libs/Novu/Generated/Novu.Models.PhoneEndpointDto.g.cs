
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneEndpointDto
    {
        /// <summary>
        /// Phone number in E.164 format<br/>
        /// Example: +1234567890
        /// </summary>
        /// <example>+1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneEndpointDto" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number in E.164 format<br/>
        /// Example: +1234567890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneEndpointDto(
            string phoneNumber)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneEndpointDto" /> class.
        /// </summary>
        public PhoneEndpointDto()
        {
        }
    }
}