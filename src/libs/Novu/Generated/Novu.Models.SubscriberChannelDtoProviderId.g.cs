
#nullable enable

namespace Novu
{
    /// <summary>
    /// The ID of the chat or push provider.
    /// </summary>
    public enum SubscriberChannelDtoProviderId
    {
        /// <summary>
        ///
        /// </summary>
        Apns,
        /// <summary>
        ///
        /// </summary>
        Appio,
        /// <summary>
        ///
        /// </summary>
        ChatWebhook,
        /// <summary>
        ///
        /// </summary>
        Discord,
        /// <summary>
        ///
        /// </summary>
        Expo,
        /// <summary>
        ///
        /// </summary>
        Fcm,
        /// <summary>
        ///
        /// </summary>
        Getstream,
        /// <summary>
        ///
        /// </summary>
        GrafanaOnCall,
        /// <summary>
        ///
        /// </summary>
        Line,
        /// <summary>
        ///
        /// </summary>
        Mattermost,
        /// <summary>
        ///
        /// </summary>
        Msteams,
        /// <summary>
        ///
        /// </summary>
        NovuSlack,
        /// <summary>
        ///
        /// </summary>
        NovuWebChat,
        /// <summary>
        ///
        /// </summary>
        OneSignal,
        /// <summary>
        ///
        /// </summary>
        PushWebhook,
        /// <summary>
        ///
        /// </summary>
        PusherBeams,
        /// <summary>
        ///
        /// </summary>
        Pushpad,
        /// <summary>
        ///
        /// </summary>
        RocketChat,
        /// <summary>
        ///
        /// </summary>
        Ryver,
        /// <summary>
        ///
        /// </summary>
        Sendblue,
        /// <summary>
        ///
        /// </summary>
        Slack,
        /// <summary>
        ///
        /// </summary>
        Telegram,
        /// <summary>
        ///
        /// </summary>
        WebexMessaging,
        /// <summary>
        ///
        /// </summary>
        WhatsappBusiness,
        /// <summary>
        ///
        /// </summary>
        Zulip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriberChannelDtoProviderIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriberChannelDtoProviderId value)
        {
            return value switch
            {
                SubscriberChannelDtoProviderId.Apns => "apns",
                SubscriberChannelDtoProviderId.Appio => "appio",
                SubscriberChannelDtoProviderId.ChatWebhook => "chat-webhook",
                SubscriberChannelDtoProviderId.Discord => "discord",
                SubscriberChannelDtoProviderId.Expo => "expo",
                SubscriberChannelDtoProviderId.Fcm => "fcm",
                SubscriberChannelDtoProviderId.Getstream => "getstream",
                SubscriberChannelDtoProviderId.GrafanaOnCall => "grafana-on-call",
                SubscriberChannelDtoProviderId.Line => "line",
                SubscriberChannelDtoProviderId.Mattermost => "mattermost",
                SubscriberChannelDtoProviderId.Msteams => "msteams",
                SubscriberChannelDtoProviderId.NovuSlack => "novu-slack",
                SubscriberChannelDtoProviderId.NovuWebChat => "novu-web-chat",
                SubscriberChannelDtoProviderId.OneSignal => "one-signal",
                SubscriberChannelDtoProviderId.PushWebhook => "push-webhook",
                SubscriberChannelDtoProviderId.PusherBeams => "pusher-beams",
                SubscriberChannelDtoProviderId.Pushpad => "pushpad",
                SubscriberChannelDtoProviderId.RocketChat => "rocket-chat",
                SubscriberChannelDtoProviderId.Ryver => "ryver",
                SubscriberChannelDtoProviderId.Sendblue => "sendblue",
                SubscriberChannelDtoProviderId.Slack => "slack",
                SubscriberChannelDtoProviderId.Telegram => "telegram",
                SubscriberChannelDtoProviderId.WebexMessaging => "webex-messaging",
                SubscriberChannelDtoProviderId.WhatsappBusiness => "whatsapp-business",
                SubscriberChannelDtoProviderId.Zulip => "zulip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriberChannelDtoProviderId? ToEnum(string value)
        {
            return value switch
            {
                "apns" => SubscriberChannelDtoProviderId.Apns,
                "appio" => SubscriberChannelDtoProviderId.Appio,
                "chat-webhook" => SubscriberChannelDtoProviderId.ChatWebhook,
                "discord" => SubscriberChannelDtoProviderId.Discord,
                "expo" => SubscriberChannelDtoProviderId.Expo,
                "fcm" => SubscriberChannelDtoProviderId.Fcm,
                "getstream" => SubscriberChannelDtoProviderId.Getstream,
                "grafana-on-call" => SubscriberChannelDtoProviderId.GrafanaOnCall,
                "line" => SubscriberChannelDtoProviderId.Line,
                "mattermost" => SubscriberChannelDtoProviderId.Mattermost,
                "msteams" => SubscriberChannelDtoProviderId.Msteams,
                "novu-slack" => SubscriberChannelDtoProviderId.NovuSlack,
                "novu-web-chat" => SubscriberChannelDtoProviderId.NovuWebChat,
                "one-signal" => SubscriberChannelDtoProviderId.OneSignal,
                "push-webhook" => SubscriberChannelDtoProviderId.PushWebhook,
                "pusher-beams" => SubscriberChannelDtoProviderId.PusherBeams,
                "pushpad" => SubscriberChannelDtoProviderId.Pushpad,
                "rocket-chat" => SubscriberChannelDtoProviderId.RocketChat,
                "ryver" => SubscriberChannelDtoProviderId.Ryver,
                "sendblue" => SubscriberChannelDtoProviderId.Sendblue,
                "slack" => SubscriberChannelDtoProviderId.Slack,
                "telegram" => SubscriberChannelDtoProviderId.Telegram,
                "webex-messaging" => SubscriberChannelDtoProviderId.WebexMessaging,
                "whatsapp-business" => SubscriberChannelDtoProviderId.WhatsappBusiness,
                "zulip" => SubscriberChannelDtoProviderId.Zulip,
                _ => null,
            };
        }
    }
}