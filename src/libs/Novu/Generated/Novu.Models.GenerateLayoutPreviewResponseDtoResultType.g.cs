
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateLayoutPreviewResponseDtoResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateLayoutPreviewResponseDtoResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateLayoutPreviewResponseDtoResultType value)
        {
            return value switch
            {
                GenerateLayoutPreviewResponseDtoResultType.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateLayoutPreviewResponseDtoResultType? ToEnum(string value)
        {
            return value switch
            {
                "email" => GenerateLayoutPreviewResponseDtoResultType.Email,
                _ => null,
            };
        }
    }
}