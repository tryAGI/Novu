
#nullable enable

namespace Novu
{
    public partial class TranslationsClient
    {
        partial void PrepareTranslationControllerUploadTranslationFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Novu.TranslationControllerUploadTranslationFilesRequest request);
        partial void PrepareTranslationControllerUploadTranslationFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Novu.TranslationControllerUploadTranslationFilesRequest request);
        partial void ProcessTranslationControllerUploadTranslationFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranslationControllerUploadTranslationFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload translation files<br/>
        /// Upload one or more JSON translation files for a specific workflow. Files name must match the locale, e.g. en_US.json. Supports both "files" and "files[]" field names for backwards compatibility.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Novu.UploadTranslationsResponseDto> TranslationControllerUploadTranslationFilesAsync(

            global::Novu.TranslationControllerUploadTranslationFilesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranslationControllerUploadTranslationFilesArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Novu.PathBuilder(
                path: "/v2/translations/upload",
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
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.ResourceId}"),
                name: "\"resourceId\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.ResourceType.ToValueString()}"),
                name: "\"resourceType\"");
            for (var __iFiles = 0; __iFiles < request.Files.Count; __iFiles++)
            {
                var __contentFiles = new global::System.Net.Http.ByteArrayContent(request.Files[__iFiles]);
                __httpRequestContent.Add(
                    content: __contentFiles,
                    name: "\"files\"",
                    fileName: $"\"file{__iFiles}.bin\"");
                if (__contentFiles.Headers.ContentDisposition != null)
                {
                    __contentFiles.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTranslationControllerUploadTranslationFilesRequest(
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
            ProcessTranslationControllerUploadTranslationFilesResponse(
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
                ProcessTranslationControllerUploadTranslationFilesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Novu.UploadTranslationsResponseDto.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Novu.UploadTranslationsResponseDto.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Upload translation files<br/>
        /// Upload one or more JSON translation files for a specific workflow. Files name must match the locale, e.g. en_US.json. Supports both "files" and "files[]" field names for backwards compatibility.
        /// </summary>
        /// <param name="resourceId">
        /// The resource ID to associate localizations with. Accepts identifier or slug format<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="resourceType">
        /// The resource type to associate localizations with
        /// </param>
        /// <param name="files">
        /// One or more JSON translation files. Filenames must match locale format (e.g., en_US.json, fr_FR.json). Field name can be "files" or "files[]".
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Novu.UploadTranslationsResponseDto> TranslationControllerUploadTranslationFilesAsync(
            string resourceId,
            global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType resourceType,
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Novu.TranslationControllerUploadTranslationFilesRequest
            {
                ResourceId = resourceId,
                ResourceType = resourceType,
                Files = files,
            };

            return await TranslationControllerUploadTranslationFilesAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}