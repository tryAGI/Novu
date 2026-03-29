
#nullable enable

namespace Novu
{
    /// <summary>
    /// HTTP method
    /// </summary>
    public enum HttpMethodEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HttpMethodEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HttpMethodEnum value)
        {
            return value switch
            {
                HttpMethodEnum.Delete => "DELETE",
                HttpMethodEnum.Get => "GET",
                HttpMethodEnum.Patch => "PATCH",
                HttpMethodEnum.Post => "POST",
                HttpMethodEnum.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HttpMethodEnum? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => HttpMethodEnum.Delete,
                "GET" => HttpMethodEnum.Get,
                "PATCH" => HttpMethodEnum.Patch,
                "POST" => HttpMethodEnum.Post,
                "PUT" => HttpMethodEnum.Put,
                _ => null,
            };
        }
    }
}