
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of integration issue
    /// </summary>
    public enum IntegrationIssueEnum
    {
        /// <summary>
        /// 
        /// </summary>
        InboxNotConnected,
        /// <summary>
        /// 
        /// </summary>
        MissingIntegration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationIssueEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationIssueEnum value)
        {
            return value switch
            {
                IntegrationIssueEnum.InboxNotConnected => "INBOX_NOT_CONNECTED",
                IntegrationIssueEnum.MissingIntegration => "MISSING_INTEGRATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationIssueEnum? ToEnum(string value)
        {
            return value switch
            {
                "INBOX_NOT_CONNECTED" => IntegrationIssueEnum.InboxNotConnected,
                "MISSING_INTEGRATION" => IntegrationIssueEnum.MissingIntegration,
                _ => null,
            };
        }
    }
}