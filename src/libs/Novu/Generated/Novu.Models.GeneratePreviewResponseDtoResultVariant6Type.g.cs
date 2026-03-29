
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Push,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant6Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant6Type.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "push" => GeneratePreviewResponseDtoResultVariant6Type.Push,
                _ => null,
            };
        }
    }
}