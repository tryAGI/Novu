
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationErrorDto
    {
        /// <summary>
        /// HTTP status code of the error response.<br/>
        /// Example: 404
        /// </summary>
        /// <example>404</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusCode { get; set; }

        /// <summary>
        /// Timestamp of when the error occurred.<br/>
        /// Example: 2024-12-12T13:00:00Z
        /// </summary>
        /// <example>2024-12-12T13:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// The path where the error occurred.<br/>
        /// Example: /api/v1/resource
        /// </summary>
        /// <example>/api/v1/resource</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Value that failed validation<br/>
        /// Example: xx xx xx 
        /// </summary>
        /// <example>xx xx xx </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>))]
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Message { get; set; }

        /// <summary>
        /// Optional context object for additional error details.<br/>
        /// Example: {"workflowId":"some_wf_id","stepId":"some_wf_id"}
        /// </summary>
        /// <example>{"workflowId":"some_wf_id","stepId":"some_wf_id"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctx")]
        public object? Ctx { get; set; }

        /// <summary>
        /// Optional unique identifier for the error, useful for tracking using Sentry and <br/>
        ///       New Relic, only available for 500.<br/>
        /// Example: abc123
        /// </summary>
        /// <example>abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorId")]
        public string? ErrorId { get; set; }

        /// <summary>
        /// A record of validation errors keyed by field name<br/>
        /// Example: {"fieldName1":{"messages":["Field is required","Must be a valid email address"],"value":"invalidEmail"},"fieldName2":{"messages":["Must be at least 18 years old"],"value":17},"fieldName3":{"messages":["Must be a boolean value"],"value":true},"fieldName4":{"messages":["Must be a valid object"],"value":{"key":"value"}},"fieldName5":{"messages":["Field is missing"],"value":null},"fieldName6":{"messages":["Undefined value"]}}
        /// </summary>
        /// <example>{"fieldName1":{"messages":["Field is required","Must be a valid email address"],"value":"invalidEmail"},"fieldName2":{"messages":["Must be at least 18 years old"],"value":17},"fieldName3":{"messages":["Must be a boolean value"],"value":true},"fieldName4":{"messages":["Must be a valid object"],"value":{"key":"value"}},"fieldName5":{"messages":["Field is missing"],"value":null},"fieldName6":{"messages":["Undefined value"]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Novu.ConstraintValidation> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDto" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code of the error response.<br/>
        /// Example: 404
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of when the error occurred.<br/>
        /// Example: 2024-12-12T13:00:00Z
        /// </param>
        /// <param name="path">
        /// The path where the error occurred.<br/>
        /// Example: /api/v1/resource
        /// </param>
        /// <param name="errors">
        /// A record of validation errors keyed by field name<br/>
        /// Example: {"fieldName1":{"messages":["Field is required","Must be a valid email address"],"value":"invalidEmail"},"fieldName2":{"messages":["Must be at least 18 years old"],"value":17},"fieldName3":{"messages":["Must be a boolean value"],"value":true},"fieldName4":{"messages":["Must be a valid object"],"value":{"key":"value"}},"fieldName5":{"messages":["Field is missing"],"value":null},"fieldName6":{"messages":["Undefined value"]}}
        /// </param>
        /// <param name="message">
        /// Value that failed validation<br/>
        /// Example: xx xx xx 
        /// </param>
        /// <param name="ctx">
        /// Optional context object for additional error details.<br/>
        /// Example: {"workflowId":"some_wf_id","stepId":"some_wf_id"}
        /// </param>
        /// <param name="errorId">
        /// Optional unique identifier for the error, useful for tracking using Sentry and <br/>
        ///       New Relic, only available for 500.<br/>
        /// Example: abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationErrorDto(
            double statusCode,
            string timestamp,
            string path,
            global::System.Collections.Generic.Dictionary<string, global::Novu.ConstraintValidation> errors,
            global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? message,
            object? ctx,
            string? errorId)
        {
            this.StatusCode = statusCode;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message;
            this.Ctx = ctx;
            this.ErrorId = errorId;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDto" /> class.
        /// </summary>
        public ValidationErrorDto()
        {
        }
    }
}