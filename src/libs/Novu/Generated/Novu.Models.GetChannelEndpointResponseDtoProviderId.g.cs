
#nullable enable

namespace Novu
{
    /// <summary>
    /// The provider identifier (e.g., sendgrid, twilio, slack, etc.).<br/>
    /// Example: slack
    /// </summary>
    public enum GetChannelEndpointResponseDtoProviderId
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
        CmTelecom,
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
    public static class GetChannelEndpointResponseDtoProviderIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelEndpointResponseDtoProviderId value)
        {
            return value switch
            {
                GetChannelEndpointResponseDtoProviderId.AfricasTalking => "africas-talking",
                GetChannelEndpointResponseDtoProviderId.AfroMessage => "afro-message",
                GetChannelEndpointResponseDtoProviderId.Apns => "apns",
                GetChannelEndpointResponseDtoProviderId.Appio => "appio",
                GetChannelEndpointResponseDtoProviderId.AzureSms => "azure-sms",
                GetChannelEndpointResponseDtoProviderId.Bandwidth => "bandwidth",
                GetChannelEndpointResponseDtoProviderId.Braze => "braze",
                GetChannelEndpointResponseDtoProviderId.BrevoSms => "brevo-sms",
                GetChannelEndpointResponseDtoProviderId.BulkSms => "bulk-sms",
                GetChannelEndpointResponseDtoProviderId.BurstSms => "burst-sms",
                GetChannelEndpointResponseDtoProviderId.ChatWebhook => "chat-webhook",
                GetChannelEndpointResponseDtoProviderId.Clickatell => "clickatell",
                GetChannelEndpointResponseDtoProviderId.Clicksend => "clicksend",
                GetChannelEndpointResponseDtoProviderId.CmTelecom => "cm-telecom",
                GetChannelEndpointResponseDtoProviderId.Discord => "discord",
                GetChannelEndpointResponseDtoProviderId.EazySms => "eazy-sms",
                GetChannelEndpointResponseDtoProviderId.EmailWebhook => "email-webhook",
                GetChannelEndpointResponseDtoProviderId.Emailjs => "emailjs",
                GetChannelEndpointResponseDtoProviderId.Expo => "expo",
                GetChannelEndpointResponseDtoProviderId.Fcm => "fcm",
                GetChannelEndpointResponseDtoProviderId.Firetext => "firetext",
                GetChannelEndpointResponseDtoProviderId.FortySixElks => "forty-six-elks",
                GetChannelEndpointResponseDtoProviderId.GenericSms => "generic-sms",
                GetChannelEndpointResponseDtoProviderId.Getstream => "getstream",
                GetChannelEndpointResponseDtoProviderId.GrafanaOnCall => "grafana-on-call",
                GetChannelEndpointResponseDtoProviderId.Gupshup => "gupshup",
                GetChannelEndpointResponseDtoProviderId.Imedia => "imedia",
                GetChannelEndpointResponseDtoProviderId.InfobipEmail => "infobip-email",
                GetChannelEndpointResponseDtoProviderId.InfobipSms => "infobip-sms",
                GetChannelEndpointResponseDtoProviderId.IsendSms => "isend-sms",
                GetChannelEndpointResponseDtoProviderId.IsendproSms => "isendpro-sms",
                GetChannelEndpointResponseDtoProviderId.Kannel => "kannel",
                GetChannelEndpointResponseDtoProviderId.Mailersend => "mailersend",
                GetChannelEndpointResponseDtoProviderId.Mailgun => "mailgun",
                GetChannelEndpointResponseDtoProviderId.Mailjet => "mailjet",
                GetChannelEndpointResponseDtoProviderId.Mailtrap => "mailtrap",
                GetChannelEndpointResponseDtoProviderId.Mandrill => "mandrill",
                GetChannelEndpointResponseDtoProviderId.Maqsam => "maqsam",
                GetChannelEndpointResponseDtoProviderId.Mattermost => "mattermost",
                GetChannelEndpointResponseDtoProviderId.Messagebird => "messagebird",
                GetChannelEndpointResponseDtoProviderId.Mobishastra => "mobishastra",
                GetChannelEndpointResponseDtoProviderId.Msteams => "msteams",
                GetChannelEndpointResponseDtoProviderId.Netcore => "netcore",
                GetChannelEndpointResponseDtoProviderId.Nexmo => "nexmo",
                GetChannelEndpointResponseDtoProviderId.Nodemailer => "nodemailer",
                GetChannelEndpointResponseDtoProviderId.Novu => "novu",
                GetChannelEndpointResponseDtoProviderId.NovuEmail => "novu-email",
                GetChannelEndpointResponseDtoProviderId.NovuSlack => "novu-slack",
                GetChannelEndpointResponseDtoProviderId.NovuSms => "novu-sms",
                GetChannelEndpointResponseDtoProviderId.OneSignal => "one-signal",
                GetChannelEndpointResponseDtoProviderId.Outlook365 => "outlook365",
                GetChannelEndpointResponseDtoProviderId.Plivo => "plivo",
                GetChannelEndpointResponseDtoProviderId.Plunk => "plunk",
                GetChannelEndpointResponseDtoProviderId.Postmark => "postmark",
                GetChannelEndpointResponseDtoProviderId.PushWebhook => "push-webhook",
                GetChannelEndpointResponseDtoProviderId.PusherBeams => "pusher-beams",
                GetChannelEndpointResponseDtoProviderId.Pushpad => "pushpad",
                GetChannelEndpointResponseDtoProviderId.Resend => "resend",
                GetChannelEndpointResponseDtoProviderId.RingCentral => "ring-central",
                GetChannelEndpointResponseDtoProviderId.RocketChat => "rocket-chat",
                GetChannelEndpointResponseDtoProviderId.Ryver => "ryver",
                GetChannelEndpointResponseDtoProviderId.Sendchamp => "sendchamp",
                GetChannelEndpointResponseDtoProviderId.Sendgrid => "sendgrid",
                GetChannelEndpointResponseDtoProviderId.Sendinblue => "sendinblue",
                GetChannelEndpointResponseDtoProviderId.Ses => "ses",
                GetChannelEndpointResponseDtoProviderId.Simpletexting => "simpletexting",
                GetChannelEndpointResponseDtoProviderId.Sinch => "sinch",
                GetChannelEndpointResponseDtoProviderId.Slack => "slack",
                GetChannelEndpointResponseDtoProviderId.SmsCentral => "sms-central",
                GetChannelEndpointResponseDtoProviderId.Sms77 => "sms77",
                GetChannelEndpointResponseDtoProviderId.Smsmode => "smsmode",
                GetChannelEndpointResponseDtoProviderId.Sns => "sns",
                GetChannelEndpointResponseDtoProviderId.Sparkpost => "sparkpost",
                GetChannelEndpointResponseDtoProviderId.Telnyx => "telnyx",
                GetChannelEndpointResponseDtoProviderId.Termii => "termii",
                GetChannelEndpointResponseDtoProviderId.Twilio => "twilio",
                GetChannelEndpointResponseDtoProviderId.Unifonic => "unifonic",
                GetChannelEndpointResponseDtoProviderId.WhatsappBusiness => "whatsapp-business",
                GetChannelEndpointResponseDtoProviderId.Zulip => "zulip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChannelEndpointResponseDtoProviderId? ToEnum(string value)
        {
            return value switch
            {
                "africas-talking" => GetChannelEndpointResponseDtoProviderId.AfricasTalking,
                "afro-message" => GetChannelEndpointResponseDtoProviderId.AfroMessage,
                "apns" => GetChannelEndpointResponseDtoProviderId.Apns,
                "appio" => GetChannelEndpointResponseDtoProviderId.Appio,
                "azure-sms" => GetChannelEndpointResponseDtoProviderId.AzureSms,
                "bandwidth" => GetChannelEndpointResponseDtoProviderId.Bandwidth,
                "braze" => GetChannelEndpointResponseDtoProviderId.Braze,
                "brevo-sms" => GetChannelEndpointResponseDtoProviderId.BrevoSms,
                "bulk-sms" => GetChannelEndpointResponseDtoProviderId.BulkSms,
                "burst-sms" => GetChannelEndpointResponseDtoProviderId.BurstSms,
                "chat-webhook" => GetChannelEndpointResponseDtoProviderId.ChatWebhook,
                "clickatell" => GetChannelEndpointResponseDtoProviderId.Clickatell,
                "clicksend" => GetChannelEndpointResponseDtoProviderId.Clicksend,
                "cm-telecom" => GetChannelEndpointResponseDtoProviderId.CmTelecom,
                "discord" => GetChannelEndpointResponseDtoProviderId.Discord,
                "eazy-sms" => GetChannelEndpointResponseDtoProviderId.EazySms,
                "email-webhook" => GetChannelEndpointResponseDtoProviderId.EmailWebhook,
                "emailjs" => GetChannelEndpointResponseDtoProviderId.Emailjs,
                "expo" => GetChannelEndpointResponseDtoProviderId.Expo,
                "fcm" => GetChannelEndpointResponseDtoProviderId.Fcm,
                "firetext" => GetChannelEndpointResponseDtoProviderId.Firetext,
                "forty-six-elks" => GetChannelEndpointResponseDtoProviderId.FortySixElks,
                "generic-sms" => GetChannelEndpointResponseDtoProviderId.GenericSms,
                "getstream" => GetChannelEndpointResponseDtoProviderId.Getstream,
                "grafana-on-call" => GetChannelEndpointResponseDtoProviderId.GrafanaOnCall,
                "gupshup" => GetChannelEndpointResponseDtoProviderId.Gupshup,
                "imedia" => GetChannelEndpointResponseDtoProviderId.Imedia,
                "infobip-email" => GetChannelEndpointResponseDtoProviderId.InfobipEmail,
                "infobip-sms" => GetChannelEndpointResponseDtoProviderId.InfobipSms,
                "isend-sms" => GetChannelEndpointResponseDtoProviderId.IsendSms,
                "isendpro-sms" => GetChannelEndpointResponseDtoProviderId.IsendproSms,
                "kannel" => GetChannelEndpointResponseDtoProviderId.Kannel,
                "mailersend" => GetChannelEndpointResponseDtoProviderId.Mailersend,
                "mailgun" => GetChannelEndpointResponseDtoProviderId.Mailgun,
                "mailjet" => GetChannelEndpointResponseDtoProviderId.Mailjet,
                "mailtrap" => GetChannelEndpointResponseDtoProviderId.Mailtrap,
                "mandrill" => GetChannelEndpointResponseDtoProviderId.Mandrill,
                "maqsam" => GetChannelEndpointResponseDtoProviderId.Maqsam,
                "mattermost" => GetChannelEndpointResponseDtoProviderId.Mattermost,
                "messagebird" => GetChannelEndpointResponseDtoProviderId.Messagebird,
                "mobishastra" => GetChannelEndpointResponseDtoProviderId.Mobishastra,
                "msteams" => GetChannelEndpointResponseDtoProviderId.Msteams,
                "netcore" => GetChannelEndpointResponseDtoProviderId.Netcore,
                "nexmo" => GetChannelEndpointResponseDtoProviderId.Nexmo,
                "nodemailer" => GetChannelEndpointResponseDtoProviderId.Nodemailer,
                "novu" => GetChannelEndpointResponseDtoProviderId.Novu,
                "novu-email" => GetChannelEndpointResponseDtoProviderId.NovuEmail,
                "novu-slack" => GetChannelEndpointResponseDtoProviderId.NovuSlack,
                "novu-sms" => GetChannelEndpointResponseDtoProviderId.NovuSms,
                "one-signal" => GetChannelEndpointResponseDtoProviderId.OneSignal,
                "outlook365" => GetChannelEndpointResponseDtoProviderId.Outlook365,
                "plivo" => GetChannelEndpointResponseDtoProviderId.Plivo,
                "plunk" => GetChannelEndpointResponseDtoProviderId.Plunk,
                "postmark" => GetChannelEndpointResponseDtoProviderId.Postmark,
                "push-webhook" => GetChannelEndpointResponseDtoProviderId.PushWebhook,
                "pusher-beams" => GetChannelEndpointResponseDtoProviderId.PusherBeams,
                "pushpad" => GetChannelEndpointResponseDtoProviderId.Pushpad,
                "resend" => GetChannelEndpointResponseDtoProviderId.Resend,
                "ring-central" => GetChannelEndpointResponseDtoProviderId.RingCentral,
                "rocket-chat" => GetChannelEndpointResponseDtoProviderId.RocketChat,
                "ryver" => GetChannelEndpointResponseDtoProviderId.Ryver,
                "sendchamp" => GetChannelEndpointResponseDtoProviderId.Sendchamp,
                "sendgrid" => GetChannelEndpointResponseDtoProviderId.Sendgrid,
                "sendinblue" => GetChannelEndpointResponseDtoProviderId.Sendinblue,
                "ses" => GetChannelEndpointResponseDtoProviderId.Ses,
                "simpletexting" => GetChannelEndpointResponseDtoProviderId.Simpletexting,
                "sinch" => GetChannelEndpointResponseDtoProviderId.Sinch,
                "slack" => GetChannelEndpointResponseDtoProviderId.Slack,
                "sms-central" => GetChannelEndpointResponseDtoProviderId.SmsCentral,
                "sms77" => GetChannelEndpointResponseDtoProviderId.Sms77,
                "smsmode" => GetChannelEndpointResponseDtoProviderId.Smsmode,
                "sns" => GetChannelEndpointResponseDtoProviderId.Sns,
                "sparkpost" => GetChannelEndpointResponseDtoProviderId.Sparkpost,
                "telnyx" => GetChannelEndpointResponseDtoProviderId.Telnyx,
                "termii" => GetChannelEndpointResponseDtoProviderId.Termii,
                "twilio" => GetChannelEndpointResponseDtoProviderId.Twilio,
                "unifonic" => GetChannelEndpointResponseDtoProviderId.Unifonic,
                "whatsapp-business" => GetChannelEndpointResponseDtoProviderId.WhatsappBusiness,
                "zulip" => GetChannelEndpointResponseDtoProviderId.Zulip,
                _ => null,
            };
        }
    }
}