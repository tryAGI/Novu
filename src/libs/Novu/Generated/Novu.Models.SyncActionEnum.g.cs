
#nullable enable

namespace Novu
{
    /// <summary>
    /// Sync action performed
    /// </summary>
    public enum SyncActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SyncActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncActionEnum value)
        {
            return value switch
            {
                SyncActionEnum.Created => "created",
                SyncActionEnum.Deleted => "deleted",
                SyncActionEnum.Skipped => "skipped",
                SyncActionEnum.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "created" => SyncActionEnum.Created,
                "deleted" => SyncActionEnum.Deleted,
                "skipped" => SyncActionEnum.Skipped,
                "updated" => SyncActionEnum.Updated,
                _ => null,
            };
        }
    }
}