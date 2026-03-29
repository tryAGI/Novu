
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the environment<br/>
    /// Example: prod
    /// </summary>
    public enum EnvironmentResponseDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Dev,
        /// <summary>
        /// 
        /// </summary>
        Prod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentResponseDtoType value)
        {
            return value switch
            {
                EnvironmentResponseDtoType.Dev => "dev",
                EnvironmentResponseDtoType.Prod => "prod",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentResponseDtoType? ToEnum(string value)
        {
            return value switch
            {
                "dev" => EnvironmentResponseDtoType.Dev,
                "prod" => EnvironmentResponseDtoType.Prod,
                _ => null,
            };
        }
    }
}