
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationControllerUploadTranslationFilesRequest
    {
        /// <summary>
        /// The resource ID to associate localizations with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </summary>
        /// <example>welcome-email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// The resource type to associate localizations with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType ResourceType { get; set; }

        /// <summary>
        /// One or more JSON translation files. Filenames must match locale format (e.g., en_US.json, fr_FR.json). Field name can be "files" or "files[]".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationControllerUploadTranslationFilesRequest" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// The resource ID to associate localizations with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// The resource type to associate localizations with
        /// </param>
        /// <param name="files">
        /// One or more JSON translation files. Filenames must match locale format (e.g., en_US.json, fr_FR.json). Field name can be "files" or "files[]".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationControllerUploadTranslationFilesRequest(
            string resourceId,
            global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType resourceType,
            global::System.Collections.Generic.IList<byte[]> files)
        {
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceType = resourceType;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationControllerUploadTranslationFilesRequest" /> class.
        /// </summary>
        public TranslationControllerUploadTranslationFilesRequest()
        {
        }
    }
}