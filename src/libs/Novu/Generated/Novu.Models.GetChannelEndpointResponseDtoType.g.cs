
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: slack_channel
    /// </summary>
    public enum GetChannelEndpointResponseDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        MsTeamsChannel,
        /// <summary>
        /// 
        /// </summary>
        MsTeamsUser,
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        SlackChannel,
        /// <summary>
        /// 
        /// </summary>
        SlackUser,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetChannelEndpointResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelEndpointResponseDtoType value)
        {
            return value switch
            {
                GetChannelEndpointResponseDtoType.MsTeamsChannel => "ms_teams_channel",
                GetChannelEndpointResponseDtoType.MsTeamsUser => "ms_teams_user",
                GetChannelEndpointResponseDtoType.Phone => "phone",
                GetChannelEndpointResponseDtoType.SlackChannel => "slack_channel",
                GetChannelEndpointResponseDtoType.SlackUser => "slack_user",
                GetChannelEndpointResponseDtoType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChannelEndpointResponseDtoType? ToEnum(string value)
        {
            return value switch
            {
                "ms_teams_channel" => GetChannelEndpointResponseDtoType.MsTeamsChannel,
                "ms_teams_user" => GetChannelEndpointResponseDtoType.MsTeamsUser,
                "phone" => GetChannelEndpointResponseDtoType.Phone,
                "slack_channel" => GetChannelEndpointResponseDtoType.SlackChannel,
                "slack_user" => GetChannelEndpointResponseDtoType.SlackUser,
                "webhook" => GetChannelEndpointResponseDtoType.Webhook,
                _ => null,
            };
        }
    }
}