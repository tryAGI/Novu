
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum FieldFilterPartDtoOn
    {
        /// <summary>
        /// 
        /// </summary>
        Payload,
        /// <summary>
        /// 
        /// </summary>
        Subscriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FieldFilterPartDtoOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FieldFilterPartDtoOn value)
        {
            return value switch
            {
                FieldFilterPartDtoOn.Payload => "payload",
                FieldFilterPartDtoOn.Subscriber => "subscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FieldFilterPartDtoOn? ToEnum(string value)
        {
            return value switch
            {
                "payload" => FieldFilterPartDtoOn.Payload,
                "subscriber" => FieldFilterPartDtoOn.Subscriber,
                _ => null,
            };
        }
    }
}