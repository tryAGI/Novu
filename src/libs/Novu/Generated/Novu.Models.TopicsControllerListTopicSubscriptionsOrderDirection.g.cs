
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicsControllerListTopicSubscriptionsOrderDirection
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
    public static class TopicsControllerListTopicSubscriptionsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicsControllerListTopicSubscriptionsOrderDirection value)
        {
            return value switch
            {
                TopicsControllerListTopicSubscriptionsOrderDirection.Asc => "ASC",
                TopicsControllerListTopicSubscriptionsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicsControllerListTopicSubscriptionsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => TopicsControllerListTopicSubscriptionsOrderDirection.Asc,
                "DESC" => TopicsControllerListTopicSubscriptionsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}