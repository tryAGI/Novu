
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: line_user
    /// </summary>
    public enum CreateLineUserEndpointDtoType
    {
        /// <summary>
        ///
        /// </summary>
        LineUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLineUserEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLineUserEndpointDtoType value)
        {
            return value switch
            {
                CreateLineUserEndpointDtoType.LineUser => "line_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLineUserEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "line_user" => CreateLineUserEndpointDtoType.LineUser,
                _ => null,
            };
        }
    }
}