
#nullable enable

namespace Novu
{
    /// <summary>
    /// Status of the trigger
    /// </summary>
    public enum TriggerEventResponseDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InvalidRecipients,
        /// <summary>
        /// 
        /// </summary>
        NoTenantFound,
        /// <summary>
        /// 
        /// </summary>
        NoWorkflowActiveStepsDefined,
        /// <summary>
        /// 
        /// </summary>
        NoWorkflowStepsDefined,
        /// <summary>
        /// 
        /// </summary>
        Processed,
        /// <summary>
        /// 
        /// </summary>
        TriggerNotActive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerEventResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerEventResponseDtoStatus value)
        {
            return value switch
            {
                TriggerEventResponseDtoStatus.Error => "error",
                TriggerEventResponseDtoStatus.InvalidRecipients => "invalid_recipients",
                TriggerEventResponseDtoStatus.NoTenantFound => "no_tenant_found",
                TriggerEventResponseDtoStatus.NoWorkflowActiveStepsDefined => "no_workflow_active_steps_defined",
                TriggerEventResponseDtoStatus.NoWorkflowStepsDefined => "no_workflow_steps_defined",
                TriggerEventResponseDtoStatus.Processed => "processed",
                TriggerEventResponseDtoStatus.TriggerNotActive => "trigger_not_active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerEventResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TriggerEventResponseDtoStatus.Error,
                "invalid_recipients" => TriggerEventResponseDtoStatus.InvalidRecipients,
                "no_tenant_found" => TriggerEventResponseDtoStatus.NoTenantFound,
                "no_workflow_active_steps_defined" => TriggerEventResponseDtoStatus.NoWorkflowActiveStepsDefined,
                "no_workflow_steps_defined" => TriggerEventResponseDtoStatus.NoWorkflowStepsDefined,
                "processed" => TriggerEventResponseDtoStatus.Processed,
                "trigger_not_active" => TriggerEventResponseDtoStatus.TriggerNotActive,
                _ => null,
            };
        }
    }
}