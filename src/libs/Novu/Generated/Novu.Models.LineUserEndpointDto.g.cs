
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LineUserEndpointDto
    {
        /// <summary>
        /// LINE user ID<br/>
        /// Example: U1234567890abcdef
        /// </summary>
        /// <example>U1234567890abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LineUserEndpointDto" /> class.
        /// </summary>
        /// <param name="userId">
        /// LINE user ID<br/>
        /// Example: U1234567890abcdef
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LineUserEndpointDto(
            string userId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineUserEndpointDto" /> class.
        /// </summary>
        public LineUserEndpointDto()
        {
        }

    }
}