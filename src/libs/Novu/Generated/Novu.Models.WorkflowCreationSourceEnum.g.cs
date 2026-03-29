
#nullable enable

namespace Novu
{
    /// <summary>
    /// Source of workflow creation<br/>
    /// Default Value: editor
    /// </summary>
    public enum WorkflowCreationSourceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Bridge,
        /// <summary>
        /// 
        /// </summary>
        Dashboard,
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        EmptyState,
        /// <summary>
        /// 
        /// </summary>
        NotificationDirectory,
        /// <summary>
        /// 
        /// </summary>
        OnboardingDigestDemo,
        /// <summary>
        /// 
        /// </summary>
        OnboardingGetStarted,
        /// <summary>
        /// 
        /// </summary>
        OnboardingInApp,
        /// <summary>
        /// 
        /// </summary>
        TemplateStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCreationSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCreationSourceEnum value)
        {
            return value switch
            {
                WorkflowCreationSourceEnum.Ai => "ai",
                WorkflowCreationSourceEnum.Bridge => "bridge",
                WorkflowCreationSourceEnum.Dashboard => "dashboard",
                WorkflowCreationSourceEnum.Dropdown => "dropdown",
                WorkflowCreationSourceEnum.Editor => "editor",
                WorkflowCreationSourceEnum.EmptyState => "empty_state",
                WorkflowCreationSourceEnum.NotificationDirectory => "notification_directory",
                WorkflowCreationSourceEnum.OnboardingDigestDemo => "onboarding_digest_demo",
                WorkflowCreationSourceEnum.OnboardingGetStarted => "onboarding_get_started",
                WorkflowCreationSourceEnum.OnboardingInApp => "onboarding_in_app",
                WorkflowCreationSourceEnum.TemplateStore => "template_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCreationSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "ai" => WorkflowCreationSourceEnum.Ai,
                "bridge" => WorkflowCreationSourceEnum.Bridge,
                "dashboard" => WorkflowCreationSourceEnum.Dashboard,
                "dropdown" => WorkflowCreationSourceEnum.Dropdown,
                "editor" => WorkflowCreationSourceEnum.Editor,
                "empty_state" => WorkflowCreationSourceEnum.EmptyState,
                "notification_directory" => WorkflowCreationSourceEnum.NotificationDirectory,
                "onboarding_digest_demo" => WorkflowCreationSourceEnum.OnboardingDigestDemo,
                "onboarding_get_started" => WorkflowCreationSourceEnum.OnboardingGetStarted,
                "onboarding_in_app" => WorkflowCreationSourceEnum.OnboardingInApp,
                "template_store" => WorkflowCreationSourceEnum.TemplateStore,
                _ => null,
            };
        }
    }
}