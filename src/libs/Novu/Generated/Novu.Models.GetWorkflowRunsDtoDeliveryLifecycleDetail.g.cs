
#nullable enable

namespace Novu
{
    /// <summary>
    /// Why the run reached its delivery lifecycle status, e.g. preference or missing_email. Absent when no reason was recorded.
    /// </summary>
    public enum GetWorkflowRunsDtoDeliveryLifecycleDetail
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
    public static class GetWorkflowRunsDtoDeliveryLifecycleDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunsDtoDeliveryLifecycleDetail value)
        {
            return value switch
            {
                GetWorkflowRunsDtoDeliveryLifecycleDetail.ExecutionCanceledByUser => "execution_canceled_by_user",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.ExecutionStopped => "execution_stopped",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingEmail => "missing_email",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingPhone => "missing_phone",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingPushToken => "missing_push_token",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingWebhookUrl => "missing_webhook_url",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.Preference => "preference",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.SomeChannelsMissingCredentials => "some_channels_missing_credentials",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.StepCondition => "step_condition",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.UnknownError => "unknown_error",
                GetWorkflowRunsDtoDeliveryLifecycleDetail.WorkflowMissingChannelStep => "workflow_missing_channel_step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunsDtoDeliveryLifecycleDetail? ToEnum(string value)
        {
            return value switch
            {
                "execution_canceled_by_user" => GetWorkflowRunsDtoDeliveryLifecycleDetail.ExecutionCanceledByUser,
                "execution_stopped" => GetWorkflowRunsDtoDeliveryLifecycleDetail.ExecutionStopped,
                "missing_email" => GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingEmail,
                "missing_phone" => GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingPhone,
                "missing_push_token" => GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingPushToken,
                "missing_webhook_url" => GetWorkflowRunsDtoDeliveryLifecycleDetail.MissingWebhookUrl,
                "preference" => GetWorkflowRunsDtoDeliveryLifecycleDetail.Preference,
                "some_channels_missing_credentials" => GetWorkflowRunsDtoDeliveryLifecycleDetail.SomeChannelsMissingCredentials,
                "step_condition" => GetWorkflowRunsDtoDeliveryLifecycleDetail.StepCondition,
                "unknown_error" => GetWorkflowRunsDtoDeliveryLifecycleDetail.UnknownError,
                "workflow_missing_channel_step" => GetWorkflowRunsDtoDeliveryLifecycleDetail.WorkflowMissingChannelStep,
                _ => null,
            };
        }
    }
}