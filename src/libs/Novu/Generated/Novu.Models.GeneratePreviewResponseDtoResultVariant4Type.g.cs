
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratePreviewResponseDtoResultVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        InApp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratePreviewResponseDtoResultVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePreviewResponseDtoResultVariant4Type value)
        {
            return value switch
            {
                GeneratePreviewResponseDtoResultVariant4Type.InApp => "in_app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePreviewResponseDtoResultVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "in_app" => GeneratePreviewResponseDtoResultVariant4Type.InApp,
                _ => null,
            };
        }
    }
}