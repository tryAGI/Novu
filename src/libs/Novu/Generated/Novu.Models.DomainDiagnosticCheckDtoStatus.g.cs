
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainDiagnosticCheckDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Pass,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainDiagnosticCheckDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainDiagnosticCheckDtoStatus value)
        {
            return value switch
            {
                DomainDiagnosticCheckDtoStatus.Fail => "fail",
                DomainDiagnosticCheckDtoStatus.Pass => "pass",
                DomainDiagnosticCheckDtoStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainDiagnosticCheckDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "fail" => DomainDiagnosticCheckDtoStatus.Fail,
                "pass" => DomainDiagnosticCheckDtoStatus.Pass,
                "skipped" => DomainDiagnosticCheckDtoStatus.Skipped,
                _ => null,
            };
        }
    }
}