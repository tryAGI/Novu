
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType
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
    public static class ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType value)
        {
            return value switch
            {
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsChannel => "ms_teams_channel",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsUser => "ms_teams_user",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Phone => "phone",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackChannel => "slack_channel",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackUser => "slack_user",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ms_teams_channel" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsChannel,
                "ms_teams_user" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsUser,
                "phone" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Phone,
                "slack_channel" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackChannel,
                "slack_user" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackUser,
                "webhook" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}