
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationControllerDeleteTranslationGroupEndpointResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Layout,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationControllerDeleteTranslationGroupEndpointResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationControllerDeleteTranslationGroupEndpointResourceType value)
        {
            return value switch
            {
                TranslationControllerDeleteTranslationGroupEndpointResourceType.Layout => "layout",
                TranslationControllerDeleteTranslationGroupEndpointResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationControllerDeleteTranslationGroupEndpointResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationControllerDeleteTranslationGroupEndpointResourceType.Layout,
                "workflow" => TranslationControllerDeleteTranslationGroupEndpointResourceType.Workflow,
                _ => null,
            };
        }
    }
}