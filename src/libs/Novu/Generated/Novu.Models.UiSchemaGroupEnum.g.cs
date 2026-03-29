
#nullable enable

namespace Novu
{
    /// <summary>
    /// Group of the UI Schema
    /// </summary>
    public enum UiSchemaGroupEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Delay,
        /// <summary>
        /// 
        /// </summary>
        Digest,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        HttpRequest,
        /// <summary>
        /// 
        /// </summary>
        InApp,
        /// <summary>
        /// 
        /// </summary>
        Layout,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Skip,
        /// <summary>
        /// 
        /// </summary>
        Sms,
        /// <summary>
        /// 
        /// </summary>
        Throttle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UiSchemaGroupEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UiSchemaGroupEnum value)
        {
            return value switch
            {
                UiSchemaGroupEnum.Chat => "CHAT",
                UiSchemaGroupEnum.Delay => "DELAY",
                UiSchemaGroupEnum.Digest => "DIGEST",
                UiSchemaGroupEnum.Email => "EMAIL",
                UiSchemaGroupEnum.HttpRequest => "HTTP_REQUEST",
                UiSchemaGroupEnum.InApp => "IN_APP",
                UiSchemaGroupEnum.Layout => "LAYOUT",
                UiSchemaGroupEnum.Push => "PUSH",
                UiSchemaGroupEnum.Skip => "SKIP",
                UiSchemaGroupEnum.Sms => "SMS",
                UiSchemaGroupEnum.Throttle => "THROTTLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UiSchemaGroupEnum? ToEnum(string value)
        {
            return value switch
            {
                "CHAT" => UiSchemaGroupEnum.Chat,
                "DELAY" => UiSchemaGroupEnum.Delay,
                "DIGEST" => UiSchemaGroupEnum.Digest,
                "EMAIL" => UiSchemaGroupEnum.Email,
                "HTTP_REQUEST" => UiSchemaGroupEnum.HttpRequest,
                "IN_APP" => UiSchemaGroupEnum.InApp,
                "LAYOUT" => UiSchemaGroupEnum.Layout,
                "PUSH" => UiSchemaGroupEnum.Push,
                "SKIP" => UiSchemaGroupEnum.Skip,
                "SMS" => UiSchemaGroupEnum.Sms,
                "THROTTLE" => UiSchemaGroupEnum.Throttle,
                _ => null,
            };
        }
    }
}