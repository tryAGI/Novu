
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportMasterJsonResponseDto
    {
        /// <summary>
        /// Overall success status of the import operation<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Human-readable message describing the import result<br/>
        /// Example: Successfully imported translations for 2 resources: welcome-email, password-reset
        /// </summary>
        /// <example>Successfully imported translations for 2 resources: welcome-email, password-reset</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// List of resource IDs that were successfully imported<br/>
        /// Example: [welcome-email, password-reset]
        /// </summary>
        /// <example>[welcome-email, password-reset]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public global::System.Collections.Generic.IList<string>? Successful { get; set; }

        /// <summary>
        /// List of resource IDs that failed to import<br/>
        /// Example: [missing-workflow]
        /// </summary>
        /// <example>[missing-workflow]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public global::System.Collections.Generic.IList<string>? Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportMasterJsonResponseDto" /> class.
        /// </summary>
        /// <param name="success">
        /// Overall success status of the import operation<br/>
        /// Example: true
        /// </param>
        /// <param name="message">
        /// Human-readable message describing the import result<br/>
        /// Example: Successfully imported translations for 2 resources: welcome-email, password-reset
        /// </param>
        /// <param name="successful">
        /// List of resource IDs that were successfully imported<br/>
        /// Example: [welcome-email, password-reset]
        /// </param>
        /// <param name="failed">
        /// List of resource IDs that failed to import<br/>
        /// Example: [missing-workflow]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportMasterJsonResponseDto(
            bool success,
            string message,
            global::System.Collections.Generic.IList<string>? successful,
            global::System.Collections.Generic.IList<string>? failed)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Successful = successful;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportMasterJsonResponseDto" /> class.
        /// </summary>
        public ImportMasterJsonResponseDto()
        {
        }
    }
}