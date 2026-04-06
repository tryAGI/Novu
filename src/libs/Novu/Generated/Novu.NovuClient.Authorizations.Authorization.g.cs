
#nullable enable

namespace Novu
{
    public sealed partial class NovuClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            Authorizations.Clear();
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