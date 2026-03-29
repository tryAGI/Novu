
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContextsControllerListContextsOrderDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextsControllerListContextsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextsControllerListContextsOrderDirection value)
        {
            return value switch
            {
                ContextsControllerListContextsOrderDirection.Asc => "ASC",
                ContextsControllerListContextsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextsControllerListContextsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ContextsControllerListContextsOrderDirection.Asc,
                "DESC" => ContextsControllerListContextsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}