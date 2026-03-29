
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        Delay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant8Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant8Type.Delay => "delay",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "delay" => GeneratePreviewResponseDtoResultVariant8Type.Delay,
                _ => null,
            };
        }
    }
}