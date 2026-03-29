
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicsControllerListTopicsOrderDirection
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
    public static class TopicsControllerListTopicsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicsControllerListTopicsOrderDirection value)
        {
            return value switch
            {
                TopicsControllerListTopicsOrderDirection.Asc => "ASC",
                TopicsControllerListTopicsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicsControllerListTopicsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => TopicsControllerListTopicsOrderDirection.Asc,
                "DESC" => TopicsControllerListTopicsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}