
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the step
    /// </summary>
    public enum StepTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Delay,
        /// <summary>
        /// 
        /// </summary>
        Digest,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        HttpRequest,
        /// <summary>
        /// 
        /// </summary>
        InApp,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Sms,
        /// <summary>
        /// 
        /// </summary>
        Throttle,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepTypeEnum value)
        {
            return value switch
            {
                StepTypeEnum.Chat => "chat",
                StepTypeEnum.Custom => "custom",
                StepTypeEnum.Delay => "delay",
                StepTypeEnum.Digest => "digest",
                StepTypeEnum.Email => "email",
                StepTypeEnum.HttpRequest => "http_request",
                StepTypeEnum.InApp => "in_app",
                StepTypeEnum.Push => "push",
                StepTypeEnum.Sms => "sms",
                StepTypeEnum.Throttle => "throttle",
                StepTypeEnum.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "chat" => StepTypeEnum.Chat,
                "custom" => StepTypeEnum.Custom,
                "delay" => StepTypeEnum.Delay,
                "digest" => StepTypeEnum.Digest,
                "email" => StepTypeEnum.Email,
                "http_request" => StepTypeEnum.HttpRequest,
                "in_app" => StepTypeEnum.InApp,
                "push" => StepTypeEnum.Push,
                "sms" => StepTypeEnum.Sms,
                "throttle" => StepTypeEnum.Throttle,
                "trigger" => StepTypeEnum.Trigger,
                _ => null,
            };
        }
    }
}