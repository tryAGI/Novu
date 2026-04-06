
#nullable enable

namespace Novu
{
    public partial class TranslationsClient
    {
        partial void PrepareTranslationControllerUploadMasterJsonEndpointArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Novu.TranslationControllerUploadMasterJsonEndpointRequest request);
        partial void PrepareTranslationControllerUploadMasterJsonEndpointRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Novu.TranslationControllerUploadMasterJsonEndpointRequest request);
        partial void ProcessTranslationControllerUploadMasterJsonEndpointResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranslationControllerUploadMasterJsonEndpointResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload master translations JSON file<br/>
        /// Upload a master JSON file containing translations for multiple workflows. Locale is automatically detected from filename (e.g., en_US.json)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Novu.ImportMasterJsonResponseDto> TranslationControllerUploadMasterJsonEndpointAsync(

            global::Novu.TranslationControllerUploadMasterJsonEndpointRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranslationControllerUploadMasterJsonEndpointArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Novu.PathBuilder(
                path: "/v2/translations/master-json/upload",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTranslationControllerUploadMasterJsonEndpointRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTranslationControllerUploadMasterJsonEndpointResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessTranslationControllerUploadMasterJsonEndpointResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Novu.ImportMasterJsonResponseDto.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Novu.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Novu.ImportMasterJsonResponseDto.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Novu.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Upload master translations JSON file<br/>
        /// Upload a master JSON file containing translations for multiple workflows. Locale is automatically detected from filename (e.g., en_US.json)
        /// </summary>
        /// <param name="file">
        /// Master JSON file with locale as filename (e.g., en_US.json)
        /// </param>
        /// <param name="filename">
        /// Master JSON file with locale as filename (e.g., en_US.json)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Novu.ImportMasterJsonResponseDto> TranslationControllerUploadMasterJsonEndpointAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Novu.TranslationControllerUploadMasterJsonEndpointRequest
            {
                File = file,
                Filename = filename,
            };

            return await TranslationControllerUploadMasterJsonEndpointAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}