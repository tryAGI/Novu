
#nullable enable

namespace Novu
{
    /// <summary>
    /// Message action status
    /// </summary>
    public enum MarkMessageActionAsSeenDtoStatus
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
    public static class MarkMessageActionAsSeenDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarkMessageActionAsSeenDtoStatus value)
        {
            return value switch
            {
                MarkMessageActionAsSeenDtoStatus.Done => "done",
                MarkMessageActionAsSeenDtoStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarkMessageActionAsSeenDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => MarkMessageActionAsSeenDtoStatus.Done,
                "pending" => MarkMessageActionAsSeenDtoStatus.Pending,
                _ => null,
            };
        }
    }
}