
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileRefDto
    {
        /// <summary>
        /// Filename shown to the end user, including extension.<br/>
        /// Example: report.pdf
        /// </summary>
        /// <example>report.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// IANA MIME type of the file.<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Base64-encoded inline file bytes. Mutually exclusive with `url`. Decoded size must be ≤ 5 MB. Prefer `url` for larger files.<br/>
        /// Example: JVBERi0xLjQK...
        /// </summary>
        /// <example>JVBERi0xLjQK...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Publicly accessible HTTP(S) URL. Mutually exclusive with `data`. Server-side limits: 25 MB per file, 15 files per message, 50 MB aggregate.<br/>
        /// Example: https://example.com/files/report.pdf
        /// </summary>
        /// <example>https://example.com/files/report.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileRefDto" /> class.
        /// </summary>
        /// <param name="filename">
        /// Filename shown to the end user, including extension.<br/>
        /// Example: report.pdf
        /// </param>
        /// <param name="mimeType">
        /// IANA MIME type of the file.<br/>
        /// Example: application/pdf
        /// </param>
        /// <param name="data">
        /// Base64-encoded inline file bytes. Mutually exclusive with `url`. Decoded size must be ≤ 5 MB. Prefer `url` for larger files.<br/>
        /// Example: JVBERi0xLjQK...
        /// </param>
        /// <param name="url">
        /// Publicly accessible HTTP(S) URL. Mutually exclusive with `data`. Server-side limits: 25 MB per file, 15 files per message, 50 MB aggregate.<br/>
        /// Example: https://example.com/files/report.pdf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileRefDto(
            string filename,
            string? mimeType,
            string? data,
            string? url)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MimeType = mimeType;
            this.Data = data;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileRefDto" /> class.
        /// </summary>
        public FileRefDto()
        {
        }

    }
}