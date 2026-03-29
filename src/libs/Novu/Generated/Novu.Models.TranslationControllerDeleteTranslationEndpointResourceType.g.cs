
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationControllerDeleteTranslationEndpointResourceType
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
    public static class TranslationControllerDeleteTranslationEndpointResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationControllerDeleteTranslationEndpointResourceType value)
        {
            return value switch
            {
                TranslationControllerDeleteTranslationEndpointResourceType.Layout => "layout",
                TranslationControllerDeleteTranslationEndpointResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationControllerDeleteTranslationEndpointResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationControllerDeleteTranslationEndpointResourceType.Layout,
                "workflow" => TranslationControllerDeleteTranslationEndpointResourceType.Workflow,
                _ => null,
            };
        }
    }
}