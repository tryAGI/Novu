
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the variable
    /// </summary>
    public enum CreateEnvironmentVariableRequestDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEnvironmentVariableRequestDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentVariableRequestDtoType value)
        {
            return value switch
            {
                CreateEnvironmentVariableRequestDtoType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentVariableRequestDtoType? ToEnum(string value)
        {
            return value switch
            {
                "string" => CreateEnvironmentVariableRequestDtoType.String,
                _ => null,
            };
        }
    }
}