
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueIntegrationMobileLinkRequestDto
    {
        /// <summary>
        /// Optional subscriber to link via `/start` deep link after mobile setup completes. When provided, the consume response may include a ready-to-open Telegram deep link.<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueIntegrationMobileLinkRequestDto" /> class.
        /// </summary>
        /// <param name="subscriberId">
        /// Optional subscriber to link via `/start` deep link after mobile setup completes. When provided, the consume response may include a ready-to-open Telegram deep link.<br/>
        /// Example: subscriber-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueIntegrationMobileLinkRequestDto(
            string? subscriberId)
        {
            this.SubscriberId = subscriberId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueIntegrationMobileLinkRequestDto" /> class.
        /// </summary>
        public IssueIntegrationMobileLinkRequestDto()
        {
        }

    }
}