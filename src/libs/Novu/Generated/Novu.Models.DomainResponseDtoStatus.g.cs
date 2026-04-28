
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainResponseDtoStatus
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
    public static class DomainResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainResponseDtoStatus value)
        {
            return value switch
            {
                DomainResponseDtoStatus.Pending => "pending",
                DomainResponseDtoStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => DomainResponseDtoStatus.Pending,
                "verified" => DomainResponseDtoStatus.Verified,
                _ => null,
            };
        }
    }
}