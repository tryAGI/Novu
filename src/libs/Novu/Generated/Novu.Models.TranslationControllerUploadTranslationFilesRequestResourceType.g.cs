
#nullable enable

namespace Novu
{
    /// <summary>
    /// The resource type to associate localizations with
    /// </summary>
    public enum TranslationControllerUploadTranslationFilesRequestResourceType
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
    public static class TranslationControllerUploadTranslationFilesRequestResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationControllerUploadTranslationFilesRequestResourceType value)
        {
            return value switch
            {
                TranslationControllerUploadTranslationFilesRequestResourceType.Layout => "layout",
                TranslationControllerUploadTranslationFilesRequestResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationControllerUploadTranslationFilesRequestResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationControllerUploadTranslationFilesRequestResourceType.Layout,
                "workflow" => TranslationControllerUploadTranslationFilesRequestResourceType.Workflow,
                _ => null,
            };
        }
    }
}