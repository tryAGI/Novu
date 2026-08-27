
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentsControllerListAgentsOrderDirection
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
    public static class AgentsControllerListAgentsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsControllerListAgentsOrderDirection value)
        {
            return value switch
            {
                AgentsControllerListAgentsOrderDirection.Asc => "ASC",
                AgentsControllerListAgentsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsControllerListAgentsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => AgentsControllerListAgentsOrderDirection.Asc,
                "DESC" => AgentsControllerListAgentsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}