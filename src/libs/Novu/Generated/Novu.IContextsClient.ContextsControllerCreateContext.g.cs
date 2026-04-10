#nullable enable

namespace Novu
{
    public partial interface IContextsClient
    {
        /// <summary>
        /// Create a context<br/>
        /// Create a new context with the specified type, id, and data. Returns 409 if context already exists.<br/>
        ///       **type** and **id** are required fields, **data** is optional, if the context already exists, it returns the 409 response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ContextsControllerCreateContextResponse> ContextsControllerCreateContextAsync(

            global::Novu.CreateContextRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a context<br/>
        /// Create a new context with the specified type, id, and data. Returns 409 if context already exists.<br/>
        ///       **type** and **id** are required fields, **data** is optional, if the context already exists, it returns the 409 response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ContextsControllerCreateContextResponse>> ContextsControllerCreateContextAsResponseAsync(

            global::Novu.CreateContextRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a context<br/>
        /// Create a new context with the specified type, id, and data. Returns 409 if context already exists.<br/>
        ///       **type** and **id** are required fields, **data** is optional, if the context already exists, it returns the 409 response
        /// </summary>
        /// <param name="type">
        /// Context type (e.g., tenant, app, workspace). Must be lowercase alphanumeric with optional separators.<br/>
        /// Example: tenant
        /// </param>
        /// <param name="id">
        /// Unique identifier for this context. Must be lowercase alphanumeric with optional separators.<br/>
        /// Example: org-acme
        /// </param>
        /// <param name="data">
        /// Optional custom data to associate with this context.<br/>
        /// Example: {"tenantName":"Acme Corp","region":"us-east-1","settings":{"theme":"dark"}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ContextsControllerCreateContextResponse> ContextsControllerCreateContextAsync(
            string type,
            string id,
            object? data = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}