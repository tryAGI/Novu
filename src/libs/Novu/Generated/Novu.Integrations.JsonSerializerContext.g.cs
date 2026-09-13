
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum), TypeInfoPropertyName = "BuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator), TypeInfoPropertyName = "FieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn), TypeInfoPropertyName = "FieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue), TypeInfoPropertyName = "StepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CredentialsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CredentialsDtoHmacSecretKeyEncoding), TypeInfoPropertyName = "CredentialsDtoHmacSecretKeyEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ConfigurationsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoChannel), TypeInfoPropertyName = "IntegrationResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoKind), TypeInfoPropertyName = "IntegrationResponseDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoChannel), TypeInfoPropertyName = "CreateIntegrationRequestDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoKind), TypeInfoPropertyName = "CreateIntegrationRequestDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateIntegrationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AutoConfigureIntegrationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOAuthUrlResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringGenerateChatOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode), TypeInfoPropertyName = "GenerateChatOauthUrlRequestDtoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode), TypeInfoPropertyName = "GenerateChatOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringGenerateConnectOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode), TypeInfoPropertyName = "GenerateConnectOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLinkUserOauthUrlRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringGenerateLinkUserOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LinkChannelEndpointResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LinkChannelEndpointRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringLinkChannelEndpointRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LinkChannelEndpointRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ConfigureTelegramWebhookResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IssueTelegramMobileLinkResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IssueIntegrationMobileLinkRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerCreateIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerRemoveIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerGetChatOAuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerLinkChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum?), TypeInfoPropertyName = "NullableBuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue?), TypeInfoPropertyName = "NullableStepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CredentialsDtoHmacSecretKeyEncoding?), TypeInfoPropertyName = "NullableCredentialsDtoHmacSecretKeyEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoChannel?), TypeInfoPropertyName = "NullableIntegrationResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoKind?), TypeInfoPropertyName = "NullableIntegrationResponseDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoChannel?), TypeInfoPropertyName = "NullableCreateIntegrationRequestDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoKind?), TypeInfoPropertyName = "NullableCreateIntegrationRequestDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringGenerateChatOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode?), TypeInfoPropertyName = "NullableGenerateChatOauthUrlRequestDtoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode?), TypeInfoPropertyName = "NullableGenerateChatOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringGenerateConnectOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode?), TypeInfoPropertyName = "NullableGenerateConnectOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringGenerateLinkUserOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringLinkChannelEndpointRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>))]
    internal sealed partial class IntegrationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntegrationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IntegrationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IntegrationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.LinkChannelEndpointRequestDtoContext2>());
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
                    typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum)

                    || typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum?)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator?)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn?)

                    || typeToConvert == typeof(global::Novu.StepFilterDtoValue)

                    || typeToConvert == typeof(global::Novu.StepFilterDtoValue?)

                    || typeToConvert == typeof(global::Novu.CredentialsDtoHmacSecretKeyEncoding)

                    || typeToConvert == typeof(global::Novu.CredentialsDtoHmacSecretKeyEncoding?)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel?)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind?)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel?)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind?)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode?)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode?)

                    || typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode)

                    || typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum))
                {
                    return new global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum?))
                {
                    return new global::Novu.JsonConverters.BuilderFieldTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator))
                {
                    return new global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator?))
                {
                    return new global::Novu.JsonConverters.FieldFilterPartDtoOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn))
                {
                    return new global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn?))
                {
                    return new global::Novu.JsonConverters.FieldFilterPartDtoOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepFilterDtoValue))
                {
                    return new global::Novu.JsonConverters.StepFilterDtoValueJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepFilterDtoValue?))
                {
                    return new global::Novu.JsonConverters.StepFilterDtoValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CredentialsDtoHmacSecretKeyEncoding))
                {
                    return new global::Novu.JsonConverters.CredentialsDtoHmacSecretKeyEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CredentialsDtoHmacSecretKeyEncoding?))
                {
                    return new global::Novu.JsonConverters.CredentialsDtoHmacSecretKeyEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel?))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind?))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel?))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind?))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode?))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode?))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode))
                {
                    return new global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode?))
                {
                    return new global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeNullableJsonConverter();
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
                    0 => new IntegrationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}