
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentVariableResponseDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentVariableResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentVariableResponseDtoType value)
        {
            return value switch
            {
                EnvironmentVariableResponseDtoType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentVariableResponseDtoType? ToEnum(string value)
        {
            return value switch
            {
                "string" => EnvironmentVariableResponseDtoType.String,
                _ => null,
            };
        }
    }
}