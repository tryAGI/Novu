
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelTypeEnum), TypeInfoPropertyName = "ChannelTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepTypeEnum), TypeInfoPropertyName = "StepTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationSubscriberResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceOriginEnum), TypeInfoPropertyName = "ResourceOriginEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerDtoType), TypeInfoPropertyName = "NotificationTriggerDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationTemplateResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationTriggerDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTypeEnum), TypeInfoPropertyName = "DigestTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestUnitEnum), TypeInfoPropertyName = "DigestUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OrdinalEnum), TypeInfoPropertyName = "OrdinalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OrdinalValueEnum), TypeInfoPropertyName = "OrdinalValueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MonthlyTypeEnum), TypeInfoPropertyName = "MonthlyTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DigestTimedConfigDtoWeekDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedConfigDtoWeekDay), TypeInfoPropertyName = "DigestTimedConfigDtoWeekDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestMetadataDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestMetadataDtoUnit), TypeInfoPropertyName = "DigestMetadataDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ExecutionDetailsStatusEnum), TypeInfoPropertyName = "ExecutionDetailsStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ProvidersIdEnum), TypeInfoPropertyName = "ProvidersIdEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ExecutionDetailsSourceEnum), TypeInfoPropertyName = "ExecutionDetailsSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationExecutionDetailResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum), TypeInfoPropertyName = "BuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator), TypeInfoPropertyName = "FieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn), TypeInfoPropertyName = "FieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue), TypeInfoPropertyName = "StepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageTemplateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ActivityNotificationStepResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationJobResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationJobResponseDtoType), TypeInfoPropertyName = "ActivityNotificationJobResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ActivityNotificationExecutionDetailResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityTopicDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepTypeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ActivityNotificationJobResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ActivityTopicDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivitiesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ActivityNotificationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationsControllerGetNotificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SeverityLevelEnum?), TypeInfoPropertyName = "NullableSeverityLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelTypeEnum?), TypeInfoPropertyName = "NullableChannelTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepTypeEnum?), TypeInfoPropertyName = "NullableStepTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceOriginEnum?), TypeInfoPropertyName = "NullableResourceOriginEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerDtoType?), TypeInfoPropertyName = "NullableNotificationTriggerDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTypeEnum?), TypeInfoPropertyName = "NullableDigestTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestUnitEnum?), TypeInfoPropertyName = "NullableDigestUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OrdinalEnum?), TypeInfoPropertyName = "NullableOrdinalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OrdinalValueEnum?), TypeInfoPropertyName = "NullableOrdinalValueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MonthlyTypeEnum?), TypeInfoPropertyName = "NullableMonthlyTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedConfigDtoWeekDay?), TypeInfoPropertyName = "NullableDigestTimedConfigDtoWeekDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestMetadataDtoUnit?), TypeInfoPropertyName = "NullableDigestMetadataDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ExecutionDetailsStatusEnum?), TypeInfoPropertyName = "NullableExecutionDetailsStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ProvidersIdEnum?), TypeInfoPropertyName = "NullableProvidersIdEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ExecutionDetailsSourceEnum?), TypeInfoPropertyName = "NullableExecutionDetailsSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum?), TypeInfoPropertyName = "NullableBuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue?), TypeInfoPropertyName = "NullableStepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationJobResponseDtoType?), TypeInfoPropertyName = "NullableActivityNotificationJobResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTriggerVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTriggerDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DigestTimedConfigDtoWeekDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationStepResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationExecutionDetailResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepTypeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationJobResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityTopicDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>))]
    internal sealed partial class NotificationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NotificationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static NotificationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private NotificationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Novu.SeverityLevelEnum)

                    || typeToConvert == typeof(global::Novu.SeverityLevelEnum?)

                    || typeToConvert == typeof(global::Novu.ChannelTypeEnum)

                    || typeToConvert == typeof(global::Novu.ChannelTypeEnum?)

                    || typeToConvert == typeof(global::Novu.StepTypeEnum)

                    || typeToConvert == typeof(global::Novu.StepTypeEnum?)

                    || typeToConvert == typeof(global::Novu.ResourceOriginEnum)

                    || typeToConvert == typeof(global::Novu.ResourceOriginEnum?)

                    || typeToConvert == typeof(global::Novu.NotificationTriggerDtoType)

                    || typeToConvert == typeof(global::Novu.NotificationTriggerDtoType?)

                    || typeToConvert == typeof(global::Novu.DigestTypeEnum)

                    || typeToConvert == typeof(global::Novu.DigestTypeEnum?)

                    || typeToConvert == typeof(global::Novu.DigestUnitEnum)

                    || typeToConvert == typeof(global::Novu.DigestUnitEnum?)

                    || typeToConvert == typeof(global::Novu.OrdinalEnum)

                    || typeToConvert == typeof(global::Novu.OrdinalEnum?)

                    || typeToConvert == typeof(global::Novu.OrdinalValueEnum)

                    || typeToConvert == typeof(global::Novu.OrdinalValueEnum?)

                    || typeToConvert == typeof(global::Novu.MonthlyTypeEnum)

                    || typeToConvert == typeof(global::Novu.MonthlyTypeEnum?)

                    || typeToConvert == typeof(global::Novu.DigestTimedConfigDtoWeekDay)

                    || typeToConvert == typeof(global::Novu.DigestTimedConfigDtoWeekDay?)

                    || typeToConvert == typeof(global::Novu.DigestMetadataDtoUnit)

                    || typeToConvert == typeof(global::Novu.DigestMetadataDtoUnit?)

                    || typeToConvert == typeof(global::Novu.ExecutionDetailsStatusEnum)

                    || typeToConvert == typeof(global::Novu.ExecutionDetailsStatusEnum?)

                    || typeToConvert == typeof(global::Novu.ProvidersIdEnum)

                    || typeToConvert == typeof(global::Novu.ProvidersIdEnum?)

                    || typeToConvert == typeof(global::Novu.ExecutionDetailsSourceEnum)

                    || typeToConvert == typeof(global::Novu.ExecutionDetailsSourceEnum?)

                    || typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum)

                    || typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum?)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator?)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn?)

                    || typeToConvert == typeof(global::Novu.StepFilterDtoValue)

                    || typeToConvert == typeof(global::Novu.StepFilterDtoValue?)

                    || typeToConvert == typeof(global::Novu.ActivityNotificationJobResponseDtoType)

                    || typeToConvert == typeof(global::Novu.ActivityNotificationJobResponseDtoType?);
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

                if (typeToConvert == typeof(global::Novu.ChannelTypeEnum))
                {
                    return new global::Novu.JsonConverters.ChannelTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepTypeEnum))
                {
                    return new global::Novu.JsonConverters.StepTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepTypeEnum?))
                {
                    return new global::Novu.JsonConverters.StepTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceOriginEnum))
                {
                    return new global::Novu.JsonConverters.ResourceOriginEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceOriginEnum?))
                {
                    return new global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.NotificationTriggerDtoType))
                {
                    return new global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.NotificationTriggerDtoType?))
                {
                    return new global::Novu.JsonConverters.NotificationTriggerDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTypeEnum))
                {
                    return new global::Novu.JsonConverters.DigestTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTypeEnum?))
                {
                    return new global::Novu.JsonConverters.DigestTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestUnitEnum))
                {
                    return new global::Novu.JsonConverters.DigestUnitEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestUnitEnum?))
                {
                    return new global::Novu.JsonConverters.DigestUnitEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.OrdinalEnum))
                {
                    return new global::Novu.JsonConverters.OrdinalEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.OrdinalEnum?))
                {
                    return new global::Novu.JsonConverters.OrdinalEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.OrdinalValueEnum))
                {
                    return new global::Novu.JsonConverters.OrdinalValueEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.OrdinalValueEnum?))
                {
                    return new global::Novu.JsonConverters.OrdinalValueEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MonthlyTypeEnum))
                {
                    return new global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MonthlyTypeEnum?))
                {
                    return new global::Novu.JsonConverters.MonthlyTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTimedConfigDtoWeekDay))
                {
                    return new global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTimedConfigDtoWeekDay?))
                {
                    return new global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestMetadataDtoUnit))
                {
                    return new global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestMetadataDtoUnit?))
                {
                    return new global::Novu.JsonConverters.DigestMetadataDtoUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ExecutionDetailsStatusEnum))
                {
                    return new global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ExecutionDetailsStatusEnum?))
                {
                    return new global::Novu.JsonConverters.ExecutionDetailsStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ProvidersIdEnum))
                {
                    return new global::Novu.JsonConverters.ProvidersIdEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ProvidersIdEnum?))
                {
                    return new global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ExecutionDetailsSourceEnum))
                {
                    return new global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ExecutionDetailsSourceEnum?))
                {
                    return new global::Novu.JsonConverters.ExecutionDetailsSourceEnumNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Novu.ActivityNotificationJobResponseDtoType))
                {
                    return new global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ActivityNotificationJobResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeNullableJsonConverter();
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
                    0 => new NotificationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}