
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetadataSetSignalDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MetadataSetSignalDtoTypeJsonConverter))]
        public global::Novu.MetadataSetSignalDtoType Type { get; set; }

        /// <summary>
        /// Defaults to `set` when omitted.<br/>
        /// Default Value: set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.MetadataSetSignalDtoActionJsonConverter))]
        public global::Novu.MetadataSetSignalDtoAction? Action { get; set; }

        /// <summary>
        /// Metadata key (1–128 chars; letters, digits, and `-` `_` `:` separators).<br/>
        /// Example: crm:ticketId
        /// </summary>
        /// <example>crm:ticketId</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// JSON-serializable value to store.<br/>
        /// Example: TCK-1001
        /// </summary>
        /// <example>TCK-1001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSetSignalDto" /> class.
        /// </summary>
        /// <param name="key">
        /// Metadata key (1–128 chars; letters, digits, and `-` `_` `:` separators).<br/>
        /// Example: crm:ticketId
        /// </param>
        /// <param name="value">
        /// JSON-serializable value to store.<br/>
        /// Example: TCK-1001
        /// </param>
        /// <param name="type"></param>
        /// <param name="action">
        /// Defaults to `set` when omitted.<br/>
        /// Default Value: set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSetSignalDto(
            string key,
            object value,
            global::Novu.MetadataSetSignalDtoType type,
            global::Novu.MetadataSetSignalDtoAction? action)
        {
            this.Type = type;
            this.Action = action;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSetSignalDto" /> class.
        /// </summary>
        public MetadataSetSignalDto()
        {
        }

    }
}