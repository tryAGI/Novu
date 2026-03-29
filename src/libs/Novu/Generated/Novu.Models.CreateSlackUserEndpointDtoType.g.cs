
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: slack_user
    /// </summary>
    public enum CreateSlackUserEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        SlackUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSlackUserEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSlackUserEndpointDtoType value)
        {
            return value switch
            {
                CreateSlackUserEndpointDtoType.SlackUser => "slack_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSlackUserEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "slack_user" => CreateSlackUserEndpointDtoType.SlackUser,
                _ => null,
            };
        }
    }
}