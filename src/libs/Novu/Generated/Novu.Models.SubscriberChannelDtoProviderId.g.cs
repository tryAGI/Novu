
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
        Slack,
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
                SubscriberChannelDtoProviderId.Mattermost => "mattermost",
                SubscriberChannelDtoProviderId.Msteams => "msteams",
                SubscriberChannelDtoProviderId.NovuSlack => "novu-slack",
                SubscriberChannelDtoProviderId.OneSignal => "one-signal",
                SubscriberChannelDtoProviderId.PushWebhook => "push-webhook",
                SubscriberChannelDtoProviderId.PusherBeams => "pusher-beams",
                SubscriberChannelDtoProviderId.Pushpad => "pushpad",
                SubscriberChannelDtoProviderId.RocketChat => "rocket-chat",
                SubscriberChannelDtoProviderId.Ryver => "ryver",
                SubscriberChannelDtoProviderId.Slack => "slack",
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
                "mattermost" => SubscriberChannelDtoProviderId.Mattermost,
                "msteams" => SubscriberChannelDtoProviderId.Msteams,
                "novu-slack" => SubscriberChannelDtoProviderId.NovuSlack,
                "one-signal" => SubscriberChannelDtoProviderId.OneSignal,
                "push-webhook" => SubscriberChannelDtoProviderId.PushWebhook,
                "pusher-beams" => SubscriberChannelDtoProviderId.PusherBeams,
                "pushpad" => SubscriberChannelDtoProviderId.Pushpad,
                "rocket-chat" => SubscriberChannelDtoProviderId.RocketChat,
                "ryver" => SubscriberChannelDtoProviderId.Ryver,
                "slack" => SubscriberChannelDtoProviderId.Slack,
                "whatsapp-business" => SubscriberChannelDtoProviderId.WhatsappBusiness,
                "zulip" => SubscriberChannelDtoProviderId.Zulip,
                _ => null,
            };
        }
    }
}