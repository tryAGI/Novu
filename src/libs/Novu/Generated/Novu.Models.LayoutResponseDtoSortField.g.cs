
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum LayoutResponseDtoSortField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayoutResponseDtoSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayoutResponseDtoSortField value)
        {
            return value switch
            {
                LayoutResponseDtoSortField.CreatedAt => "createdAt",
                LayoutResponseDtoSortField.Name => "name",
                LayoutResponseDtoSortField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayoutResponseDtoSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => LayoutResponseDtoSortField.CreatedAt,
                "name" => LayoutResponseDtoSortField.Name,
                "updatedAt" => LayoutResponseDtoSortField.UpdatedAt,
                _ => null,
            };
        }
    }
}