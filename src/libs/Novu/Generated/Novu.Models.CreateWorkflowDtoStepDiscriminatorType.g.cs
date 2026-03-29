
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWorkflowDtoStepDiscriminatorType
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
    public static class CreateWorkflowDtoStepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowDtoStepDiscriminatorType value)
        {
            return value switch
            {
                CreateWorkflowDtoStepDiscriminatorType.Chat => "chat",
                CreateWorkflowDtoStepDiscriminatorType.Custom => "custom",
                CreateWorkflowDtoStepDiscriminatorType.Delay => "delay",
                CreateWorkflowDtoStepDiscriminatorType.Digest => "digest",
                CreateWorkflowDtoStepDiscriminatorType.Email => "email",
                CreateWorkflowDtoStepDiscriminatorType.HttpRequest => "http_request",
                CreateWorkflowDtoStepDiscriminatorType.InApp => "in_app",
                CreateWorkflowDtoStepDiscriminatorType.Push => "push",
                CreateWorkflowDtoStepDiscriminatorType.Sms => "sms",
                CreateWorkflowDtoStepDiscriminatorType.Throttle => "throttle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowDtoStepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CreateWorkflowDtoStepDiscriminatorType.Chat,
                "custom" => CreateWorkflowDtoStepDiscriminatorType.Custom,
                "delay" => CreateWorkflowDtoStepDiscriminatorType.Delay,
                "digest" => CreateWorkflowDtoStepDiscriminatorType.Digest,
                "email" => CreateWorkflowDtoStepDiscriminatorType.Email,
                "http_request" => CreateWorkflowDtoStepDiscriminatorType.HttpRequest,
                "in_app" => CreateWorkflowDtoStepDiscriminatorType.InApp,
                "push" => CreateWorkflowDtoStepDiscriminatorType.Push,
                "sms" => CreateWorkflowDtoStepDiscriminatorType.Sms,
                "throttle" => CreateWorkflowDtoStepDiscriminatorType.Throttle,
                _ => null,
            };
        }
    }
}