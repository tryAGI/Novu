
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadTranslationsResponseDto
    {
        /// <summary>
        /// Total number of files processed<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalFiles { get; set; }

        /// <summary>
        /// Number of files successfully uploaded<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("successfulUploads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SuccessfulUploads { get; set; }

        /// <summary>
        /// Number of files that failed to upload<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedUploads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FailedUploads { get; set; }

        /// <summary>
        /// List of error messages for failed uploads<br/>
        /// Example: [Invalid JSON in file: es-ES.json]
        /// </summary>
        /// <example>[Invalid JSON in file: es-ES.json]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadTranslationsResponseDto" /> class.
        /// </summary>
        /// <param name="totalFiles">
        /// Total number of files processed<br/>
        /// Example: 3
        /// </param>
        /// <param name="successfulUploads">
        /// Number of files successfully uploaded<br/>
        /// Example: 2
        /// </param>
        /// <param name="failedUploads">
        /// Number of files that failed to upload<br/>
        /// Example: 1
        /// </param>
        /// <param name="errors">
        /// List of error messages for failed uploads<br/>
        /// Example: [Invalid JSON in file: es-ES.json]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadTranslationsResponseDto(
            double totalFiles,
            double successfulUploads,
            double failedUploads,
            global::System.Collections.Generic.IList<string> errors)
        {
            this.TotalFiles = totalFiles;
            this.SuccessfulUploads = successfulUploads;
            this.FailedUploads = failedUploads;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadTranslationsResponseDto" /> class.
        /// </summary>
        public UploadTranslationsResponseDto()
        {
        }
    }
}