
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SeverityLevelEnum), TypeInfoPropertyName = "SeverityLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriptionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListTopicSubscriptionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriberDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListTopicsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateUpdateTopicRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateTopicRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetaDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSubscriptionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowPreferenceRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GroupPreferenceFilterDetailsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GroupPreferenceFilterDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriberIdentifierDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTopicSubscriptionsRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>), TypeInfoPropertyName = "OneOfStringTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateTopicSubscriptionsRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTopicSubscriptionsRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>), TypeInfoPropertyName = "OneOfStringWorkflowPreferenceRequestDtoGroupPreferenceFilterDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionsDeleteErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicSubscriptionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicSubscriberIdentifierDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicSubscriptionsRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>), TypeInfoPropertyName = "OneOfStringDeleteTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionDetailsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateTopicSubscriptionRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicsOrderDirection), TypeInfoPropertyName = "TopicsControllerListTopicsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection), TypeInfoPropertyName = "TopicsControllerListTopicSubscriptionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpsertTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpsertTopicResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerGetTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpdateTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerDeleteTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerCreateTopicSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerGetTopicSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpdateTopicSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SeverityLevelEnum?), TypeInfoPropertyName = "NullableSeverityLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>?), TypeInfoPropertyName = "NullableOneOfStringTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateTopicSubscriptionsRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>?), TypeInfoPropertyName = "NullableOneOfStringWorkflowPreferenceRequestDtoGroupPreferenceFilterDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>?), TypeInfoPropertyName = "NullableOneOfStringDeleteTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicsOrderDirection?), TypeInfoPropertyName = "NullableTopicsControllerListTopicsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?), TypeInfoPropertyName = "NullableTopicsControllerListTopicSubscriptionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TopicResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>))]
    internal sealed partial class TopicsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TopicsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TopicsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TopicsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TopicSubscriberIdentifierDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.DeleteTopicSubscriberIdentifierDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>());
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
                    typeToConvert == typeof(global::Novu.SeverityLevelEnum)

                    || typeToConvert == typeof(global::Novu.SeverityLevelEnum?)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.SeverityLevelEnum))
                {
                    return new global::Novu.JsonConverters.SeverityLevelEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SeverityLevelEnum?))
                {
                    return new global::Novu.JsonConverters.SeverityLevelEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter();
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
                    0 => new TopicsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}