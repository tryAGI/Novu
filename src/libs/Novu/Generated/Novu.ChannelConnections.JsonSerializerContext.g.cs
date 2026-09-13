
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ProvidersIdEnum), TypeInfoPropertyName = "ProvidersIdEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkspaceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AuthDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoChannel), TypeInfoPropertyName = "GetChannelConnectionResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoProviderId), TypeInfoPropertyName = "GetChannelConnectionResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListChannelConnectionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateChannelConnectionRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode), TypeInfoPropertyName = "CreateChannelConnectionRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateChannelConnectionRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection), TypeInfoPropertyName = "ChannelConnectionsControllerListChannelConnectionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode), TypeInfoPropertyName = "ChannelConnectionsControllerListChannelConnectionsConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel), TypeInfoPropertyName = "ChannelConnectionsControllerListChannelConnectionsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ProvidersIdEnum?), TypeInfoPropertyName = "NullableProvidersIdEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoChannel?), TypeInfoPropertyName = "NullableGetChannelConnectionResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoProviderId?), TypeInfoPropertyName = "NullableGetChannelConnectionResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateChannelConnectionRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode?), TypeInfoPropertyName = "NullableCreateChannelConnectionRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection?), TypeInfoPropertyName = "NullableChannelConnectionsControllerListChannelConnectionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode?), TypeInfoPropertyName = "NullableChannelConnectionsControllerListChannelConnectionsConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?), TypeInfoPropertyName = "NullableChannelConnectionsControllerListChannelConnectionsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>))]
    internal sealed partial class ChannelConnectionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelConnectionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChannelConnectionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChannelConnectionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>());
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
                    typeToConvert == typeof(global::Novu.ProvidersIdEnum)

                    || typeToConvert == typeof(global::Novu.ProvidersIdEnum?)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel?)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId?)

                    || typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode)

                    || typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode?)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode?)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.ProvidersIdEnum))
                {
                    return new global::Novu.JsonConverters.ProvidersIdEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ProvidersIdEnum?))
                {
                    return new global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel?))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId?))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode))
                {
                    return new global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode?))
                {
                    return new global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode?))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsConnectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter();
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
                    0 => new ChannelConnectionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}