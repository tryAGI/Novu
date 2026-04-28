
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpectedDnsRecordDto
    {
        /// <summary>
        /// Example: MX
        /// </summary>
        /// <example>MX</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Example: inbound
        /// </summary>
        /// <example>inbound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: inbound-smtp.us-east-1.amazonaws.com
        /// </summary>
        /// <example>inbound-smtp.us-east-1.amazonaws.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Example: Auto
        /// </summary>
        /// <example>Auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ttl { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectedDnsRecordDto" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: MX
        /// </param>
        /// <param name="name">
        /// Example: inbound
        /// </param>
        /// <param name="content">
        /// Example: inbound-smtp.us-east-1.amazonaws.com
        /// </param>
        /// <param name="ttl">
        /// Example: Auto
        /// </param>
        /// <param name="priority">
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpectedDnsRecordDto(
            string type,
            string name,
            string content,
            string ttl,
            double? priority)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Ttl = ttl ?? throw new global::System.ArgumentNullException(nameof(ttl));
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectedDnsRecordDto" /> class.
        /// </summary>
        public ExpectedDnsRecordDto()
        {
        }
    }
}