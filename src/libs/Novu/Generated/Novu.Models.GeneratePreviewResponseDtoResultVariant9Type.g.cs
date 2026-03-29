
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
        Digest,
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
                GeneratePreviewResponseDtoResultVariant9Type.Digest => "digest",
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
                "digest" => GeneratePreviewResponseDtoResultVariant9Type.Digest,
                _ => null,
            };
        }
    }
}