
#nullable enable

namespace Novu
{
    /// <summary>
    /// Extra permissions granted to the session the token is exchanged for. Defaults to none.
    /// </summary>
    public enum SubscriberTokenScopeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Channels_shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriberTokenScopeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriberTokenScopeEnum value)
        {
            return value switch
            {
                SubscriberTokenScopeEnum.Channels_shared => "channels:shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriberTokenScopeEnum? ToEnum(string value)
        {
            return value switch
            {
                "channels:shared" => SubscriberTokenScopeEnum.Channels_shared,
                _ => null,
            };
        }
    }
}