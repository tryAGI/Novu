
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: ms_teams_channel
    /// </summary>
    public enum CreateMsTeamsChannelEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        MsTeamsChannel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMsTeamsChannelEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMsTeamsChannelEndpointDtoType value)
        {
            return value switch
            {
                CreateMsTeamsChannelEndpointDtoType.MsTeamsChannel => "ms_teams_channel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMsTeamsChannelEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "ms_teams_channel" => CreateMsTeamsChannelEndpointDtoType.MsTeamsChannel,
                _ => null,
            };
        }
    }
}