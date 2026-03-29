
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMasterJsonResponseDto
    {
        /// <summary>
        /// All translations for given locale organized by workflow identifier<br/>
        /// Example: {"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}
        /// </summary>
        /// <example>{"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Workflows { get; set; }

        /// <summary>
        /// All translations for given locale organized by layout identifier<br/>
        /// Example: {"default-layout":{"layout.title":"Default layout","layout.message":"Hello there!"}}
        /// </summary>
        /// <example>{"default-layout":{"layout.title":"Default layout","layout.message":"Hello there!"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Layouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMasterJsonResponseDto" /> class.
        /// </summary>
        /// <param name="workflows">
        /// All translations for given locale organized by workflow identifier<br/>
        /// Example: {"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}
        /// </param>
        /// <param name="layouts">
        /// All translations for given locale organized by layout identifier<br/>
        /// Example: {"default-layout":{"layout.title":"Default layout","layout.message":"Hello there!"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMasterJsonResponseDto(
            object workflows,
            object layouts)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMasterJsonResponseDto" /> class.
        /// </summary>
        public GetMasterJsonResponseDto()
        {
        }
    }
}