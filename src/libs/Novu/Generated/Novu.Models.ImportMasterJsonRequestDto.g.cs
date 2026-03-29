
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportMasterJsonRequestDto
    {
        /// <summary>
        /// The locale for which translations are being imported<br/>
        /// Example: en_US
        /// </summary>
        /// <example>en_US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Master JSON object containing all translations organized by workflow identifier<br/>
        /// Example: {"workflows":{"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}}
        /// </summary>
        /// <example>{"workflows":{"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("masterJson")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object MasterJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportMasterJsonRequestDto" /> class.
        /// </summary>
        /// <param name="locale">
        /// The locale for which translations are being imported<br/>
        /// Example: en_US
        /// </param>
        /// <param name="masterJson">
        /// Master JSON object containing all translations organized by workflow identifier<br/>
        /// Example: {"workflows":{"welcome-email":{"welcome.title":"Welcome to our platform","welcome.message":"Hello there!"},"password-reset":{"reset.title":"Reset your password","reset.message":"Click the link to reset"}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportMasterJsonRequestDto(
            string locale,
            object masterJson)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.MasterJson = masterJson ?? throw new global::System.ArgumentNullException(nameof(masterJson));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportMasterJsonRequestDto" /> class.
        /// </summary>
        public ImportMasterJsonRequestDto()
        {
        }
    }
}