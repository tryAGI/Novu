
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationControllerGetTranslationGroupEndpointResourceType
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
    public static class TranslationControllerGetTranslationGroupEndpointResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationControllerGetTranslationGroupEndpointResourceType value)
        {
            return value switch
            {
                TranslationControllerGetTranslationGroupEndpointResourceType.Layout => "layout",
                TranslationControllerGetTranslationGroupEndpointResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationControllerGetTranslationGroupEndpointResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationControllerGetTranslationGroupEndpointResourceType.Layout,
                "workflow" => TranslationControllerGetTranslationGroupEndpointResourceType.Workflow,
                _ => null,
            };
        }
    }
}