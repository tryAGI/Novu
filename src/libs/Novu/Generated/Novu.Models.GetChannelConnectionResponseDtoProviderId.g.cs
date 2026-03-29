
#nullable enable

namespace Novu
{
    /// <summary>
    /// The provider identifier (e.g., sendgrid, twilio, slack, etc.).<br/>
    /// Example: slack
    /// </summary>
    public enum GetChannelConnectionResponseDtoProviderId
    {
        /// <summary>
        /// 
        /// </summary>
        AfricasTalking,
        /// <summary>
        /// 
        /// </summary>
        AfroMessage,
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
        AzureSms,
        /// <summary>
        /// 
        /// </summary>
        Bandwidth,
        /// <summary>
        /// 
        /// </summary>
        Braze,
        /// <summary>
        /// 
        /// </summary>
        BrevoSms,
        /// <summary>
        /// 
        /// </summary>
        BulkSms,
        /// <summary>
        /// 
        /// </summary>
        BurstSms,
        /// <summary>
        /// 
        /// </summary>
        ChatWebhook,
        /// <summary>
        /// 
        /// </summary>
        Clickatell,
        /// <summary>
        /// 
        /// </summary>
        Clicksend,
        /// <summary>
        /// 
        /// </summary>
        Discord,
        /// <summary>
        /// 
        /// </summary>
        EazySms,
        /// <summary>
        /// 
        /// </summary>
        EmailWebhook,
        /// <summary>
        /// 
        /// </summary>
        Emailjs,
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
        Firetext,
        /// <summary>
        /// 
        /// </summary>
        FortySixElks,
        /// <summary>
        /// 
        /// </summary>
        GenericSms,
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
        Gupshup,
        /// <summary>
        /// 
        /// </summary>
        Imedia,
        /// <summary>
        /// 
        /// </summary>
        InfobipEmail,
        /// <summary>
        /// 
        /// </summary>
        InfobipSms,
        /// <summary>
        /// 
        /// </summary>
        IsendSms,
        /// <summary>
        /// 
        /// </summary>
        IsendproSms,
        /// <summary>
        /// 
        /// </summary>
        Kannel,
        /// <summary>
        /// 
        /// </summary>
        Mailersend,
        /// <summary>
        /// 
        /// </summary>
        Mailgun,
        /// <summary>
        /// 
        /// </summary>
        Mailjet,
        /// <summary>
        /// 
        /// </summary>
        Mailtrap,
        /// <summary>
        /// 
        /// </summary>
        Mandrill,
        /// <summary>
        /// 
        /// </summary>
        Maqsam,
        /// <summary>
        /// 
        /// </summary>
        Mattermost,
        /// <summary>
        /// 
        /// </summary>
        Messagebird,
        /// <summary>
        /// 
        /// </summary>
        Mobishastra,
        /// <summary>
        /// 
        /// </summary>
        Msteams,
        /// <summary>
        /// 
        /// </summary>
        Netcore,
        /// <summary>
        /// 
        /// </summary>
        Nexmo,
        /// <summary>
        /// 
        /// </summary>
        Nodemailer,
        /// <summary>
        /// 
        /// </summary>
        Novu,
        /// <summary>
        /// 
        /// </summary>
        NovuEmail,
        /// <summary>
        /// 
        /// </summary>
        NovuSlack,
        /// <summary>
        /// 
        /// </summary>
        NovuSms,
        /// <summary>
        /// 
        /// </summary>
        OneSignal,
        /// <summary>
        /// 
        /// </summary>
        Outlook365,
        /// <summary>
        /// 
        /// </summary>
        Plivo,
        /// <summary>
        /// 
        /// </summary>
        Plunk,
        /// <summary>
        /// 
        /// </summary>
        Postmark,
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
        Resend,
        /// <summary>
        /// 
        /// </summary>
        RingCentral,
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
        Sendchamp,
        /// <summary>
        /// 
        /// </summary>
        Sendgrid,
        /// <summary>
        /// 
        /// </summary>
        Sendinblue,
        /// <summary>
        /// 
        /// </summary>
        Ses,
        /// <summary>
        /// 
        /// </summary>
        Simpletexting,
        /// <summary>
        /// 
        /// </summary>
        Sinch,
        /// <summary>
        /// 
        /// </summary>
        Slack,
        /// <summary>
        /// 
        /// </summary>
        SmsCentral,
        /// <summary>
        /// 
        /// </summary>
        Sms77,
        /// <summary>
        /// 
        /// </summary>
        Smsmode,
        /// <summary>
        /// 
        /// </summary>
        Sns,
        /// <summary>
        /// 
        /// </summary>
        Sparkpost,
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
        /// <summary>
        /// 
        /// </summary>
        Termii,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Unifonic,
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
    public static class GetChannelConnectionResponseDtoProviderIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelConnectionResponseDtoProviderId value)
        {
            return value switch
            {
                GetChannelConnectionResponseDtoProviderId.AfricasTalking => "africas-talking",
                GetChannelConnectionResponseDtoProviderId.AfroMessage => "afro-message",
                GetChannelConnectionResponseDtoProviderId.Apns => "apns",
                GetChannelConnectionResponseDtoProviderId.Appio => "appio",
                GetChannelConnectionResponseDtoProviderId.AzureSms => "azure-sms",
                GetChannelConnectionResponseDtoProviderId.Bandwidth => "bandwidth",
                GetChannelConnectionResponseDtoProviderId.Braze => "braze",
                GetChannelConnectionResponseDtoProviderId.BrevoSms => "brevo-sms",
                GetChannelConnectionResponseDtoProviderId.BulkSms => "bulk-sms",
                GetChannelConnectionResponseDtoProviderId.BurstSms => "burst-sms",
                GetChannelConnectionResponseDtoProviderId.ChatWebhook => "chat-webhook",
                GetChannelConnectionResponseDtoProviderId.Clickatell => "clickatell",
                GetChannelConnectionResponseDtoProviderId.Clicksend => "clicksend",
                GetChannelConnectionResponseDtoProviderId.Discord => "discord",
                GetChannelConnectionResponseDtoProviderId.EazySms => "eazy-sms",
                GetChannelConnectionResponseDtoProviderId.EmailWebhook => "email-webhook",
                GetChannelConnectionResponseDtoProviderId.Emailjs => "emailjs",
                GetChannelConnectionResponseDtoProviderId.Expo => "expo",
                GetChannelConnectionResponseDtoProviderId.Fcm => "fcm",
                GetChannelConnectionResponseDtoProviderId.Firetext => "firetext",
                GetChannelConnectionResponseDtoProviderId.FortySixElks => "forty-six-elks",
                GetChannelConnectionResponseDtoProviderId.GenericSms => "generic-sms",
                GetChannelConnectionResponseDtoProviderId.Getstream => "getstream",
                GetChannelConnectionResponseDtoProviderId.GrafanaOnCall => "grafana-on-call",
                GetChannelConnectionResponseDtoProviderId.Gupshup => "gupshup",
                GetChannelConnectionResponseDtoProviderId.Imedia => "imedia",
                GetChannelConnectionResponseDtoProviderId.InfobipEmail => "infobip-email",
                GetChannelConnectionResponseDtoProviderId.InfobipSms => "infobip-sms",
                GetChannelConnectionResponseDtoProviderId.IsendSms => "isend-sms",
                GetChannelConnectionResponseDtoProviderId.IsendproSms => "isendpro-sms",
                GetChannelConnectionResponseDtoProviderId.Kannel => "kannel",
                GetChannelConnectionResponseDtoProviderId.Mailersend => "mailersend",
                GetChannelConnectionResponseDtoProviderId.Mailgun => "mailgun",
                GetChannelConnectionResponseDtoProviderId.Mailjet => "mailjet",
                GetChannelConnectionResponseDtoProviderId.Mailtrap => "mailtrap",
                GetChannelConnectionResponseDtoProviderId.Mandrill => "mandrill",
                GetChannelConnectionResponseDtoProviderId.Maqsam => "maqsam",
                GetChannelConnectionResponseDtoProviderId.Mattermost => "mattermost",
                GetChannelConnectionResponseDtoProviderId.Messagebird => "messagebird",
                GetChannelConnectionResponseDtoProviderId.Mobishastra => "mobishastra",
                GetChannelConnectionResponseDtoProviderId.Msteams => "msteams",
                GetChannelConnectionResponseDtoProviderId.Netcore => "netcore",
                GetChannelConnectionResponseDtoProviderId.Nexmo => "nexmo",
                GetChannelConnectionResponseDtoProviderId.Nodemailer => "nodemailer",
                GetChannelConnectionResponseDtoProviderId.Novu => "novu",
                GetChannelConnectionResponseDtoProviderId.NovuEmail => "novu-email",
                GetChannelConnectionResponseDtoProviderId.NovuSlack => "novu-slack",
                GetChannelConnectionResponseDtoProviderId.NovuSms => "novu-sms",
                GetChannelConnectionResponseDtoProviderId.OneSignal => "one-signal",
                GetChannelConnectionResponseDtoProviderId.Outlook365 => "outlook365",
                GetChannelConnectionResponseDtoProviderId.Plivo => "plivo",
                GetChannelConnectionResponseDtoProviderId.Plunk => "plunk",
                GetChannelConnectionResponseDtoProviderId.Postmark => "postmark",
                GetChannelConnectionResponseDtoProviderId.PushWebhook => "push-webhook",
                GetChannelConnectionResponseDtoProviderId.PusherBeams => "pusher-beams",
                GetChannelConnectionResponseDtoProviderId.Pushpad => "pushpad",
                GetChannelConnectionResponseDtoProviderId.Resend => "resend",
                GetChannelConnectionResponseDtoProviderId.RingCentral => "ring-central",
                GetChannelConnectionResponseDtoProviderId.RocketChat => "rocket-chat",
                GetChannelConnectionResponseDtoProviderId.Ryver => "ryver",
                GetChannelConnectionResponseDtoProviderId.Sendchamp => "sendchamp",
                GetChannelConnectionResponseDtoProviderId.Sendgrid => "sendgrid",
                GetChannelConnectionResponseDtoProviderId.Sendinblue => "sendinblue",
                GetChannelConnectionResponseDtoProviderId.Ses => "ses",
                GetChannelConnectionResponseDtoProviderId.Simpletexting => "simpletexting",
                GetChannelConnectionResponseDtoProviderId.Sinch => "sinch",
                GetChannelConnectionResponseDtoProviderId.Slack => "slack",
                GetChannelConnectionResponseDtoProviderId.SmsCentral => "sms-central",
                GetChannelConnectionResponseDtoProviderId.Sms77 => "sms77",
                GetChannelConnectionResponseDtoProviderId.Smsmode => "smsmode",
                GetChannelConnectionResponseDtoProviderId.Sns => "sns",
                GetChannelConnectionResponseDtoProviderId.Sparkpost => "sparkpost",
                GetChannelConnectionResponseDtoProviderId.Telnyx => "telnyx",
                GetChannelConnectionResponseDtoProviderId.Termii => "termii",
                GetChannelConnectionResponseDtoProviderId.Twilio => "twilio",
                GetChannelConnectionResponseDtoProviderId.Unifonic => "unifonic",
                GetChannelConnectionResponseDtoProviderId.WhatsappBusiness => "whatsapp-business",
                GetChannelConnectionResponseDtoProviderId.Zulip => "zulip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChannelConnectionResponseDtoProviderId? ToEnum(string value)
        {
            return value switch
            {
                "africas-talking" => GetChannelConnectionResponseDtoProviderId.AfricasTalking,
                "afro-message" => GetChannelConnectionResponseDtoProviderId.AfroMessage,
                "apns" => GetChannelConnectionResponseDtoProviderId.Apns,
                "appio" => GetChannelConnectionResponseDtoProviderId.Appio,
                "azure-sms" => GetChannelConnectionResponseDtoProviderId.AzureSms,
                "bandwidth" => GetChannelConnectionResponseDtoProviderId.Bandwidth,
                "braze" => GetChannelConnectionResponseDtoProviderId.Braze,
                "brevo-sms" => GetChannelConnectionResponseDtoProviderId.BrevoSms,
                "bulk-sms" => GetChannelConnectionResponseDtoProviderId.BulkSms,
                "burst-sms" => GetChannelConnectionResponseDtoProviderId.BurstSms,
                "chat-webhook" => GetChannelConnectionResponseDtoProviderId.ChatWebhook,
                "clickatell" => GetChannelConnectionResponseDtoProviderId.Clickatell,
                "clicksend" => GetChannelConnectionResponseDtoProviderId.Clicksend,
                "discord" => GetChannelConnectionResponseDtoProviderId.Discord,
                "eazy-sms" => GetChannelConnectionResponseDtoProviderId.EazySms,
                "email-webhook" => GetChannelConnectionResponseDtoProviderId.EmailWebhook,
                "emailjs" => GetChannelConnectionResponseDtoProviderId.Emailjs,
                "expo" => GetChannelConnectionResponseDtoProviderId.Expo,
                "fcm" => GetChannelConnectionResponseDtoProviderId.Fcm,
                "firetext" => GetChannelConnectionResponseDtoProviderId.Firetext,
                "forty-six-elks" => GetChannelConnectionResponseDtoProviderId.FortySixElks,
                "generic-sms" => GetChannelConnectionResponseDtoProviderId.GenericSms,
                "getstream" => GetChannelConnectionResponseDtoProviderId.Getstream,
                "grafana-on-call" => GetChannelConnectionResponseDtoProviderId.GrafanaOnCall,
                "gupshup" => GetChannelConnectionResponseDtoProviderId.Gupshup,
                "imedia" => GetChannelConnectionResponseDtoProviderId.Imedia,
                "infobip-email" => GetChannelConnectionResponseDtoProviderId.InfobipEmail,
                "infobip-sms" => GetChannelConnectionResponseDtoProviderId.InfobipSms,
                "isend-sms" => GetChannelConnectionResponseDtoProviderId.IsendSms,
                "isendpro-sms" => GetChannelConnectionResponseDtoProviderId.IsendproSms,
                "kannel" => GetChannelConnectionResponseDtoProviderId.Kannel,
                "mailersend" => GetChannelConnectionResponseDtoProviderId.Mailersend,
                "mailgun" => GetChannelConnectionResponseDtoProviderId.Mailgun,
                "mailjet" => GetChannelConnectionResponseDtoProviderId.Mailjet,
                "mailtrap" => GetChannelConnectionResponseDtoProviderId.Mailtrap,
                "mandrill" => GetChannelConnectionResponseDtoProviderId.Mandrill,
                "maqsam" => GetChannelConnectionResponseDtoProviderId.Maqsam,
                "mattermost" => GetChannelConnectionResponseDtoProviderId.Mattermost,
                "messagebird" => GetChannelConnectionResponseDtoProviderId.Messagebird,
                "mobishastra" => GetChannelConnectionResponseDtoProviderId.Mobishastra,
                "msteams" => GetChannelConnectionResponseDtoProviderId.Msteams,
                "netcore" => GetChannelConnectionResponseDtoProviderId.Netcore,
                "nexmo" => GetChannelConnectionResponseDtoProviderId.Nexmo,
                "nodemailer" => GetChannelConnectionResponseDtoProviderId.Nodemailer,
                "novu" => GetChannelConnectionResponseDtoProviderId.Novu,
                "novu-email" => GetChannelConnectionResponseDtoProviderId.NovuEmail,
                "novu-slack" => GetChannelConnectionResponseDtoProviderId.NovuSlack,
                "novu-sms" => GetChannelConnectionResponseDtoProviderId.NovuSms,
                "one-signal" => GetChannelConnectionResponseDtoProviderId.OneSignal,
                "outlook365" => GetChannelConnectionResponseDtoProviderId.Outlook365,
                "plivo" => GetChannelConnectionResponseDtoProviderId.Plivo,
                "plunk" => GetChannelConnectionResponseDtoProviderId.Plunk,
                "postmark" => GetChannelConnectionResponseDtoProviderId.Postmark,
                "push-webhook" => GetChannelConnectionResponseDtoProviderId.PushWebhook,
                "pusher-beams" => GetChannelConnectionResponseDtoProviderId.PusherBeams,
                "pushpad" => GetChannelConnectionResponseDtoProviderId.Pushpad,
                "resend" => GetChannelConnectionResponseDtoProviderId.Resend,
                "ring-central" => GetChannelConnectionResponseDtoProviderId.RingCentral,
                "rocket-chat" => GetChannelConnectionResponseDtoProviderId.RocketChat,
                "ryver" => GetChannelConnectionResponseDtoProviderId.Ryver,
                "sendchamp" => GetChannelConnectionResponseDtoProviderId.Sendchamp,
                "sendgrid" => GetChannelConnectionResponseDtoProviderId.Sendgrid,
                "sendinblue" => GetChannelConnectionResponseDtoProviderId.Sendinblue,
                "ses" => GetChannelConnectionResponseDtoProviderId.Ses,
                "simpletexting" => GetChannelConnectionResponseDtoProviderId.Simpletexting,
                "sinch" => GetChannelConnectionResponseDtoProviderId.Sinch,
                "slack" => GetChannelConnectionResponseDtoProviderId.Slack,
                "sms-central" => GetChannelConnectionResponseDtoProviderId.SmsCentral,
                "sms77" => GetChannelConnectionResponseDtoProviderId.Sms77,
                "smsmode" => GetChannelConnectionResponseDtoProviderId.Smsmode,
                "sns" => GetChannelConnectionResponseDtoProviderId.Sns,
                "sparkpost" => GetChannelConnectionResponseDtoProviderId.Sparkpost,
                "telnyx" => GetChannelConnectionResponseDtoProviderId.Telnyx,
                "termii" => GetChannelConnectionResponseDtoProviderId.Termii,
                "twilio" => GetChannelConnectionResponseDtoProviderId.Twilio,
                "unifonic" => GetChannelConnectionResponseDtoProviderId.Unifonic,
                "whatsapp-business" => GetChannelConnectionResponseDtoProviderId.WhatsappBusiness,
                "zulip" => GetChannelConnectionResponseDtoProviderId.Zulip,
                _ => null,
            };
        }
    }
}