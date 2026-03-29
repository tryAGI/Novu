
#nullable enable

namespace Novu
{
    /// <summary>
    /// Source of layout creation<br/>
    /// Default Value: dashboard
    /// </summary>
    public enum LayoutCreationSourceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Dashboard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayoutCreationSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayoutCreationSourceEnum value)
        {
            return value switch
            {
                LayoutCreationSourceEnum.Dashboard => "dashboard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayoutCreationSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => LayoutCreationSourceEnum.Dashboard,
                _ => null,
            };
        }
    }
}