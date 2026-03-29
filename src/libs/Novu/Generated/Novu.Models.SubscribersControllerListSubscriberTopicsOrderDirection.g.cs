
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscribersControllerListSubscriberTopicsOrderDirection
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
    public static class SubscribersControllerListSubscriberTopicsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscribersControllerListSubscriberTopicsOrderDirection value)
        {
            return value switch
            {
                SubscribersControllerListSubscriberTopicsOrderDirection.Asc => "ASC",
                SubscribersControllerListSubscriberTopicsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscribersControllerListSubscriberTopicsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SubscribersControllerListSubscriberTopicsOrderDirection.Asc,
                "DESC" => SubscribersControllerListSubscriberTopicsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}