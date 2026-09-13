
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>), TypeInfoPropertyName = "ListLayoutResponseDto_System_Collections_Generic_List_global_Novu_LayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>), TypeInfoPropertyName = "OneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>), TypeInfoPropertyName = "AnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ConstraintValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ValidationErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.ConstraintValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceOriginEnum), TypeInfoPropertyName = "ResourceOriginEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatOrPushProviderEnum), TypeInfoPropertyName = "ChatOrPushProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelSettingsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UserResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceTypeEnum), TypeInfoPropertyName = "ResourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiComponentEnum), TypeInfoPropertyName = "UiComponentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>), TypeInfoPropertyName = "AnyOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchemaGroupEnum), TypeInfoPropertyName = "UiSchemaGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsDtoEditorType), TypeInfoPropertyName = "EmailControlsDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutControlValuesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutControlsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutCreationSourceEnum), TypeInfoPropertyName = "LayoutCreationSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateLayoutDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateLayoutDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DuplicateLayoutDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DirectionEnum), TypeInfoPropertyName = "DirectionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutResponseDtoSortField), TypeInfoPropertyName = "LayoutResponseDtoSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailLayoutRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberResponseDtoOptional))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutPreviewPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDtoResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType), TypeInfoPropertyName = "GenerateLayoutPreviewResponseDtoResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutPreviewRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetLayoutUsageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerGeneratePreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerGetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceOriginEnum?), TypeInfoPropertyName = "NullableResourceOriginEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatOrPushProviderEnum?), TypeInfoPropertyName = "NullableChatOrPushProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceTypeEnum?), TypeInfoPropertyName = "NullableResourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiComponentEnum?), TypeInfoPropertyName = "NullableUiComponentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchemaGroupEnum?), TypeInfoPropertyName = "NullableUiSchemaGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsDtoEditorType?), TypeInfoPropertyName = "NullableEmailControlsDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutCreationSourceEnum?), TypeInfoPropertyName = "NullableLayoutCreationSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DirectionEnum?), TypeInfoPropertyName = "NullableDirectionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutResponseDtoSortField?), TypeInfoPropertyName = "NullableLayoutResponseDtoSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType?), TypeInfoPropertyName = "NullableGenerateLayoutPreviewResponseDtoResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>))]
    internal sealed partial class LayoutsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayoutsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LayoutsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LayoutsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Novu.ResourceOriginEnum)

                    || typeToConvert == typeof(global::Novu.ResourceOriginEnum?)

                    || typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum)

                    || typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum?)

                    || typeToConvert == typeof(global::Novu.ResourceTypeEnum)

                    || typeToConvert == typeof(global::Novu.ResourceTypeEnum?)

                    || typeToConvert == typeof(global::Novu.UiComponentEnum)

                    || typeToConvert == typeof(global::Novu.UiComponentEnum?)

                    || typeToConvert == typeof(global::Novu.UiSchemaGroupEnum)

                    || typeToConvert == typeof(global::Novu.UiSchemaGroupEnum?)

                    || typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType)

                    || typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType?)

                    || typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum)

                    || typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum?)

                    || typeToConvert == typeof(global::Novu.DirectionEnum)

                    || typeToConvert == typeof(global::Novu.DirectionEnum?)

                    || typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField)

                    || typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField?)

                    || typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType)

                    || typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.ResourceOriginEnum))
                {
                    return new global::Novu.JsonConverters.ResourceOriginEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceOriginEnum?))
                {
                    return new global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum))
                {
                    return new global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum?))
                {
                    return new global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceTypeEnum))
                {
                    return new global::Novu.JsonConverters.ResourceTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiComponentEnum))
                {
                    return new global::Novu.JsonConverters.UiComponentEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiComponentEnum?))
                {
                    return new global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiSchemaGroupEnum))
                {
                    return new global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiSchemaGroupEnum?))
                {
                    return new global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType))
                {
                    return new global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType?))
                {
                    return new global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum))
                {
                    return new global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum?))
                {
                    return new global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DirectionEnum))
                {
                    return new global::Novu.JsonConverters.DirectionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DirectionEnum?))
                {
                    return new global::Novu.JsonConverters.DirectionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField))
                {
                    return new global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField?))
                {
                    return new global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType))
                {
                    return new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType?))
                {
                    return new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new LayoutsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}