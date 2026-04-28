
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDomainRouteResponseDtoDomainStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestDomainRouteResponseDtoDomainStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDomainRouteResponseDtoDomainStatus value)
        {
            return value switch
            {
                TestDomainRouteResponseDtoDomainStatus.Pending => "pending",
                TestDomainRouteResponseDtoDomainStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDomainRouteResponseDtoDomainStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => TestDomainRouteResponseDtoDomainStatus.Pending,
                "verified" => TestDomainRouteResponseDtoDomainStatus.Verified,
                _ => null,
            };
        }
    }
}