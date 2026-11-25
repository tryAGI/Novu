
#nullable enable

namespace Novu
{
    /// <summary>
    /// Why the run reached its delivery lifecycle status, e.g. preference or missing_email. Absent when no reason was recorded.
    /// </summary>
    public enum GetWorkflowRunResponseDtoDeliveryLifecycleDetail
    {
        /// <summary>
        ///
        /// </summary>
        ExecutionCanceledByUser,
        /// <summary>
        ///
        /// </summary>
        ExecutionStopped,
        /// <summary>
        ///
        /// </summary>
        MissingEmail,
        /// <summary>
        ///
        /// </summary>
        MissingPhone,
        /// <summary>
        ///
        /// </summary>
        MissingPushToken,
        /// <summary>
        ///
        /// </summary>
        MissingWebhookUrl,
        /// <summary>
        ///
        /// </summary>
        Preference,
        /// <summary>
        ///
        /// </summary>
        SomeChannelsMissingCredentials,
        /// <summary>
        ///
        /// </summary>
        StepCondition,
        /// <summary>
        ///
        /// </summary>
        UnknownError,
        /// <summary>
        ///
        /// </summary>
        WorkflowMissingChannelStep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWorkflowRunResponseDtoDeliveryLifecycleDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunResponseDtoDeliveryLifecycleDetail value)
        {
            return value switch
            {
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.ExecutionCanceledByUser => "execution_canceled_by_user",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.ExecutionStopped => "execution_stopped",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingEmail => "missing_email",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingPhone => "missing_phone",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingPushToken => "missing_push_token",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingWebhookUrl => "missing_webhook_url",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.Preference => "preference",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.SomeChannelsMissingCredentials => "some_channels_missing_credentials",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.StepCondition => "step_condition",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.UnknownError => "unknown_error",
                GetWorkflowRunResponseDtoDeliveryLifecycleDetail.WorkflowMissingChannelStep => "workflow_missing_channel_step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunResponseDtoDeliveryLifecycleDetail? ToEnum(string value)
        {
            return value switch
            {
                "execution_canceled_by_user" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.ExecutionCanceledByUser,
                "execution_stopped" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.ExecutionStopped,
                "missing_email" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingEmail,
                "missing_phone" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingPhone,
                "missing_push_token" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingPushToken,
                "missing_webhook_url" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.MissingWebhookUrl,
                "preference" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.Preference,
                "some_channels_missing_credentials" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.SomeChannelsMissingCredentials,
                "step_condition" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.StepCondition,
                "unknown_error" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.UnknownError,
                "workflow_missing_channel_step" => GetWorkflowRunResponseDtoDeliveryLifecycleDetail.WorkflowMissingChannelStep,
                _ => null,
            };
        }
    }
}