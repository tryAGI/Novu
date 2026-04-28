
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainDiagnosticCheckDtoCode
    {
        /// <summary>
        /// 
        /// </summary>
        ApexCnameCollision,
        /// <summary>
        /// 
        /// </summary>
        DnsblListed,
        /// <summary>
        /// 
        /// </summary>
        MxLowPriority,
        /// <summary>
        /// 
        /// </summary>
        MxMissing,
        /// <summary>
        /// 
        /// </summary>
        MxWrongTarget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainDiagnosticCheckDtoCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainDiagnosticCheckDtoCode value)
        {
            return value switch
            {
                DomainDiagnosticCheckDtoCode.ApexCnameCollision => "apex_cname_collision",
                DomainDiagnosticCheckDtoCode.DnsblListed => "dnsbl_listed",
                DomainDiagnosticCheckDtoCode.MxLowPriority => "mx_low_priority",
                DomainDiagnosticCheckDtoCode.MxMissing => "mx_missing",
                DomainDiagnosticCheckDtoCode.MxWrongTarget => "mx_wrong_target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainDiagnosticCheckDtoCode? ToEnum(string value)
        {
            return value switch
            {
                "apex_cname_collision" => DomainDiagnosticCheckDtoCode.ApexCnameCollision,
                "dnsbl_listed" => DomainDiagnosticCheckDtoCode.DnsblListed,
                "mx_low_priority" => DomainDiagnosticCheckDtoCode.MxLowPriority,
                "mx_missing" => DomainDiagnosticCheckDtoCode.MxMissing,
                "mx_wrong_target" => DomainDiagnosticCheckDtoCode.MxWrongTarget,
                _ => null,
            };
        }
    }
}