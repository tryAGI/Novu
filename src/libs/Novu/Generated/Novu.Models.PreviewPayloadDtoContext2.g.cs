
#nullable enable

namespace Novu
{
    /// <summary>
    /// Rich context object with id and optional data
    /// </summary>
    public sealed partial class PreviewPayloadDtoContext2
    {
        /// <summary>
        /// Example: org-acme
        /// </summary>
        /// <example>org-acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional additional context data<br/>
        /// Example: {"name":"Acme Corp","region":"us-east-1"}
        /// </summary>
        /// <example>{"name":"Acme Corp","region":"us-east-1"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewPayloadDtoContext2" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: org-acme
        /// </param>
        /// <param name="data">
        /// Optional additional context data<br/>
        /// Example: {"name":"Acme Corp","region":"us-east-1"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewPayloadDtoContext2(
            string id,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewPayloadDtoContext2" /> class.
        /// </summary>
        public PreviewPayloadDtoContext2()
        {
        }
    }
}