
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelEndpointsControllerListChannelEndpointsOrderDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelEndpointsControllerListChannelEndpointsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEndpointsControllerListChannelEndpointsOrderDirection value)
        {
            return value switch
            {
                ChannelEndpointsControllerListChannelEndpointsOrderDirection.Asc => "ASC",
                ChannelEndpointsControllerListChannelEndpointsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEndpointsControllerListChannelEndpointsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ChannelEndpointsControllerListChannelEndpointsOrderDirection.Asc,
                "DESC" => ChannelEndpointsControllerListChannelEndpointsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}