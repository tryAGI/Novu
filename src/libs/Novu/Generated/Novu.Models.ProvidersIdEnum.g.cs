
#nullable enable

namespace Novu
{
    /// <summary>
    /// Provider ID of the job
    /// </summary>
    public enum ProvidersIdEnum
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
    public static class ProvidersIdEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersIdEnum value)
        {
            return value switch
            {
                ProvidersIdEnum.AfricasTalking => "africas-talking",
                ProvidersIdEnum.AfroMessage => "afro-message",
                ProvidersIdEnum.Apns => "apns",
                ProvidersIdEnum.Appio => "appio",
                ProvidersIdEnum.AzureSms => "azure-sms",
                ProvidersIdEnum.Bandwidth => "bandwidth",
                ProvidersIdEnum.Braze => "braze",
                ProvidersIdEnum.BrevoSms => "brevo-sms",
                ProvidersIdEnum.BulkSms => "bulk-sms",
                ProvidersIdEnum.BurstSms => "burst-sms",
                ProvidersIdEnum.ChatWebhook => "chat-webhook",
                ProvidersIdEnum.Clickatell => "clickatell",
                ProvidersIdEnum.Clicksend => "clicksend",
                ProvidersIdEnum.Discord => "discord",
                ProvidersIdEnum.EazySms => "eazy-sms",
                ProvidersIdEnum.EmailWebhook => "email-webhook",
                ProvidersIdEnum.Emailjs => "emailjs",
                ProvidersIdEnum.Expo => "expo",
                ProvidersIdEnum.Fcm => "fcm",
                ProvidersIdEnum.Firetext => "firetext",
                ProvidersIdEnum.FortySixElks => "forty-six-elks",
                ProvidersIdEnum.GenericSms => "generic-sms",
                ProvidersIdEnum.Getstream => "getstream",
                ProvidersIdEnum.GrafanaOnCall => "grafana-on-call",
                ProvidersIdEnum.Gupshup => "gupshup",
                ProvidersIdEnum.Imedia => "imedia",
                ProvidersIdEnum.InfobipEmail => "infobip-email",
                ProvidersIdEnum.InfobipSms => "infobip-sms",
                ProvidersIdEnum.IsendSms => "isend-sms",
                ProvidersIdEnum.IsendproSms => "isendpro-sms",
                ProvidersIdEnum.Kannel => "kannel",
                ProvidersIdEnum.Mailersend => "mailersend",
                ProvidersIdEnum.Mailgun => "mailgun",
                ProvidersIdEnum.Mailjet => "mailjet",
                ProvidersIdEnum.Mailtrap => "mailtrap",
                ProvidersIdEnum.Mandrill => "mandrill",
                ProvidersIdEnum.Maqsam => "maqsam",
                ProvidersIdEnum.Mattermost => "mattermost",
                ProvidersIdEnum.Messagebird => "messagebird",
                ProvidersIdEnum.Mobishastra => "mobishastra",
                ProvidersIdEnum.Msteams => "msteams",
                ProvidersIdEnum.Netcore => "netcore",
                ProvidersIdEnum.Nexmo => "nexmo",
                ProvidersIdEnum.Nodemailer => "nodemailer",
                ProvidersIdEnum.Novu => "novu",
                ProvidersIdEnum.NovuEmail => "novu-email",
                ProvidersIdEnum.NovuSlack => "novu-slack",
                ProvidersIdEnum.NovuSms => "novu-sms",
                ProvidersIdEnum.OneSignal => "one-signal",
                ProvidersIdEnum.Outlook365 => "outlook365",
                ProvidersIdEnum.Plivo => "plivo",
                ProvidersIdEnum.Plunk => "plunk",
                ProvidersIdEnum.Postmark => "postmark",
                ProvidersIdEnum.PushWebhook => "push-webhook",
                ProvidersIdEnum.PusherBeams => "pusher-beams",
                ProvidersIdEnum.Pushpad => "pushpad",
                ProvidersIdEnum.Resend => "resend",
                ProvidersIdEnum.RingCentral => "ring-central",
                ProvidersIdEnum.RocketChat => "rocket-chat",
                ProvidersIdEnum.Ryver => "ryver",
                ProvidersIdEnum.Sendchamp => "sendchamp",
                ProvidersIdEnum.Sendgrid => "sendgrid",
                ProvidersIdEnum.Sendinblue => "sendinblue",
                ProvidersIdEnum.Ses => "ses",
                ProvidersIdEnum.Simpletexting => "simpletexting",
                ProvidersIdEnum.Sinch => "sinch",
                ProvidersIdEnum.Slack => "slack",
                ProvidersIdEnum.SmsCentral => "sms-central",
                ProvidersIdEnum.Sms77 => "sms77",
                ProvidersIdEnum.Smsmode => "smsmode",
                ProvidersIdEnum.Sns => "sns",
                ProvidersIdEnum.Sparkpost => "sparkpost",
                ProvidersIdEnum.Telnyx => "telnyx",
                ProvidersIdEnum.Termii => "termii",
                ProvidersIdEnum.Twilio => "twilio",
                ProvidersIdEnum.Unifonic => "unifonic",
                ProvidersIdEnum.WhatsappBusiness => "whatsapp-business",
                ProvidersIdEnum.Zulip => "zulip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersIdEnum? ToEnum(string value)
        {
            return value switch
            {
                "africas-talking" => ProvidersIdEnum.AfricasTalking,
                "afro-message" => ProvidersIdEnum.AfroMessage,
                "apns" => ProvidersIdEnum.Apns,
                "appio" => ProvidersIdEnum.Appio,
                "azure-sms" => ProvidersIdEnum.AzureSms,
                "bandwidth" => ProvidersIdEnum.Bandwidth,
                "braze" => ProvidersIdEnum.Braze,
                "brevo-sms" => ProvidersIdEnum.BrevoSms,
                "bulk-sms" => ProvidersIdEnum.BulkSms,
                "burst-sms" => ProvidersIdEnum.BurstSms,
                "chat-webhook" => ProvidersIdEnum.ChatWebhook,
                "clickatell" => ProvidersIdEnum.Clickatell,
                "clicksend" => ProvidersIdEnum.Clicksend,
                "discord" => ProvidersIdEnum.Discord,
                "eazy-sms" => ProvidersIdEnum.EazySms,
                "email-webhook" => ProvidersIdEnum.EmailWebhook,
                "emailjs" => ProvidersIdEnum.Emailjs,
                "expo" => ProvidersIdEnum.Expo,
                "fcm" => ProvidersIdEnum.Fcm,
                "firetext" => ProvidersIdEnum.Firetext,
                "forty-six-elks" => ProvidersIdEnum.FortySixElks,
                "generic-sms" => ProvidersIdEnum.GenericSms,
                "getstream" => ProvidersIdEnum.Getstream,
                "grafana-on-call" => ProvidersIdEnum.GrafanaOnCall,
                "gupshup" => ProvidersIdEnum.Gupshup,
                "imedia" => ProvidersIdEnum.Imedia,
                "infobip-email" => ProvidersIdEnum.InfobipEmail,
                "infobip-sms" => ProvidersIdEnum.InfobipSms,
                "isend-sms" => ProvidersIdEnum.IsendSms,
                "isendpro-sms" => ProvidersIdEnum.IsendproSms,
                "kannel" => ProvidersIdEnum.Kannel,
                "mailersend" => ProvidersIdEnum.Mailersend,
                "mailgun" => ProvidersIdEnum.Mailgun,
                "mailjet" => ProvidersIdEnum.Mailjet,
                "mailtrap" => ProvidersIdEnum.Mailtrap,
                "mandrill" => ProvidersIdEnum.Mandrill,
                "maqsam" => ProvidersIdEnum.Maqsam,
                "mattermost" => ProvidersIdEnum.Mattermost,
                "messagebird" => ProvidersIdEnum.Messagebird,
                "mobishastra" => ProvidersIdEnum.Mobishastra,
                "msteams" => ProvidersIdEnum.Msteams,
                "netcore" => ProvidersIdEnum.Netcore,
                "nexmo" => ProvidersIdEnum.Nexmo,
                "nodemailer" => ProvidersIdEnum.Nodemailer,
                "novu" => ProvidersIdEnum.Novu,
                "novu-email" => ProvidersIdEnum.NovuEmail,
                "novu-slack" => ProvidersIdEnum.NovuSlack,
                "novu-sms" => ProvidersIdEnum.NovuSms,
                "one-signal" => ProvidersIdEnum.OneSignal,
                "outlook365" => ProvidersIdEnum.Outlook365,
                "plivo" => ProvidersIdEnum.Plivo,
                "plunk" => ProvidersIdEnum.Plunk,
                "postmark" => ProvidersIdEnum.Postmark,
                "push-webhook" => ProvidersIdEnum.PushWebhook,
                "pusher-beams" => ProvidersIdEnum.PusherBeams,
                "pushpad" => ProvidersIdEnum.Pushpad,
                "resend" => ProvidersIdEnum.Resend,
                "ring-central" => ProvidersIdEnum.RingCentral,
                "rocket-chat" => ProvidersIdEnum.RocketChat,
                "ryver" => ProvidersIdEnum.Ryver,
                "sendchamp" => ProvidersIdEnum.Sendchamp,
                "sendgrid" => ProvidersIdEnum.Sendgrid,
                "sendinblue" => ProvidersIdEnum.Sendinblue,
                "ses" => ProvidersIdEnum.Ses,
                "simpletexting" => ProvidersIdEnum.Simpletexting,
                "sinch" => ProvidersIdEnum.Sinch,
                "slack" => ProvidersIdEnum.Slack,
                "sms-central" => ProvidersIdEnum.SmsCentral,
                "sms77" => ProvidersIdEnum.Sms77,
                "smsmode" => ProvidersIdEnum.Smsmode,
                "sns" => ProvidersIdEnum.Sns,
                "sparkpost" => ProvidersIdEnum.Sparkpost,
                "telnyx" => ProvidersIdEnum.Telnyx,
                "termii" => ProvidersIdEnum.Termii,
                "twilio" => ProvidersIdEnum.Twilio,
                "unifonic" => ProvidersIdEnum.Unifonic,
                "whatsapp-business" => ProvidersIdEnum.WhatsappBusiness,
                "zulip" => ProvidersIdEnum.Zulip,
                _ => null,
            };
        }
    }
}