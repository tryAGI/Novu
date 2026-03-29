
#nullable enable

namespace Novu
{
    /// <summary>
    /// The channel type for the integration, which defines how it communicates (e.g., email, SMS).
    /// </summary>
    public enum IntegrationResponseDtoChannel
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
    public static class IntegrationResponseDtoChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationResponseDtoChannel value)
        {
            return value switch
            {
                IntegrationResponseDtoChannel.Chat => "chat",
                IntegrationResponseDtoChannel.Email => "email",
                IntegrationResponseDtoChannel.InApp => "in_app",
                IntegrationResponseDtoChannel.Push => "push",
                IntegrationResponseDtoChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationResponseDtoChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => IntegrationResponseDtoChannel.Chat,
                "email" => IntegrationResponseDtoChannel.Email,
                "in_app" => IntegrationResponseDtoChannel.InApp,
                "push" => IntegrationResponseDtoChannel.Push,
                "sms" => IntegrationResponseDtoChannel.Sms,
                _ => null,
            };
        }
    }
}