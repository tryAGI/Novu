
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: webex_person
    /// </summary>
    public enum CreateWebexPersonEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        WebexPerson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebexPersonEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebexPersonEndpointDtoType value)
        {
            return value switch
            {
                CreateWebexPersonEndpointDtoType.WebexPerson => "webex_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebexPersonEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "webex_person" => CreateWebexPersonEndpointDtoType.WebexPerson,
                _ => null,
            };
        }
    }
}