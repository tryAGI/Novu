
#nullable enable

namespace Novu
{
    public sealed partial class NovuClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Novu.EndPointAuthorization
            {
                Type = "",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}