
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: webex_room
    /// </summary>
    public enum CreateWebexRoomEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        WebexRoom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebexRoomEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebexRoomEndpointDtoType value)
        {
            return value switch
            {
                CreateWebexRoomEndpointDtoType.WebexRoom => "webex_room",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebexRoomEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "webex_room" => CreateWebexRoomEndpointDtoType.WebexRoom,
                _ => null,
            };
        }
    }
}