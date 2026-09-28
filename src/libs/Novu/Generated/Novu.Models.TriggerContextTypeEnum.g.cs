
#nullable enable

namespace Novu
{
    /// <summary>
    /// Reserved context type
    /// </summary>
    public enum TriggerContextTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Actor,
        /// <summary>
        ///
        /// </summary>
        Tenant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerContextTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerContextTypeEnum value)
        {
            return value switch
            {
                TriggerContextTypeEnum.Actor => "actor",
                TriggerContextTypeEnum.Tenant => "tenant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerContextTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "actor" => TriggerContextTypeEnum.Actor,
                "tenant" => TriggerContextTypeEnum.Tenant,
                _ => null,
            };
        }
    }
}