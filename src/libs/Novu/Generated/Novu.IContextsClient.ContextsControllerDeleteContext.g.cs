#nullable enable

namespace Novu
{
    public partial interface IContextsClient
    {
        /// <summary>
        /// Delete a context<br/>
        /// Delete a context by its type and id.<br/>
        ///       **type** and **id** are required fields, if the context does not exist, it returns the 404 response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task ContextsControllerDeleteContextAsync(
            string id,
            string type,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}