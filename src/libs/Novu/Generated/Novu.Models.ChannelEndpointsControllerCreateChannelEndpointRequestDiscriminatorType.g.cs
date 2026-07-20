
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
        LineUser,
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
        OpsgenieIntegration,
        /// <summary>
        /// 
        /// </summary>
        PagerdutyService,
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
        TelegramChat,
        /// <summary>
        /// 
        /// </summary>
        WebexPerson,
        /// <summary>
        /// 
        /// </summary>
        WebexRoom,
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
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.LineUser => "line_user",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsChannel => "ms_teams_channel",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsUser => "ms_teams_user",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.OpsgenieIntegration => "opsgenie_integration",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.PagerdutyService => "pagerduty_service",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Phone => "phone",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackChannel => "slack_channel",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackUser => "slack_user",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.TelegramChat => "telegram_chat",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.WebexPerson => "webex_person",
                ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.WebexRoom => "webex_room",
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
                "line_user" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.LineUser,
                "ms_teams_channel" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsChannel,
                "ms_teams_user" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsUser,
                "opsgenie_integration" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.OpsgenieIntegration,
                "pagerduty_service" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.PagerdutyService,
                "phone" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Phone,
                "slack_channel" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackChannel,
                "slack_user" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackUser,
                "telegram_chat" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.TelegramChat,
                "webex_person" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.WebexPerson,
                "webex_room" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.WebexRoom,
                "webhook" => ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}