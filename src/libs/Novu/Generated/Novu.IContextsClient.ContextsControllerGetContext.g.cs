#nullable enable

namespace Novu
{
    public partial interface IContextsClient
    {
        /// <summary>
        /// Retrieve a context<br/>
        /// Retrieve a specific context by its type and id.<br/>
        ///       **type** and **id** are required fields, if the context does not exist, it returns the 404 response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ContextsControllerGetContextResponse> ContextsControllerGetContextAsync(
            string id,
            string type,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}