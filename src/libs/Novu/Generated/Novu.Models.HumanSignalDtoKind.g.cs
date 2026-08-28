
#nullable enable

namespace Novu
{
    /// <summary>
    /// Interaction verb queued by `ctx.ask` / `ctx.approve` / `ctx.choose` / `ctx.tell`.<br/>
    /// Example: approve
    /// </summary>
    public enum HumanSignalDtoKind
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
    public static class HumanSignalDtoKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HumanSignalDtoKind value)
        {
            return value switch
            {
                HumanSignalDtoKind.Approve => "approve",
                HumanSignalDtoKind.Ask => "ask",
                HumanSignalDtoKind.Choose => "choose",
                HumanSignalDtoKind.Tell => "tell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HumanSignalDtoKind? ToEnum(string value)
        {
            return value switch
            {
                "approve" => HumanSignalDtoKind.Approve,
                "ask" => HumanSignalDtoKind.Ask,
                "choose" => HumanSignalDtoKind.Choose,
                "tell" => HumanSignalDtoKind.Tell,
                _ => null,
            };
        }
    }
}