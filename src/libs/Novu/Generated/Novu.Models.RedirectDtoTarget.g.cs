
#nullable enable

namespace Novu
{
    /// <summary>
    /// Target window for the redirection.<br/>
    /// Default Value: _self
    /// </summary>
    public enum RedirectDtoTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        Parent,
        /// <summary>
        /// 
        /// </summary>
        Self,
        /// <summary>
        /// 
        /// </summary>
        Top,
        /// <summary>
        /// 
        /// </summary>
        UnfencedTop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RedirectDtoTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RedirectDtoTarget value)
        {
            return value switch
            {
                RedirectDtoTarget.Blank => "_blank",
                RedirectDtoTarget.Parent => "_parent",
                RedirectDtoTarget.Self => "_self",
                RedirectDtoTarget.Top => "_top",
                RedirectDtoTarget.UnfencedTop => "_unfencedTop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RedirectDtoTarget? ToEnum(string value)
        {
            return value switch
            {
                "_blank" => RedirectDtoTarget.Blank,
                "_parent" => RedirectDtoTarget.Parent,
                "_self" => RedirectDtoTarget.Self,
                "_top" => RedirectDtoTarget.Top,
                "_unfencedTop" => RedirectDtoTarget.UnfencedTop,
                _ => null,
            };
        }
    }
}