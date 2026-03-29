
#nullable enable

namespace Novu
{
    /// <summary>
    /// Resource type<br/>
    /// Example: workflow
    /// </summary>
    public enum TranslationResponseDtoResourceType
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
    public static class TranslationResponseDtoResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationResponseDtoResourceType value)
        {
            return value switch
            {
                TranslationResponseDtoResourceType.Layout => "layout",
                TranslationResponseDtoResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationResponseDtoResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationResponseDtoResourceType.Layout,
                "workflow" => TranslationResponseDtoResourceType.Workflow,
                _ => null,
            };
        }
    }
}