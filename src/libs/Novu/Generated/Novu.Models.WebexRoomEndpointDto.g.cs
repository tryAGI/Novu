
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebexRoomEndpointDto
    {
        /// <summary>
        /// Webex room ID<br/>
        /// Example: Y2lzY29zcGFyazovL3VzL1JPT00v...
        /// </summary>
        /// <example>Y2lzY29zcGFyazovL3VzL1JPT00v...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("roomId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomId { get; set; }

        /// <summary>
        /// Optional Webex parent message ID for threaded replies<br/>
        /// Example: Y2lzY29zcGFyazovL3VzL01FU1NBR0Uv...
        /// </summary>
        /// <example>Y2lzY29zcGFyazovL3VzL01FU1NBR0Uv...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebexRoomEndpointDto" /> class.
        /// </summary>
        /// <param name="roomId">
        /// Webex room ID<br/>
        /// Example: Y2lzY29zcGFyazovL3VzL1JPT00v...
        /// </param>
        /// <param name="parentId">
        /// Optional Webex parent message ID for threaded replies<br/>
        /// Example: Y2lzY29zcGFyazovL3VzL01FU1NBR0Uv...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebexRoomEndpointDto(
            string roomId,
            string? parentId)
        {
            this.RoomId = roomId ?? throw new global::System.ArgumentNullException(nameof(roomId));
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebexRoomEndpointDto" /> class.
        /// </summary>
        public WebexRoomEndpointDto()
        {
        }

    }
}