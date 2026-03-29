
#nullable enable

namespace Novu
{
    /// <summary>
    /// Source of the execution detail
    /// </summary>
    public enum ExecutionDetailsSourceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Credentials,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Payload,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionDetailsSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionDetailsSourceEnum value)
        {
            return value switch
            {
                ExecutionDetailsSourceEnum.Credentials => "Credentials",
                ExecutionDetailsSourceEnum.Internal => "Internal",
                ExecutionDetailsSourceEnum.Payload => "Payload",
                ExecutionDetailsSourceEnum.Webhook => "Webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionDetailsSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "Credentials" => ExecutionDetailsSourceEnum.Credentials,
                "Internal" => ExecutionDetailsSourceEnum.Internal,
                "Payload" => ExecutionDetailsSourceEnum.Payload,
                "Webhook" => ExecutionDetailsSourceEnum.Webhook,
                _ => null,
            };
        }
    }
}