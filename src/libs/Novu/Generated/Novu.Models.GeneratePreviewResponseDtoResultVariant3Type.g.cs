
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant3Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant3Type.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "email" => GeneratePreviewResponseDtoResultVariant3Type.Email,
                _ => null,
            };
        }
    }
}