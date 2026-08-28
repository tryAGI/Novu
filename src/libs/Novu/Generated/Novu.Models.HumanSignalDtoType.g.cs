
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum HumanSignalDtoType
    {
        /// <summary>
        ///
        /// </summary>
        Human,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HumanSignalDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HumanSignalDtoType value)
        {
            return value switch
            {
                HumanSignalDtoType.Human => "human",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HumanSignalDtoType? ToEnum(string value)
        {
            return value switch
            {
                "human" => HumanSignalDtoType.Human,
                _ => null,
            };
        }
    }
}