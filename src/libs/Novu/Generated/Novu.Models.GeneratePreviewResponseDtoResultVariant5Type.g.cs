
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant5Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant5Type.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "sms" => GeneratePreviewResponseDtoResultVariant5Type.Sms,
                _ => null,
            };
        }
    }
}