
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRequestResponseDto
    {
        /// <summary>
        /// Request details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.RequestLogResponseDto Request { get; set; }

        /// <summary>
        /// Associated traces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.TraceResponseDto> Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestResponseDto" /> class.
        /// </summary>
        /// <param name="request">
        /// Request details
        /// </param>
        /// <param name="traces">
        /// Associated traces
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRequestResponseDto(
            global::Novu.RequestLogResponseDto request,
            global::System.Collections.Generic.IList<global::Novu.TraceResponseDto> traces)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestResponseDto" /> class.
        /// </summary>
        public GetRequestResponseDto()
        {
        }
    }
}