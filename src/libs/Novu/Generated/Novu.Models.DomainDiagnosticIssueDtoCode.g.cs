
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainDiagnosticIssueDtoCode
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
    public static class DomainDiagnosticIssueDtoCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainDiagnosticIssueDtoCode value)
        {
            return value switch
            {
                DomainDiagnosticIssueDtoCode.ApexCnameCollision => "apex_cname_collision",
                DomainDiagnosticIssueDtoCode.DnsblListed => "dnsbl_listed",
                DomainDiagnosticIssueDtoCode.MxLowPriority => "mx_low_priority",
                DomainDiagnosticIssueDtoCode.MxMissing => "mx_missing",
                DomainDiagnosticIssueDtoCode.MxWrongTarget => "mx_wrong_target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainDiagnosticIssueDtoCode? ToEnum(string value)
        {
            return value switch
            {
                "apex_cname_collision" => DomainDiagnosticIssueDtoCode.ApexCnameCollision,
                "dnsbl_listed" => DomainDiagnosticIssueDtoCode.DnsblListed,
                "mx_low_priority" => DomainDiagnosticIssueDtoCode.MxLowPriority,
                "mx_missing" => DomainDiagnosticIssueDtoCode.MxMissing,
                "mx_wrong_target" => DomainDiagnosticIssueDtoCode.MxWrongTarget,
                _ => null,
            };
        }
    }
}