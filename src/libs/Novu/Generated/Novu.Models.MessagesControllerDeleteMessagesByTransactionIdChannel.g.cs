
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesControllerDeleteMessagesByTransactionIdChannel
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
    public static class MessagesControllerDeleteMessagesByTransactionIdChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesControllerDeleteMessagesByTransactionIdChannel value)
        {
            return value switch
            {
                MessagesControllerDeleteMessagesByTransactionIdChannel.Chat => "chat",
                MessagesControllerDeleteMessagesByTransactionIdChannel.Email => "email",
                MessagesControllerDeleteMessagesByTransactionIdChannel.InApp => "in_app",
                MessagesControllerDeleteMessagesByTransactionIdChannel.Push => "push",
                MessagesControllerDeleteMessagesByTransactionIdChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesControllerDeleteMessagesByTransactionIdChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => MessagesControllerDeleteMessagesByTransactionIdChannel.Chat,
                "email" => MessagesControllerDeleteMessagesByTransactionIdChannel.Email,
                "in_app" => MessagesControllerDeleteMessagesByTransactionIdChannel.InApp,
                "push" => MessagesControllerDeleteMessagesByTransactionIdChannel.Push,
                "sms" => MessagesControllerDeleteMessagesByTransactionIdChannel.Sms,
                _ => null,
            };
        }
    }
}