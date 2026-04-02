#nullable enable

namespace Novu
{
    public partial interface IContextsClient
    {
        /// <summary>
        /// Update a context<br/>
        /// Update the data of an existing context.<br/>
        ///       **type** and **id** are required fields, **data** is required. Only the data field is updated, the rest of the context is not affected.<br/>
        ///       If the context does not exist, it returns the 404 response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ContextsControllerUpdateContextResponse> ContextsControllerUpdateContextAsync(
            string id,
            string type,

            global::Novu.UpdateContextRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a context<br/>
        /// Update the data of an existing context.<br/>
        ///       **type** and **id** are required fields, **data** is required. Only the data field is updated, the rest of the context is not affected.<br/>
        ///       If the context does not exist, it returns the 404 response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ContextsControllerUpdateContextResponse>> ContextsControllerUpdateContextAsResponseAsync(
            string id,
            string type,

            global::Novu.UpdateContextRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a context<br/>
        /// Update the data of an existing context.<br/>
        ///       **type** and **id** are required fields, **data** is required. Only the data field is updated, the rest of the context is not affected.<br/>
        ///       If the context does not exist, it returns the 404 response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="data">
        /// Custom data to associate with this context. Replaces existing data.<br/>
        /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ContextsControllerUpdateContextResponse> ContextsControllerUpdateContextAsync(
            string id,
            string type,
            object data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}