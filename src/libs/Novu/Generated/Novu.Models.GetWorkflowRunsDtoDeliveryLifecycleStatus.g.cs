
#nullable enable

namespace Novu
{
    /// <summary>
    /// Workflow run delivery lifecycle status
    /// </summary>
    public enum GetWorkflowRunsDtoDeliveryLifecycleStatus
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
    public static class GetWorkflowRunsDtoDeliveryLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunsDtoDeliveryLifecycleStatus value)
        {
            return value switch
            {
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Canceled => "canceled",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Delivered => "delivered",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Errored => "errored",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Interacted => "interacted",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Merged => "merged",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Pending => "pending",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Sent => "sent",
                GetWorkflowRunsDtoDeliveryLifecycleStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunsDtoDeliveryLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Canceled,
                "delivered" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Delivered,
                "errored" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Errored,
                "interacted" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Interacted,
                "merged" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Merged,
                "pending" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Pending,
                "sent" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Sent,
                "skipped" => GetWorkflowRunsDtoDeliveryLifecycleStatus.Skipped,
                _ => null,
            };
        }
    }
}