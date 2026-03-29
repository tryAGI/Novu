
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: ms_teams_user
    /// </summary>
    public enum CreateMsTeamsUserEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        MsTeamsUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMsTeamsUserEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMsTeamsUserEndpointDtoType value)
        {
            return value switch
            {
                CreateMsTeamsUserEndpointDtoType.MsTeamsUser => "ms_teams_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMsTeamsUserEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "ms_teams_user" => CreateMsTeamsUserEndpointDtoType.MsTeamsUser,
                _ => null,
            };
        }
    }
}