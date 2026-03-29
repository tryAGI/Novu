
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: slack_channel
    /// </summary>
    public enum CreateSlackChannelEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        SlackChannel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSlackChannelEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSlackChannelEndpointDtoType value)
        {
            return value switch
            {
                CreateSlackChannelEndpointDtoType.SlackChannel => "slack_channel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSlackChannelEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel" => CreateSlackChannelEndpointDtoType.SlackChannel,
                _ => null,
            };
        }
    }
}