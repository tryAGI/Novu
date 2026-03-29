
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestLogResponseDto
    {
        /// <summary>
        /// Request log identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Request URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// URL pattern
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlPattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlPattern { get; set; }

        /// <summary>
        /// HTTP method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// HTTP status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusCode { get; set; }

        /// <summary>
        /// Request path
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Request hostname
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// Transaction identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public object? TransactionId { get; set; }

        /// <summary>
        /// Client IP address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        /// User agent string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserAgent { get; set; }

        /// <summary>
        /// Request body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestBody { get; set; }

        /// <summary>
        /// Response body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseBody { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Organization identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Environment identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Authentication type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthType { get; set; }

        /// <summary>
        /// Request duration in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Request log identifier
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="url">
        /// Request URL
        /// </param>
        /// <param name="urlPattern">
        /// URL pattern
        /// </param>
        /// <param name="method">
        /// HTTP method
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code
        /// </param>
        /// <param name="path">
        /// Request path
        /// </param>
        /// <param name="hostname">
        /// Request hostname
        /// </param>
        /// <param name="ip">
        /// Client IP address
        /// </param>
        /// <param name="userAgent">
        /// User agent string
        /// </param>
        /// <param name="requestBody">
        /// Request body
        /// </param>
        /// <param name="responseBody">
        /// Response body
        /// </param>
        /// <param name="userId">
        /// User identifier
        /// </param>
        /// <param name="organizationId">
        /// Organization identifier
        /// </param>
        /// <param name="environmentId">
        /// Environment identifier
        /// </param>
        /// <param name="authType">
        /// Authentication type
        /// </param>
        /// <param name="durationMs">
        /// Request duration in milliseconds
        /// </param>
        /// <param name="transactionId">
        /// Transaction identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestLogResponseDto(
            string id,
            string createdAt,
            string url,
            string urlPattern,
            string method,
            double statusCode,
            string path,
            string hostname,
            string ip,
            string userAgent,
            string requestBody,
            string responseBody,
            string userId,
            string organizationId,
            string environmentId,
            string authType,
            double durationMs,
            object? transactionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UrlPattern = urlPattern ?? throw new global::System.ArgumentNullException(nameof(urlPattern));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.StatusCode = statusCode;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.TransactionId = transactionId;
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.UserAgent = userAgent ?? throw new global::System.ArgumentNullException(nameof(userAgent));
            this.RequestBody = requestBody ?? throw new global::System.ArgumentNullException(nameof(requestBody));
            this.ResponseBody = responseBody ?? throw new global::System.ArgumentNullException(nameof(responseBody));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.AuthType = authType ?? throw new global::System.ArgumentNullException(nameof(authType));
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogResponseDto" /> class.
        /// </summary>
        public RequestLogResponseDto()
        {
        }
    }
}