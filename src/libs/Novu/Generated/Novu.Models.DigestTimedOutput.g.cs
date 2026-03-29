
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DigestTimedOutput
    {
        /// <summary>
        /// Cron expression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cron { get; set; }

        /// <summary>
        /// Optional digest key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestKey")]
        public string? DigestKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestTimedOutput" /> class.
        /// </summary>
        /// <param name="cron">
        /// Cron expression
        /// </param>
        /// <param name="digestKey">
        /// Optional digest key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DigestTimedOutput(
            string cron,
            string? digestKey)
        {
            this.Cron = cron ?? throw new global::System.ArgumentNullException(nameof(cron));
            this.DigestKey = digestKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestTimedOutput" /> class.
        /// </summary>
        public DigestTimedOutput()
        {
        }
    }
}