
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerRecipientsTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Subscriber,
        /// <summary>
        /// 
        /// </summary>
        Topic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerRecipientsTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerRecipientsTypeEnum value)
        {
            return value switch
            {
                TriggerRecipientsTypeEnum.Subscriber => "Subscriber",
                TriggerRecipientsTypeEnum.Topic => "Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerRecipientsTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "Subscriber" => TriggerRecipientsTypeEnum.Subscriber,
                "Topic" => TriggerRecipientsTypeEnum.Topic,
                _ => null,
            };
        }
    }
}