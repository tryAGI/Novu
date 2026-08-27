
#nullable enable

namespace Novu
{
    /// <summary>
    /// Which constraint produced the limits. `plan` limits are lifted by upgrading; `system` limits (platform cap or per-organization override) require contacting the Novu team.
    /// </summary>
    public enum AgentPlanUsageDtoLimitSource
    {
        /// <summary>
        ///
        /// </summary>
        Plan,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPlanUsageDtoLimitSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPlanUsageDtoLimitSource value)
        {
            return value switch
            {
                AgentPlanUsageDtoLimitSource.Plan => "plan",
                AgentPlanUsageDtoLimitSource.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPlanUsageDtoLimitSource? ToEnum(string value)
        {
            return value switch
            {
                "plan" => AgentPlanUsageDtoLimitSource.Plan,
                "system" => AgentPlanUsageDtoLimitSource.System,
                _ => null,
            };
        }
    }
}