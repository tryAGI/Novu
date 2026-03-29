
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelayScheduledMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter))]
        public global::Novu.DelayScheduledMetadataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delayPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DelayPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayScheduledMetadata" /> class.
        /// </summary>
        /// <param name="delayPath"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelayScheduledMetadata(
            string delayPath,
            global::Novu.DelayScheduledMetadataType type)
        {
            this.Type = type;
            this.DelayPath = delayPath ?? throw new global::System.ArgumentNullException(nameof(delayPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayScheduledMetadata" /> class.
        /// </summary>
        public DelayScheduledMetadata()
        {
        }
    }
}