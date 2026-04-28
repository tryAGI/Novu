
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainDiagnosticIssueDtoSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainDiagnosticIssueDtoSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainDiagnosticIssueDtoSeverity value)
        {
            return value switch
            {
                DomainDiagnosticIssueDtoSeverity.Error => "error",
                DomainDiagnosticIssueDtoSeverity.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainDiagnosticIssueDtoSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => DomainDiagnosticIssueDtoSeverity.Error,
                "warn" => DomainDiagnosticIssueDtoSeverity.Warn,
                _ => null,
            };
        }
    }
}