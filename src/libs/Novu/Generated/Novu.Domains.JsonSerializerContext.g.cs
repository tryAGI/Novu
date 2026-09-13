
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ExpectedDnsRecordDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainResponseDtoStatus), TypeInfoPropertyName = "DomainResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListDomainsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoCode), TypeInfoPropertyName = "DomainDiagnosticCheckDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoStatus), TypeInfoPropertyName = "DomainDiagnosticCheckDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoCode), TypeInfoPropertyName = "DomainDiagnosticIssueDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoSeverity), TypeInfoPropertyName = "DomainDiagnosticIssueDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiagnoseDomainResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteResponseDtoType), TypeInfoPropertyName = "DomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListDomainRoutesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteDtoType), TypeInfoPropertyName = "DomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainRouteDtoType), TypeInfoPropertyName = "UpdateDomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteWebhookResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteAgentResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus), TypeInfoPropertyName = "TestDomainRouteResponseDtoDomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoType), TypeInfoPropertyName = "TestDomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteFromDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectStatusResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode), TypeInfoPropertyName = "DomainConnectStatusResponseDtoReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectApplyUrlResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateDomainConnectApplyUrlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainsOrderDirection), TypeInfoPropertyName = "DomainsControllerListDomainsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection), TypeInfoPropertyName = "DomainsControllerListDomainRoutesOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerCreateDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerGetDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerUpdateDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerVerifyDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerDiagnoseDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerCreateDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerGetDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerUpdateDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerTestDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerGetDomainAutoConfigureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerStartDomainAutoConfigureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainResponseDtoStatus?), TypeInfoPropertyName = "NullableDomainResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoCode?), TypeInfoPropertyName = "NullableDomainDiagnosticCheckDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoStatus?), TypeInfoPropertyName = "NullableDomainDiagnosticCheckDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoCode?), TypeInfoPropertyName = "NullableDomainDiagnosticIssueDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoSeverity?), TypeInfoPropertyName = "NullableDomainDiagnosticIssueDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteResponseDtoType?), TypeInfoPropertyName = "NullableDomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteDtoType?), TypeInfoPropertyName = "NullableDomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainRouteDtoType?), TypeInfoPropertyName = "NullableUpdateDomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus?), TypeInfoPropertyName = "NullableTestDomainRouteResponseDtoDomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoType?), TypeInfoPropertyName = "NullableTestDomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode?), TypeInfoPropertyName = "NullableDomainConnectStatusResponseDtoReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainsOrderDirection?), TypeInfoPropertyName = "NullableDomainsControllerListDomainsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection?), TypeInfoPropertyName = "NullableDomainsControllerListDomainRoutesOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ExpectedDnsRecordDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainDiagnosticCheckDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainDiagnosticIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainRouteResponseDto>))]
    internal sealed partial class DomainsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DomainsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DomainsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DomainsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Novu.DomainResponseDtoStatus)

                    || typeToConvert == typeof(global::Novu.DomainResponseDtoStatus?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity?)

                    || typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType)

                    || typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.DomainRouteDtoType)

                    || typeToConvert == typeof(global::Novu.DomainRouteDtoType?)

                    || typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType)

                    || typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType?)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus?)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode)

                    || typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode?)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.DomainResponseDtoStatus))
                {
                    return new global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainResponseDtoStatus?))
                {
                    return new global::Novu.JsonConverters.DomainResponseDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType))
                {
                    return new global::Novu.JsonConverters.DomainRouteResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.DomainRouteResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteDtoType))
                {
                    return new global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteDtoType?))
                {
                    return new global::Novu.JsonConverters.DomainRouteDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType))
                {
                    return new global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType?))
                {
                    return new global::Novu.JsonConverters.UpdateDomainRouteDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus?))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode))
                {
                    return new global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode?))
                {
                    return new global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection?))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionNullableJsonConverter();
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
                    0 => new DomainsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}