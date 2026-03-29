
#nullable enable

namespace Novu
{
    /// <summary>
    /// Workflow run delivery lifecycle status
    /// </summary>
    public enum GetWorkflowRunResponseDtoDeliveryLifecycleStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Delivered,
        /// <summary>
        /// 
        /// </summary>
        Errored,
        /// <summary>
        /// 
        /// </summary>
        Interacted,
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Sent,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWorkflowRunResponseDtoDeliveryLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunResponseDtoDeliveryLifecycleStatus value)
        {
            return value switch
            {
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Canceled => "canceled",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Delivered => "delivered",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Errored => "errored",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Interacted => "interacted",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Merged => "merged",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Pending => "pending",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Sent => "sent",
                GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunResponseDtoDeliveryLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Canceled,
                "delivered" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Delivered,
                "errored" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Errored,
                "interacted" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Interacted,
                "merged" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Merged,
                "pending" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Pending,
                "sent" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Sent,
                "skipped" => GetWorkflowRunResponseDtoDeliveryLifecycleStatus.Skipped,
                _ => null,
            };
        }
    }
}