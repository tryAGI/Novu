
#nullable enable

namespace Novu
{
    /// <summary>
    /// The channel type for the integration
    /// </summary>
    public enum CreateIntegrationRequestDtoChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        InApp,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationRequestDtoChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationRequestDtoChannel value)
        {
            return value switch
            {
                CreateIntegrationRequestDtoChannel.Chat => "chat",
                CreateIntegrationRequestDtoChannel.Email => "email",
                CreateIntegrationRequestDtoChannel.InApp => "in_app",
                CreateIntegrationRequestDtoChannel.Push => "push",
                CreateIntegrationRequestDtoChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationRequestDtoChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CreateIntegrationRequestDtoChannel.Chat,
                "email" => CreateIntegrationRequestDtoChannel.Email,
                "in_app" => CreateIntegrationRequestDtoChannel.InApp,
                "push" => CreateIntegrationRequestDtoChannel.Push,
                "sms" => CreateIntegrationRequestDtoChannel.Sms,
                _ => null,
            };
        }
    }
}