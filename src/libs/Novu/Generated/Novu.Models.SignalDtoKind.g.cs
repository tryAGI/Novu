
#nullable enable

namespace Novu
{
    /// <summary>
    /// Human-interaction verb for `human` signals.
    /// </summary>
    public enum SignalDtoKind
    {
        /// <summary>
        ///
        /// </summary>
        Approve,
        /// <summary>
        ///
        /// </summary>
        Ask,
        /// <summary>
        ///
        /// </summary>
        Choose,
        /// <summary>
        ///
        /// </summary>
        Tell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SignalDtoKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalDtoKind value)
        {
            return value switch
            {
                SignalDtoKind.Approve => "approve",
                SignalDtoKind.Ask => "ask",
                SignalDtoKind.Choose => "choose",
                SignalDtoKind.Tell => "tell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalDtoKind? ToEnum(string value)
        {
            return value switch
            {
                "approve" => SignalDtoKind.Approve,
                "ask" => SignalDtoKind.Ask,
                "choose" => SignalDtoKind.Choose,
                "tell" => SignalDtoKind.Tell,
                _ => null,
            };
        }
    }
}