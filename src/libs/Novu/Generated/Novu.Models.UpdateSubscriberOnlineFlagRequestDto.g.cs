
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSubscriberOnlineFlagRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOnline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriberOnlineFlagRequestDto" /> class.
        /// </summary>
        /// <param name="isOnline"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSubscriberOnlineFlagRequestDto(
            bool isOnline)
        {
            this.IsOnline = isOnline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriberOnlineFlagRequestDto" /> class.
        /// </summary>
        public UpdateSubscriberOnlineFlagRequestDto()
        {
        }
    }
}