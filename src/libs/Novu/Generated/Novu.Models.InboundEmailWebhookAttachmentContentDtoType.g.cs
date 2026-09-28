
#nullable enable

namespace Novu
{
    /// <summary>
    /// Legacy Node.js buffer marker
    /// </summary>
    public enum InboundEmailWebhookAttachmentContentDtoType
    {
        /// <summary>
        ///
        /// </summary>
        Buffer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboundEmailWebhookAttachmentContentDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboundEmailWebhookAttachmentContentDtoType value)
        {
            return value switch
            {
                InboundEmailWebhookAttachmentContentDtoType.Buffer => "Buffer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboundEmailWebhookAttachmentContentDtoType? ToEnum(string value)
        {
            return value switch
            {
                "Buffer" => InboundEmailWebhookAttachmentContentDtoType.Buffer,
                _ => null,
            };
        }
    }
}