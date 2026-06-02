
#nullable enable

namespace Novu
{
    /// <summary>
    /// Origin of the request: 'http' for API triggers or 'inbound_email' for inbound mail
    /// </summary>
    public enum RequestLogResponseDtoSource
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
    public static class RequestLogResponseDtoSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestLogResponseDtoSource value)
        {
            return value switch
            {
                RequestLogResponseDtoSource.Http => "http",
                RequestLogResponseDtoSource.InboundEmail => "inbound_email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestLogResponseDtoSource? ToEnum(string value)
        {
            return value switch
            {
                "http" => RequestLogResponseDtoSource.Http,
                "inbound_email" => RequestLogResponseDtoSource.InboundEmail,
                _ => null,
            };
        }
    }
}