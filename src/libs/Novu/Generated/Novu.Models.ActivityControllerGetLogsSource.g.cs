
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum ActivityControllerGetLogsSource
    {
        /// <summary>
        /// 'http' for API triggers or 'inbound_email' for inbound mail
        /// </summary>
        Http,
        /// <summary>
        /// 'http' for API triggers or 'inbound_email' for inbound mail
        /// </summary>
        InboundEmail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityControllerGetLogsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityControllerGetLogsSource value)
        {
            return value switch
            {
                ActivityControllerGetLogsSource.Http => "http",
                ActivityControllerGetLogsSource.InboundEmail => "inbound_email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityControllerGetLogsSource? ToEnum(string value)
        {
            return value switch
            {
                "http" => ActivityControllerGetLogsSource.Http,
                "inbound_email" => ActivityControllerGetLogsSource.InboundEmail,
                _ => null,
            };
        }
    }
}