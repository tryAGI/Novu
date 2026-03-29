
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant7Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant7Type.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "chat" => GeneratePreviewResponseDtoResultVariant7Type.Chat,
                _ => null,
            };
        }
    }
}