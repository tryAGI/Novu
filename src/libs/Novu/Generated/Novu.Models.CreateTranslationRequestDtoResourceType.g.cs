
#nullable enable

namespace Novu
{
    /// <summary>
    /// The resource type to associate translation with
    /// </summary>
    public enum CreateTranslationRequestDtoResourceType
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
    public static class CreateTranslationRequestDtoResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationRequestDtoResourceType value)
        {
            return value switch
            {
                CreateTranslationRequestDtoResourceType.Layout => "layout",
                CreateTranslationRequestDtoResourceType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationRequestDtoResourceType? ToEnum(string value)
        {
            return value switch
            {
                "layout" => CreateTranslationRequestDtoResourceType.Layout,
                "workflow" => CreateTranslationRequestDtoResourceType.Workflow,
                _ => null,
            };
        }
    }
}