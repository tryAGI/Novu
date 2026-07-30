
#nullable enable

namespace Novu
{
    /// <summary>
    /// The provider identifier for the credentials
    /// </summary>
    public enum ChatOrPushProviderEnum
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
    public static class ChatOrPushProviderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatOrPushProviderEnum value)
        {
            return value switch
            {
                ChatOrPushProviderEnum.Apns => "apns",
                ChatOrPushProviderEnum.Appio => "appio",
                ChatOrPushProviderEnum.ChatWebhook => "chat-webhook",
                ChatOrPushProviderEnum.Discord => "discord",
                ChatOrPushProviderEnum.Expo => "expo",
                ChatOrPushProviderEnum.Fcm => "fcm",
                ChatOrPushProviderEnum.Getstream => "getstream",
                ChatOrPushProviderEnum.GrafanaOnCall => "grafana-on-call",
                ChatOrPushProviderEnum.Line => "line",
                ChatOrPushProviderEnum.Mattermost => "mattermost",
                ChatOrPushProviderEnum.Msteams => "msteams",
                ChatOrPushProviderEnum.NovuSlack => "novu-slack",
                ChatOrPushProviderEnum.NovuWebChat => "novu-web-chat",
                ChatOrPushProviderEnum.OneSignal => "one-signal",
                ChatOrPushProviderEnum.PushWebhook => "push-webhook",
                ChatOrPushProviderEnum.PusherBeams => "pusher-beams",
                ChatOrPushProviderEnum.Pushpad => "pushpad",
                ChatOrPushProviderEnum.RocketChat => "rocket-chat",
                ChatOrPushProviderEnum.Ryver => "ryver",
                ChatOrPushProviderEnum.Sendblue => "sendblue",
                ChatOrPushProviderEnum.Slack => "slack",
                ChatOrPushProviderEnum.Telegram => "telegram",
                ChatOrPushProviderEnum.WebexMessaging => "webex-messaging",
                ChatOrPushProviderEnum.WhatsappBusiness => "whatsapp-business",
                ChatOrPushProviderEnum.Zulip => "zulip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatOrPushProviderEnum? ToEnum(string value)
        {
            return value switch
            {
                "apns" => ChatOrPushProviderEnum.Apns,
                "appio" => ChatOrPushProviderEnum.Appio,
                "chat-webhook" => ChatOrPushProviderEnum.ChatWebhook,
                "discord" => ChatOrPushProviderEnum.Discord,
                "expo" => ChatOrPushProviderEnum.Expo,
                "fcm" => ChatOrPushProviderEnum.Fcm,
                "getstream" => ChatOrPushProviderEnum.Getstream,
                "grafana-on-call" => ChatOrPushProviderEnum.GrafanaOnCall,
                "line" => ChatOrPushProviderEnum.Line,
                "mattermost" => ChatOrPushProviderEnum.Mattermost,
                "msteams" => ChatOrPushProviderEnum.Msteams,
                "novu-slack" => ChatOrPushProviderEnum.NovuSlack,
                "novu-web-chat" => ChatOrPushProviderEnum.NovuWebChat,
                "one-signal" => ChatOrPushProviderEnum.OneSignal,
                "push-webhook" => ChatOrPushProviderEnum.PushWebhook,
                "pusher-beams" => ChatOrPushProviderEnum.PusherBeams,
                "pushpad" => ChatOrPushProviderEnum.Pushpad,
                "rocket-chat" => ChatOrPushProviderEnum.RocketChat,
                "ryver" => ChatOrPushProviderEnum.Ryver,
                "sendblue" => ChatOrPushProviderEnum.Sendblue,
                "slack" => ChatOrPushProviderEnum.Slack,
                "telegram" => ChatOrPushProviderEnum.Telegram,
                "webex-messaging" => ChatOrPushProviderEnum.WebexMessaging,
                "whatsapp-business" => ChatOrPushProviderEnum.WhatsappBusiness,
                "zulip" => ChatOrPushProviderEnum.Zulip,
                _ => null,
            };
        }
    }
}