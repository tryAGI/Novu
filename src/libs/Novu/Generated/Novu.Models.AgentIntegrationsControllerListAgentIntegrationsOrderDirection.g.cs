
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentIntegrationsControllerListAgentIntegrationsOrderDirection
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
    public static class AgentIntegrationsControllerListAgentIntegrationsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentIntegrationsControllerListAgentIntegrationsOrderDirection value)
        {
            return value switch
            {
                AgentIntegrationsControllerListAgentIntegrationsOrderDirection.Asc => "ASC",
                AgentIntegrationsControllerListAgentIntegrationsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentIntegrationsControllerListAgentIntegrationsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => AgentIntegrationsControllerListAgentIntegrationsOrderDirection.Asc,
                "DESC" => AgentIntegrationsControllerListAgentIntegrationsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}