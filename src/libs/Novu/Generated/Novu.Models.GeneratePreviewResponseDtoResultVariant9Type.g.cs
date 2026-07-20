
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        Delay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant9Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant9Type.Delay => "delay",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "delay" => GeneratePreviewResponseDtoResultVariant9Type.Delay,
                _ => null,
            };
        }
    }
}