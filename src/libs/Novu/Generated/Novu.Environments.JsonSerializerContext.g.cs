
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ApiKeyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentResponseDtoType), TypeInfoPropertyName = "EnvironmentResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ApiKeyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InBoundParseDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BridgeConfigurationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceTypeEnum), TypeInfoPropertyName = "ResourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetEnvironmentTagsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncActionEnum), TypeInfoPropertyName = "SyncActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FailedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SkippedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PublishSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PublishEnvironmentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SyncResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceToPublishDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PublishEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UserInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffActionEnum), TypeInfoPropertyName = "DiffActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDiffDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDiffDtoDiffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DependencyReasonEnum), TypeInfoPropertyName = "DependencyReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDependencyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDiffResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentDiffSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffEnvironmentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerPublishEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerDiffEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentResponseDtoType?), TypeInfoPropertyName = "NullableEnvironmentResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceTypeEnum?), TypeInfoPropertyName = "NullableResourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncActionEnum?), TypeInfoPropertyName = "NullableSyncActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffActionEnum?), TypeInfoPropertyName = "NullableDiffActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DependencyReasonEnum?), TypeInfoPropertyName = "NullableDependencyReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ApiKeyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SyncResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>))]
    internal sealed partial class EnvironmentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EnvironmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType)

                    || typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.ResourceTypeEnum)

                    || typeToConvert == typeof(global::Novu.ResourceTypeEnum?)

                    || typeToConvert == typeof(global::Novu.SyncActionEnum)

                    || typeToConvert == typeof(global::Novu.SyncActionEnum?)

                    || typeToConvert == typeof(global::Novu.DiffActionEnum)

                    || typeToConvert == typeof(global::Novu.DiffActionEnum?)

                    || typeToConvert == typeof(global::Novu.DependencyReasonEnum)

                    || typeToConvert == typeof(global::Novu.DependencyReasonEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType))
                {
                    return new global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceTypeEnum))
                {
                    return new global::Novu.JsonConverters.ResourceTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SyncActionEnum))
                {
                    return new global::Novu.JsonConverters.SyncActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SyncActionEnum?))
                {
                    return new global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DiffActionEnum))
                {
                    return new global::Novu.JsonConverters.DiffActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DiffActionEnum?))
                {
                    return new global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DependencyReasonEnum))
                {
                    return new global::Novu.JsonConverters.DependencyReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DependencyReasonEnum?))
                {
                    return new global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter();
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
                    0 => new EnvironmentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}