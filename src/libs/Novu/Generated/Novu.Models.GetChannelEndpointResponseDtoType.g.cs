
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
        GrafanaOncallIntegration,
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
        ToolWebhook,
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
    public static class GetChannelEndpointResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelEndpointResponseDtoType value)
        {
            return value switch
            {
                GetChannelEndpointResponseDtoType.GrafanaOncallIntegration => "grafana_oncall_integration",
                GetChannelEndpointResponseDtoType.LineUser => "line_user",
                GetChannelEndpointResponseDtoType.MsTeamsChannel => "ms_teams_channel",
                GetChannelEndpointResponseDtoType.MsTeamsUser => "ms_teams_user",
                GetChannelEndpointResponseDtoType.OpsgenieIntegration => "opsgenie_integration",
                GetChannelEndpointResponseDtoType.PagerdutyService => "pagerduty_service",
                GetChannelEndpointResponseDtoType.Phone => "phone",
                GetChannelEndpointResponseDtoType.SlackChannel => "slack_channel",
                GetChannelEndpointResponseDtoType.SlackUser => "slack_user",
                GetChannelEndpointResponseDtoType.TelegramChat => "telegram_chat",
                GetChannelEndpointResponseDtoType.ToolWebhook => "tool_webhook",
                GetChannelEndpointResponseDtoType.WebexPerson => "webex_person",
                GetChannelEndpointResponseDtoType.WebexRoom => "webex_room",
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
                "grafana_oncall_integration" => GetChannelEndpointResponseDtoType.GrafanaOncallIntegration,
                "line_user" => GetChannelEndpointResponseDtoType.LineUser,
                "ms_teams_channel" => GetChannelEndpointResponseDtoType.MsTeamsChannel,
                "ms_teams_user" => GetChannelEndpointResponseDtoType.MsTeamsUser,
                "opsgenie_integration" => GetChannelEndpointResponseDtoType.OpsgenieIntegration,
                "pagerduty_service" => GetChannelEndpointResponseDtoType.PagerdutyService,
                "phone" => GetChannelEndpointResponseDtoType.Phone,
                "slack_channel" => GetChannelEndpointResponseDtoType.SlackChannel,
                "slack_user" => GetChannelEndpointResponseDtoType.SlackUser,
                "telegram_chat" => GetChannelEndpointResponseDtoType.TelegramChat,
                "tool_webhook" => GetChannelEndpointResponseDtoType.ToolWebhook,
                "webex_person" => GetChannelEndpointResponseDtoType.WebexPerson,
                "webex_room" => GetChannelEndpointResponseDtoType.WebexRoom,
                "webhook" => GetChannelEndpointResponseDtoType.Webhook,
                _ => null,
            };
        }
    }
}