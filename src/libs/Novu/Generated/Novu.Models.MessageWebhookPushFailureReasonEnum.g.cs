
#nullable enable

namespace Novu
{
    /// <summary>
    /// Why the push send failed
    /// </summary>
    public enum MessageWebhookPushFailureReasonEnum
    {
        /// <summary>
        ///
        /// </summary>
        GenericError,
        /// <summary>
        ///
        /// </summary>
        TokenInvalid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageWebhookPushFailureReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageWebhookPushFailureReasonEnum value)
        {
            return value switch
            {
                MessageWebhookPushFailureReasonEnum.GenericError => "generic_error",
                MessageWebhookPushFailureReasonEnum.TokenInvalid => "token_invalid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageWebhookPushFailureReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "generic_error" => MessageWebhookPushFailureReasonEnum.GenericError,
                "token_invalid" => MessageWebhookPushFailureReasonEnum.TokenInvalid,
                _ => null,
            };
        }
    }
}