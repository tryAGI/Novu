
#nullable enable

namespace Novu
{
    /// <summary>
    /// Mark all subscriber messages as read, unread, seen or unseen
    /// </summary>
    public enum MarkAllMessageAsRequestDtoMarkAs
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Seen,
        /// <summary>
        /// 
        /// </summary>
        Unread,
        /// <summary>
        /// 
        /// </summary>
        Unseen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarkAllMessageAsRequestDtoMarkAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarkAllMessageAsRequestDtoMarkAs value)
        {
            return value switch
            {
                MarkAllMessageAsRequestDtoMarkAs.Read => "read",
                MarkAllMessageAsRequestDtoMarkAs.Seen => "seen",
                MarkAllMessageAsRequestDtoMarkAs.Unread => "unread",
                MarkAllMessageAsRequestDtoMarkAs.Unseen => "unseen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarkAllMessageAsRequestDtoMarkAs? ToEnum(string value)
        {
            return value switch
            {
                "read" => MarkAllMessageAsRequestDtoMarkAs.Read,
                "seen" => MarkAllMessageAsRequestDtoMarkAs.Seen,
                "unread" => MarkAllMessageAsRequestDtoMarkAs.Unread,
                "unseen" => MarkAllMessageAsRequestDtoMarkAs.Unseen,
                _ => null,
            };
        }
    }
}