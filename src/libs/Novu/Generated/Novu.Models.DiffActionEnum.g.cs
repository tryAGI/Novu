
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of change
    /// </summary>
    public enum DiffActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Modified,
        /// <summary>
        /// 
        /// </summary>
        Moved,
        /// <summary>
        /// 
        /// </summary>
        Unchanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiffActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiffActionEnum value)
        {
            return value switch
            {
                DiffActionEnum.Added => "added",
                DiffActionEnum.Deleted => "deleted",
                DiffActionEnum.Modified => "modified",
                DiffActionEnum.Moved => "moved",
                DiffActionEnum.Unchanged => "unchanged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiffActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "added" => DiffActionEnum.Added,
                "deleted" => DiffActionEnum.Deleted,
                "modified" => DiffActionEnum.Modified,
                "moved" => DiffActionEnum.Moved,
                "unchanged" => DiffActionEnum.Unchanged,
                _ => null,
            };
        }
    }
}