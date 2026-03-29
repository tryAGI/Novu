
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowResponseDtoStepDiscriminatorType
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
        /// <summary>
        /// 
        /// </summary>
        Throttle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowResponseDtoStepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowResponseDtoStepDiscriminatorType value)
        {
            return value switch
            {
                WorkflowResponseDtoStepDiscriminatorType.Chat => "chat",
                WorkflowResponseDtoStepDiscriminatorType.Custom => "custom",
                WorkflowResponseDtoStepDiscriminatorType.Delay => "delay",
                WorkflowResponseDtoStepDiscriminatorType.Digest => "digest",
                WorkflowResponseDtoStepDiscriminatorType.Email => "email",
                WorkflowResponseDtoStepDiscriminatorType.HttpRequest => "http_request",
                WorkflowResponseDtoStepDiscriminatorType.InApp => "in_app",
                WorkflowResponseDtoStepDiscriminatorType.Push => "push",
                WorkflowResponseDtoStepDiscriminatorType.Sms => "sms",
                WorkflowResponseDtoStepDiscriminatorType.Throttle => "throttle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowResponseDtoStepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => WorkflowResponseDtoStepDiscriminatorType.Chat,
                "custom" => WorkflowResponseDtoStepDiscriminatorType.Custom,
                "delay" => WorkflowResponseDtoStepDiscriminatorType.Delay,
                "digest" => WorkflowResponseDtoStepDiscriminatorType.Digest,
                "email" => WorkflowResponseDtoStepDiscriminatorType.Email,
                "http_request" => WorkflowResponseDtoStepDiscriminatorType.HttpRequest,
                "in_app" => WorkflowResponseDtoStepDiscriminatorType.InApp,
                "push" => WorkflowResponseDtoStepDiscriminatorType.Push,
                "sms" => WorkflowResponseDtoStepDiscriminatorType.Sms,
                "throttle" => WorkflowResponseDtoStepDiscriminatorType.Throttle,
                _ => null,
            };
        }
    }
}