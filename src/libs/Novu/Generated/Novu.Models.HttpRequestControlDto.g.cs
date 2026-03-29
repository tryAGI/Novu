
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpRequestControlDto
    {
        /// <summary>
        /// HTTP method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.HttpMethodEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.HttpMethodEnum Method { get; set; }

        /// <summary>
        /// Target URL for the HTTP request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Request headers as key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Headers { get; set; }

        /// <summary>
        /// Request body as key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Body { get; set; }

        /// <summary>
        /// JSON schema to validate response body against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBodySchema")]
        public object? ResponseBodySchema { get; set; }

        /// <summary>
        /// Whether to enforce response body schema validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceSchemaValidation")]
        public bool? EnforceSchemaValidation { get; set; }

        /// <summary>
        /// Whether to continue workflow execution on failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continueOnFailure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestControlDto" /> class.
        /// </summary>
        /// <param name="method">
        /// HTTP method
        /// </param>
        /// <param name="url">
        /// Target URL for the HTTP request
        /// </param>
        /// <param name="headers">
        /// Request headers as key-value pairs
        /// </param>
        /// <param name="body">
        /// Request body as key-value pairs
        /// </param>
        /// <param name="responseBodySchema">
        /// JSON schema to validate response body against
        /// </param>
        /// <param name="enforceSchemaValidation">
        /// Whether to enforce response body schema validation
        /// </param>
        /// <param name="continueOnFailure">
        /// Whether to continue workflow execution on failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpRequestControlDto(
            global::Novu.HttpMethodEnum method,
            string url,
            global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? headers,
            global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? body,
            object? responseBodySchema,
            bool? enforceSchemaValidation,
            bool? continueOnFailure)
        {
            this.Method = method;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Body = body;
            this.ResponseBodySchema = responseBodySchema;
            this.EnforceSchemaValidation = enforceSchemaValidation;
            this.ContinueOnFailure = continueOnFailure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestControlDto" /> class.
        /// </summary>
        public HttpRequestControlDto()
        {
        }
    }
}