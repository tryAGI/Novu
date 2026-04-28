
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainsControllerListDomainsOrderDirection
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
    public static class DomainsControllerListDomainsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainsControllerListDomainsOrderDirection value)
        {
            return value switch
            {
                DomainsControllerListDomainsOrderDirection.Asc => "ASC",
                DomainsControllerListDomainsOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainsControllerListDomainsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => DomainsControllerListDomainsOrderDirection.Asc,
                "DESC" => DomainsControllerListDomainsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}