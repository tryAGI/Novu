
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageMarkAsRequestDtoMarkAs
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
    public static class MessageMarkAsRequestDtoMarkAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageMarkAsRequestDtoMarkAs value)
        {
            return value switch
            {
                MessageMarkAsRequestDtoMarkAs.Read => "read",
                MessageMarkAsRequestDtoMarkAs.Seen => "seen",
                MessageMarkAsRequestDtoMarkAs.Unread => "unread",
                MessageMarkAsRequestDtoMarkAs.Unseen => "unseen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageMarkAsRequestDtoMarkAs? ToEnum(string value)
        {
            return value switch
            {
                "read" => MessageMarkAsRequestDtoMarkAs.Read,
                "seen" => MessageMarkAsRequestDtoMarkAs.Seen,
                "unread" => MessageMarkAsRequestDtoMarkAs.Unread,
                "unseen" => MessageMarkAsRequestDtoMarkAs.Unseen,
                _ => null,
            };
        }
    }
}