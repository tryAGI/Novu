
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: telegram_chat
    /// </summary>
    public enum CreateTelegramChatEndpointDtoType
    {
        /// <summary>
        ///
        /// </summary>
        TelegramChat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTelegramChatEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTelegramChatEndpointDtoType value)
        {
            return value switch
            {
                CreateTelegramChatEndpointDtoType.TelegramChat => "telegram_chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTelegramChatEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "telegram_chat" => CreateTelegramChatEndpointDtoType.TelegramChat,
                _ => null,
            };
        }
    }
}