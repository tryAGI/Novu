
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateWorkflowDtoStepDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Custom,
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
        Push,
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWorkflowDtoStepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWorkflowDtoStepDiscriminatorType value)
        {
            return value switch
            {
                UpdateWorkflowDtoStepDiscriminatorType.Chat => "chat",
                UpdateWorkflowDtoStepDiscriminatorType.Custom => "custom",
                UpdateWorkflowDtoStepDiscriminatorType.Delay => "delay",
                UpdateWorkflowDtoStepDiscriminatorType.Digest => "digest",
                UpdateWorkflowDtoStepDiscriminatorType.Email => "email",
                UpdateWorkflowDtoStepDiscriminatorType.HttpRequest => "http_request",
                UpdateWorkflowDtoStepDiscriminatorType.InApp => "in_app",
                UpdateWorkflowDtoStepDiscriminatorType.Push => "push",
                UpdateWorkflowDtoStepDiscriminatorType.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWorkflowDtoStepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => UpdateWorkflowDtoStepDiscriminatorType.Chat,
                "custom" => UpdateWorkflowDtoStepDiscriminatorType.Custom,
                "delay" => UpdateWorkflowDtoStepDiscriminatorType.Delay,
                "digest" => UpdateWorkflowDtoStepDiscriminatorType.Digest,
                "email" => UpdateWorkflowDtoStepDiscriminatorType.Email,
                "http_request" => UpdateWorkflowDtoStepDiscriminatorType.HttpRequest,
                "in_app" => UpdateWorkflowDtoStepDiscriminatorType.InApp,
                "push" => UpdateWorkflowDtoStepDiscriminatorType.Push,
                "sms" => UpdateWorkflowDtoStepDiscriminatorType.Sms,
                _ => null,
            };
        }
    }
}