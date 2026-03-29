
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the actor, indicating the role in the notification process.
    /// </summary>
    public enum ActorTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        SystemCustom,
        /// <summary>
        /// 
        /// </summary>
        SystemIcon,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorTypeEnum value)
        {
            return value switch
            {
                ActorTypeEnum.None => "none",
                ActorTypeEnum.SystemCustom => "system_custom",
                ActorTypeEnum.SystemIcon => "system_icon",
                ActorTypeEnum.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "none" => ActorTypeEnum.None,
                "system_custom" => ActorTypeEnum.SystemCustom,
                "system_icon" => ActorTypeEnum.SystemIcon,
                "user" => ActorTypeEnum.User,
                _ => null,
            };
        }
    }
}