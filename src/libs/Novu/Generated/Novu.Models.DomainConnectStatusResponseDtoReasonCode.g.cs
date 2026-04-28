
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainConnectStatusResponseDtoReasonCode
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        DiscoveryNotConfigured,
        /// <summary>
        /// 
        /// </summary>
        IncompleteConfiguration,
        /// <summary>
        /// 
        /// </summary>
        ProviderSettingsUnavailable,
        /// <summary>
        /// 
        /// </summary>
        TemplateNotOnboarded,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedProvider,
        /// <summary>
        /// 
        /// </summary>
        UntrustedProviderFlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainConnectStatusResponseDtoReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainConnectStatusResponseDtoReasonCode value)
        {
            return value switch
            {
                DomainConnectStatusResponseDtoReasonCode.Disabled => "disabled",
                DomainConnectStatusResponseDtoReasonCode.DiscoveryNotConfigured => "discovery_not_configured",
                DomainConnectStatusResponseDtoReasonCode.IncompleteConfiguration => "incomplete_configuration",
                DomainConnectStatusResponseDtoReasonCode.ProviderSettingsUnavailable => "provider_settings_unavailable",
                DomainConnectStatusResponseDtoReasonCode.TemplateNotOnboarded => "template_not_onboarded",
                DomainConnectStatusResponseDtoReasonCode.UnsupportedProvider => "unsupported_provider",
                DomainConnectStatusResponseDtoReasonCode.UntrustedProviderFlow => "untrusted_provider_flow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainConnectStatusResponseDtoReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => DomainConnectStatusResponseDtoReasonCode.Disabled,
                "discovery_not_configured" => DomainConnectStatusResponseDtoReasonCode.DiscoveryNotConfigured,
                "incomplete_configuration" => DomainConnectStatusResponseDtoReasonCode.IncompleteConfiguration,
                "provider_settings_unavailable" => DomainConnectStatusResponseDtoReasonCode.ProviderSettingsUnavailable,
                "template_not_onboarded" => DomainConnectStatusResponseDtoReasonCode.TemplateNotOnboarded,
                "unsupported_provider" => DomainConnectStatusResponseDtoReasonCode.UnsupportedProvider,
                "untrusted_provider_flow" => DomainConnectStatusResponseDtoReasonCode.UntrustedProviderFlow,
                _ => null,
            };
        }
    }
}