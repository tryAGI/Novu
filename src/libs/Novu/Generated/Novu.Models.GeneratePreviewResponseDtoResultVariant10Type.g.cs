
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        Digest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant10Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant10Type.Digest => "digest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "digest" => GeneratePreviewResponseDtoResultVariant10Type.Digest,
                _ => null,
            };
        }
    }
}