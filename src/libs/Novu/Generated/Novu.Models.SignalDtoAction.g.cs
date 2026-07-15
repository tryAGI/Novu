
#nullable enable

namespace Novu
{
    /// <summary>
    /// Required for metadata signals other than the default `set`.
    /// </summary>
    public enum SignalDtoAction
    {
        /// <summary>
        /// 
        /// </summary>
        Clear,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SignalDtoActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalDtoAction value)
        {
            return value switch
            {
                SignalDtoAction.Clear => "clear",
                SignalDtoAction.Delete => "delete",
                SignalDtoAction.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalDtoAction? ToEnum(string value)
        {
            return value switch
            {
                "clear" => SignalDtoAction.Clear,
                "delete" => SignalDtoAction.Delete,
                "set" => SignalDtoAction.Set,
                _ => null,
            };
        }
    }
}