
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the variable
    /// </summary>
    public enum UpdateEnvironmentVariableRequestDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEnvironmentVariableRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEnvironmentVariableRequestDtoType value)
        {
            return value switch
            {
                UpdateEnvironmentVariableRequestDtoType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEnvironmentVariableRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UpdateEnvironmentVariableRequestDtoType.String,
                _ => null,
            };
        }
    }
}