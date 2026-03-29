
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelConnectionsControllerListChannelConnectionsOrderDirection
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
    public static class ChannelConnectionsControllerListChannelConnectionsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelConnectionsControllerListChannelConnectionsOrderDirection value)
        {
            return value switch
            {
                ChannelConnectionsControllerListChannelConnectionsOrderDirection.Asc => "ASC",
                ChannelConnectionsControllerListChannelConnectionsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelConnectionsControllerListChannelConnectionsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ChannelConnectionsControllerListChannelConnectionsOrderDirection.Asc,
                "DESC" => ChannelConnectionsControllerListChannelConnectionsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}