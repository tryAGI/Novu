
#nullable enable

namespace Novu
{
    /// <summary>
    /// Component type for the UI Schema Property
    /// </summary>
    public enum UiComponentEnum
    {
        /// <summary>
        /// 
        /// </summary>
        BlockEditor,
        /// <summary>
        /// 
        /// </summary>
        ChatBody,
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        DelayAmount,
        /// <summary>
        /// 
        /// </summary>
        DelayCron,
        /// <summary>
        /// 
        /// </summary>
        DelayDynamicKey,
        /// <summary>
        /// 
        /// </summary>
        DelayType,
        /// <summary>
        /// 
        /// </summary>
        DelayUnit,
        /// <summary>
        /// 
        /// </summary>
        DestinationBody,
        /// <summary>
        /// 
        /// </summary>
        DestinationContinueOnFailure,
        /// <summary>
        /// 
        /// </summary>
        DestinationEnforceSchemaValidation,
        /// <summary>
        /// 
        /// </summary>
        DestinationHeaders,
        /// <summary>
        /// 
        /// </summary>
        DestinationMethod,
        /// <summary>
        /// 
        /// </summary>
        DestinationResponseBodySchema,
        /// <summary>
        /// 
        /// </summary>
        DestinationTimeout,
        /// <summary>
        /// 
        /// </summary>
        DestinationUrl,
        /// <summary>
        /// 
        /// </summary>
        DigestAmount,
        /// <summary>
        /// 
        /// </summary>
        DigestCron,
        /// <summary>
        /// 
        /// </summary>
        DigestKey,
        /// <summary>
        /// 
        /// </summary>
        DigestType,
        /// <summary>
        /// 
        /// </summary>
        DigestUnit,
        /// <summary>
        /// 
        /// </summary>
        DisableSanitizationSwitch,
        /// <summary>
        /// 
        /// </summary>
        EmailBody,
        /// <summary>
        /// 
        /// </summary>
        EmailEditorSelect,
        /// <summary>
        /// 
        /// </summary>
        ExtendToSchedule,
        /// <summary>
        /// 
        /// </summary>
        InAppAvatar,
        /// <summary>
        /// 
        /// </summary>
        InAppBody,
        /// <summary>
        /// 
        /// </summary>
        InAppButtonDropdown,
        /// <summary>
        /// 
        /// </summary>
        InAppDisableSanitizationSwitch,
        /// <summary>
        /// 
        /// </summary>
        InAppPrimarySubject,
        /// <summary>
        /// 
        /// </summary>
        LayoutEmail,
        /// <summary>
        /// 
        /// </summary>
        LayoutSelect,
        /// <summary>
        /// 
        /// </summary>
        PushBody,
        /// <summary>
        /// 
        /// </summary>
        PushSubject,
        /// <summary>
        /// 
        /// </summary>
        QueryEditor,
        /// <summary>
        /// 
        /// </summary>
        SmsBody,
        /// <summary>
        /// 
        /// </summary>
        TextFullLine,
        /// <summary>
        /// 
        /// </summary>
        TextInlineLabel,
        /// <summary>
        /// 
        /// </summary>
        ThrottleDynamicKey,
        /// <summary>
        /// 
        /// </summary>
        ThrottleKey,
        /// <summary>
        /// 
        /// </summary>
        ThrottleThreshold,
        /// <summary>
        /// 
        /// </summary>
        ThrottleType,
        /// <summary>
        /// 
        /// </summary>
        ThrottleUnit,
        /// <summary>
        /// 
        /// </summary>
        ThrottleWindow,
        /// <summary>
        /// 
        /// </summary>
        UrlTextBox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UiComponentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UiComponentEnum value)
        {
            return value switch
            {
                UiComponentEnum.BlockEditor => "BLOCK_EDITOR",
                UiComponentEnum.ChatBody => "CHAT_BODY",
                UiComponentEnum.Data => "DATA",
                UiComponentEnum.DelayAmount => "DELAY_AMOUNT",
                UiComponentEnum.DelayCron => "DELAY_CRON",
                UiComponentEnum.DelayDynamicKey => "DELAY_DYNAMIC_KEY",
                UiComponentEnum.DelayType => "DELAY_TYPE",
                UiComponentEnum.DelayUnit => "DELAY_UNIT",
                UiComponentEnum.DestinationBody => "DESTINATION_BODY",
                UiComponentEnum.DestinationContinueOnFailure => "DESTINATION_CONTINUE_ON_FAILURE",
                UiComponentEnum.DestinationEnforceSchemaValidation => "DESTINATION_ENFORCE_SCHEMA_VALIDATION",
                UiComponentEnum.DestinationHeaders => "DESTINATION_HEADERS",
                UiComponentEnum.DestinationMethod => "DESTINATION_METHOD",
                UiComponentEnum.DestinationResponseBodySchema => "DESTINATION_RESPONSE_BODY_SCHEMA",
                UiComponentEnum.DestinationTimeout => "DESTINATION_TIMEOUT",
                UiComponentEnum.DestinationUrl => "DESTINATION_URL",
                UiComponentEnum.DigestAmount => "DIGEST_AMOUNT",
                UiComponentEnum.DigestCron => "DIGEST_CRON",
                UiComponentEnum.DigestKey => "DIGEST_KEY",
                UiComponentEnum.DigestType => "DIGEST_TYPE",
                UiComponentEnum.DigestUnit => "DIGEST_UNIT",
                UiComponentEnum.DisableSanitizationSwitch => "DISABLE_SANITIZATION_SWITCH",
                UiComponentEnum.EmailBody => "EMAIL_BODY",
                UiComponentEnum.EmailEditorSelect => "EMAIL_EDITOR_SELECT",
                UiComponentEnum.ExtendToSchedule => "EXTEND_TO_SCHEDULE",
                UiComponentEnum.InAppAvatar => "IN_APP_AVATAR",
                UiComponentEnum.InAppBody => "IN_APP_BODY",
                UiComponentEnum.InAppButtonDropdown => "IN_APP_BUTTON_DROPDOWN",
                UiComponentEnum.InAppDisableSanitizationSwitch => "IN_APP_DISABLE_SANITIZATION_SWITCH",
                UiComponentEnum.InAppPrimarySubject => "IN_APP_PRIMARY_SUBJECT",
                UiComponentEnum.LayoutEmail => "LAYOUT_EMAIL",
                UiComponentEnum.LayoutSelect => "LAYOUT_SELECT",
                UiComponentEnum.PushBody => "PUSH_BODY",
                UiComponentEnum.PushSubject => "PUSH_SUBJECT",
                UiComponentEnum.QueryEditor => "QUERY_EDITOR",
                UiComponentEnum.SmsBody => "SMS_BODY",
                UiComponentEnum.TextFullLine => "TEXT_FULL_LINE",
                UiComponentEnum.TextInlineLabel => "TEXT_INLINE_LABEL",
                UiComponentEnum.ThrottleDynamicKey => "THROTTLE_DYNAMIC_KEY",
                UiComponentEnum.ThrottleKey => "THROTTLE_KEY",
                UiComponentEnum.ThrottleThreshold => "THROTTLE_THRESHOLD",
                UiComponentEnum.ThrottleType => "THROTTLE_TYPE",
                UiComponentEnum.ThrottleUnit => "THROTTLE_UNIT",
                UiComponentEnum.ThrottleWindow => "THROTTLE_WINDOW",
                UiComponentEnum.UrlTextBox => "URL_TEXT_BOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UiComponentEnum? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_EDITOR" => UiComponentEnum.BlockEditor,
                "CHAT_BODY" => UiComponentEnum.ChatBody,
                "DATA" => UiComponentEnum.Data,
                "DELAY_AMOUNT" => UiComponentEnum.DelayAmount,
                "DELAY_CRON" => UiComponentEnum.DelayCron,
                "DELAY_DYNAMIC_KEY" => UiComponentEnum.DelayDynamicKey,
                "DELAY_TYPE" => UiComponentEnum.DelayType,
                "DELAY_UNIT" => UiComponentEnum.DelayUnit,
                "DESTINATION_BODY" => UiComponentEnum.DestinationBody,
                "DESTINATION_CONTINUE_ON_FAILURE" => UiComponentEnum.DestinationContinueOnFailure,
                "DESTINATION_ENFORCE_SCHEMA_VALIDATION" => UiComponentEnum.DestinationEnforceSchemaValidation,
                "DESTINATION_HEADERS" => UiComponentEnum.DestinationHeaders,
                "DESTINATION_METHOD" => UiComponentEnum.DestinationMethod,
                "DESTINATION_RESPONSE_BODY_SCHEMA" => UiComponentEnum.DestinationResponseBodySchema,
                "DESTINATION_TIMEOUT" => UiComponentEnum.DestinationTimeout,
                "DESTINATION_URL" => UiComponentEnum.DestinationUrl,
                "DIGEST_AMOUNT" => UiComponentEnum.DigestAmount,
                "DIGEST_CRON" => UiComponentEnum.DigestCron,
                "DIGEST_KEY" => UiComponentEnum.DigestKey,
                "DIGEST_TYPE" => UiComponentEnum.DigestType,
                "DIGEST_UNIT" => UiComponentEnum.DigestUnit,
                "DISABLE_SANITIZATION_SWITCH" => UiComponentEnum.DisableSanitizationSwitch,
                "EMAIL_BODY" => UiComponentEnum.EmailBody,
                "EMAIL_EDITOR_SELECT" => UiComponentEnum.EmailEditorSelect,
                "EXTEND_TO_SCHEDULE" => UiComponentEnum.ExtendToSchedule,
                "IN_APP_AVATAR" => UiComponentEnum.InAppAvatar,
                "IN_APP_BODY" => UiComponentEnum.InAppBody,
                "IN_APP_BUTTON_DROPDOWN" => UiComponentEnum.InAppButtonDropdown,
                "IN_APP_DISABLE_SANITIZATION_SWITCH" => UiComponentEnum.InAppDisableSanitizationSwitch,
                "IN_APP_PRIMARY_SUBJECT" => UiComponentEnum.InAppPrimarySubject,
                "LAYOUT_EMAIL" => UiComponentEnum.LayoutEmail,
                "LAYOUT_SELECT" => UiComponentEnum.LayoutSelect,
                "PUSH_BODY" => UiComponentEnum.PushBody,
                "PUSH_SUBJECT" => UiComponentEnum.PushSubject,
                "QUERY_EDITOR" => UiComponentEnum.QueryEditor,
                "SMS_BODY" => UiComponentEnum.SmsBody,
                "TEXT_FULL_LINE" => UiComponentEnum.TextFullLine,
                "TEXT_INLINE_LABEL" => UiComponentEnum.TextInlineLabel,
                "THROTTLE_DYNAMIC_KEY" => UiComponentEnum.ThrottleDynamicKey,
                "THROTTLE_KEY" => UiComponentEnum.ThrottleKey,
                "THROTTLE_THRESHOLD" => UiComponentEnum.ThrottleThreshold,
                "THROTTLE_TYPE" => UiComponentEnum.ThrottleType,
                "THROTTLE_UNIT" => UiComponentEnum.ThrottleUnit,
                "THROTTLE_WINDOW" => UiComponentEnum.ThrottleWindow,
                "URL_TEXT_BOX" => UiComponentEnum.UrlTextBox,
                _ => null,
            };
        }
    }
}