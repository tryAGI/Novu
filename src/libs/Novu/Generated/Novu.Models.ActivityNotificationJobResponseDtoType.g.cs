
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the job
    /// </summary>
    public enum ActivityNotificationJobResponseDtoType
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
    public static class ActivityNotificationJobResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityNotificationJobResponseDtoType value)
        {
            return value switch
            {
                ActivityNotificationJobResponseDtoType.Chat => "chat",
                ActivityNotificationJobResponseDtoType.Custom => "custom",
                ActivityNotificationJobResponseDtoType.Delay => "delay",
                ActivityNotificationJobResponseDtoType.Digest => "digest",
                ActivityNotificationJobResponseDtoType.Email => "email",
                ActivityNotificationJobResponseDtoType.HttpRequest => "http_request",
                ActivityNotificationJobResponseDtoType.InApp => "in_app",
                ActivityNotificationJobResponseDtoType.Push => "push",
                ActivityNotificationJobResponseDtoType.Sms => "sms",
                ActivityNotificationJobResponseDtoType.Throttle => "throttle",
                ActivityNotificationJobResponseDtoType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityNotificationJobResponseDtoType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ActivityNotificationJobResponseDtoType.Chat,
                "custom" => ActivityNotificationJobResponseDtoType.Custom,
                "delay" => ActivityNotificationJobResponseDtoType.Delay,
                "digest" => ActivityNotificationJobResponseDtoType.Digest,
                "email" => ActivityNotificationJobResponseDtoType.Email,
                "http_request" => ActivityNotificationJobResponseDtoType.HttpRequest,
                "in_app" => ActivityNotificationJobResponseDtoType.InApp,
                "push" => ActivityNotificationJobResponseDtoType.Push,
                "sms" => ActivityNotificationJobResponseDtoType.Sms,
                "throttle" => ActivityNotificationJobResponseDtoType.Throttle,
                "trigger" => ActivityNotificationJobResponseDtoType.Trigger,
                _ => null,
            };
        }
    }
}