
#nullable enable

namespace Novu
{
    /// <summary>
    /// The status enum for the performed action
    /// </summary>
    public enum DeleteMessageResponseDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteMessageResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteMessageResponseDtoStatus value)
        {
            return value switch
            {
                DeleteMessageResponseDtoStatus.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteMessageResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => DeleteMessageResponseDtoStatus.Deleted,
                _ => null,
            };
        }
    }
}