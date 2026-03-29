
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationControllerGetSingleTranslationResourceType
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
    public static class TranslationControllerGetSingleTranslationResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationControllerGetSingleTranslationResourceType value)
        {
            return value switch
            {
                TranslationControllerGetSingleTranslationResourceType.Layout => "layout",
                TranslationControllerGetSingleTranslationResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationControllerGetSingleTranslationResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationControllerGetSingleTranslationResourceType.Layout,
                "workflow" => TranslationControllerGetSingleTranslationResourceType.Workflow,
                _ => null,
            };
        }
    }
}