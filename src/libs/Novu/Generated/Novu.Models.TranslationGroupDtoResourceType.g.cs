
#nullable enable

namespace Novu
{
    /// <summary>
    /// Resource type<br/>
    /// Example: workflow
    /// </summary>
    public enum TranslationGroupDtoResourceType
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
    public static class TranslationGroupDtoResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationGroupDtoResourceType value)
        {
            return value switch
            {
                TranslationGroupDtoResourceType.Layout => "layout",
                TranslationGroupDtoResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationGroupDtoResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => TranslationGroupDtoResourceType.Layout,
                "workflow" => TranslationGroupDtoResourceType.Workflow,
                _ => null,
            };
        }
    }
}