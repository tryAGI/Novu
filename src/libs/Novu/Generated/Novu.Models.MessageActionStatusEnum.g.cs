
#nullable enable

namespace Novu
{
    /// <summary>
    /// Status of the message action
    /// </summary>
    public enum MessageActionStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageActionStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageActionStatusEnum value)
        {
            return value switch
            {
                MessageActionStatusEnum.Done => "done",
                MessageActionStatusEnum.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageActionStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "done" => MessageActionStatusEnum.Done,
                "pending" => MessageActionStatusEnum.Pending,
                _ => null,
            };
        }
    }
}