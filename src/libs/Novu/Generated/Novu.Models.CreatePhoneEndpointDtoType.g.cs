
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: phone
    /// </summary>
    public enum CreatePhoneEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneEndpointDtoType value)
        {
            return value switch
            {
                CreatePhoneEndpointDtoType.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => CreatePhoneEndpointDtoType.Phone,
                _ => null,
            };
        }
    }
}