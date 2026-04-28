
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainsControllerListDomainRoutesOrderDirection
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
    public static class DomainsControllerListDomainRoutesOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainsControllerListDomainRoutesOrderDirection value)
        {
            return value switch
            {
                DomainsControllerListDomainRoutesOrderDirection.Asc => "ASC",
                DomainsControllerListDomainRoutesOrderDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainsControllerListDomainRoutesOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => DomainsControllerListDomainRoutesOrderDirection.Asc,
                "DESC" => DomainsControllerListDomainRoutesOrderDirection.Desc,
                _ => null,
            };
        }
    }
}