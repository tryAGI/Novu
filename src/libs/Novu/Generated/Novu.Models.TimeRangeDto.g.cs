
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeRangeDto
    {
        /// <summary>
        /// Start time<br/>
        /// Example: 09:00 AM
        /// </summary>
        /// <example>09:00 AM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Start { get; set; }

        /// <summary>
        /// End time<br/>
        /// Example: 05:00 PM
        /// </summary>
        /// <example>05:00 PM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeDto" /> class.
        /// </summary>
        /// <param name="start">
        /// Start time<br/>
        /// Example: 09:00 AM
        /// </param>
        /// <param name="end">
        /// End time<br/>
        /// Example: 05:00 PM
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeRangeDto(
            string start,
            string end)
        {
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeDto" /> class.
        /// </summary>
        public TimeRangeDto()
        {
        }
    }
}