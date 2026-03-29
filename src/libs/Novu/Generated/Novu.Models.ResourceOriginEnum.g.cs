
#nullable enable

namespace Novu
{
    /// <summary>
    /// Origin of the layout
    /// </summary>
    public enum ResourceOriginEnum
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        NovuCloud,
        /// <summary>
        /// 
        /// </summary>
        NovuCloudV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceOriginEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceOriginEnum value)
        {
            return value switch
            {
                ResourceOriginEnum.External => "external",
                ResourceOriginEnum.NovuCloud => "novu-cloud",
                ResourceOriginEnum.NovuCloudV1 => "novu-cloud-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceOriginEnum? ToEnum(string value)
        {
            return value switch
            {
                "external" => ResourceOriginEnum.External,
                "novu-cloud" => ResourceOriginEnum.NovuCloud,
                "novu-cloud-v1" => ResourceOriginEnum.NovuCloudV1,
                _ => null,
            };
        }
    }
}