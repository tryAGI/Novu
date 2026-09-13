
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelTypeEnum), TypeInfoPropertyName = "ChannelTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum), TypeInfoPropertyName = "BuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator), TypeInfoPropertyName = "FieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn), TypeInfoPropertyName = "FieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue), TypeInfoPropertyName = "StepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatOrPushProviderEnum), TypeInfoPropertyName = "ChatOrPushProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelSettingsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailBlockTypeEnum), TypeInfoPropertyName = "EmailBlockTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TextAlignEnum), TypeInfoPropertyName = "TextAlignEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailBlockStyles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCTATypeEnum), TypeInfoPropertyName = "ChannelCTATypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageCTAData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageActionStatusEnum), TypeInfoPropertyName = "MessageActionStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ButtonTypeEnum), TypeInfoPropertyName = "ButtonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageButton))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageActionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.MessageButton>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageCTA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberPreferenceChannels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadataUnit), TypeInfoPropertyName = "DigestRegularMetadataUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadataType), TypeInfoPropertyName = "DigestRegularMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadataBackoffUnit), TypeInfoPropertyName = "DigestRegularMetadataBackoffUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigWeekDay), TypeInfoPropertyName = "TimedConfigWeekDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigOrdinal), TypeInfoPropertyName = "TimedConfigOrdinal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigOrdinalValue), TypeInfoPropertyName = "TimedConfigOrdinalValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigMonthlyType), TypeInfoPropertyName = "TimedConfigMonthlyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedMetadataUnit), TypeInfoPropertyName = "DigestTimedMetadataUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedMetadataType), TypeInfoPropertyName = "DigestTimedMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayRegularMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayRegularMetadataUnit), TypeInfoPropertyName = "DelayRegularMetadataUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayRegularMetadataType), TypeInfoPropertyName = "DelayRegularMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayScheduledMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayScheduledMetadataType), TypeInfoPropertyName = "DelayScheduledMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ReplyCallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationStepData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>), TypeInfoPropertyName = "OneOfDigestRegularMetadataDigestTimedMetadataDelayRegularMetadataDelayScheduledMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationStepDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationStepData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerType), TypeInfoPropertyName = "NotificationTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageStatusEnum), TypeInfoPropertyName = "MessageStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>), TypeInfoPropertyName = "OneOfIListEmailBlockString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EmailBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessageResponseDtoStatus), TypeInfoPropertyName = "DeleteMessageResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel), TypeInfoPropertyName = "MessagesControllerDeleteMessagesByTransactionIdChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesControllerDeleteMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelTypeEnum?), TypeInfoPropertyName = "NullableChannelTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum?), TypeInfoPropertyName = "NullableBuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue?), TypeInfoPropertyName = "NullableStepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatOrPushProviderEnum?), TypeInfoPropertyName = "NullableChatOrPushProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailBlockTypeEnum?), TypeInfoPropertyName = "NullableEmailBlockTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TextAlignEnum?), TypeInfoPropertyName = "NullableTextAlignEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCTATypeEnum?), TypeInfoPropertyName = "NullableChannelCTATypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageActionStatusEnum?), TypeInfoPropertyName = "NullableMessageActionStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ButtonTypeEnum?), TypeInfoPropertyName = "NullableButtonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadataUnit?), TypeInfoPropertyName = "NullableDigestRegularMetadataUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadataType?), TypeInfoPropertyName = "NullableDigestRegularMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularMetadataBackoffUnit?), TypeInfoPropertyName = "NullableDigestRegularMetadataBackoffUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigWeekDay?), TypeInfoPropertyName = "NullableTimedConfigWeekDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigOrdinal?), TypeInfoPropertyName = "NullableTimedConfigOrdinal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigOrdinalValue?), TypeInfoPropertyName = "NullableTimedConfigOrdinalValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimedConfigMonthlyType?), TypeInfoPropertyName = "NullableTimedConfigMonthlyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedMetadataUnit?), TypeInfoPropertyName = "NullableDigestTimedMetadataUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedMetadataType?), TypeInfoPropertyName = "NullableDigestTimedMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayRegularMetadataUnit?), TypeInfoPropertyName = "NullableDelayRegularMetadataUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayRegularMetadataType?), TypeInfoPropertyName = "NullableDelayRegularMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayScheduledMetadataType?), TypeInfoPropertyName = "NullableDelayScheduledMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>?), TypeInfoPropertyName = "NullableOneOfDigestRegularMetadataDigestTimedMetadataDelayRegularMetadataDelayScheduledMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationTriggerType?), TypeInfoPropertyName = "NullableNotificationTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageStatusEnum?), TypeInfoPropertyName = "NullableMessageStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>?), TypeInfoPropertyName = "NullableOneOfIListEmailBlockString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessageResponseDtoStatus?), TypeInfoPropertyName = "NullableDeleteMessageResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel?), TypeInfoPropertyName = "NullableMessagesControllerDeleteMessagesByTransactionIdChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTriggerVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.MessageButton>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationStepData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationStepDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EmailBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.MessageResponseDto>))]
    internal sealed partial class MessagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MessagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MessagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>());
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
                    typeToConvert == typeof(global::Novu.ChannelTypeEnum)

                    || typeToConvert == typeof(global::Novu.ChannelTypeEnum?)

                    || typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum)

                    || typeToConvert == typeof(global::Novu.BuilderFieldTypeEnum?)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOperator?)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn)

                    || typeToConvert == typeof(global::Novu.FieldFilterPartDtoOn?)

                    || typeToConvert == typeof(global::Novu.StepFilterDtoValue)

                    || typeToConvert == typeof(global::Novu.StepFilterDtoValue?)

                    || typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum)

                    || typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum?)

                    || typeToConvert == typeof(global::Novu.EmailBlockTypeEnum)

                    || typeToConvert == typeof(global::Novu.EmailBlockTypeEnum?)

                    || typeToConvert == typeof(global::Novu.TextAlignEnum)

                    || typeToConvert == typeof(global::Novu.TextAlignEnum?)

                    || typeToConvert == typeof(global::Novu.ChannelCTATypeEnum)

                    || typeToConvert == typeof(global::Novu.ChannelCTATypeEnum?)

                    || typeToConvert == typeof(global::Novu.MessageActionStatusEnum)

                    || typeToConvert == typeof(global::Novu.MessageActionStatusEnum?)

                    || typeToConvert == typeof(global::Novu.ButtonTypeEnum)

                    || typeToConvert == typeof(global::Novu.ButtonTypeEnum?)

                    || typeToConvert == typeof(global::Novu.DigestRegularMetadataUnit)

                    || typeToConvert == typeof(global::Novu.DigestRegularMetadataUnit?)

                    || typeToConvert == typeof(global::Novu.DigestRegularMetadataType)

                    || typeToConvert == typeof(global::Novu.DigestRegularMetadataType?)

                    || typeToConvert == typeof(global::Novu.DigestRegularMetadataBackoffUnit)

                    || typeToConvert == typeof(global::Novu.DigestRegularMetadataBackoffUnit?)

                    || typeToConvert == typeof(global::Novu.TimedConfigWeekDay)

                    || typeToConvert == typeof(global::Novu.TimedConfigWeekDay?)

                    || typeToConvert == typeof(global::Novu.TimedConfigOrdinal)

                    || typeToConvert == typeof(global::Novu.TimedConfigOrdinal?)

                    || typeToConvert == typeof(global::Novu.TimedConfigOrdinalValue)

                    || typeToConvert == typeof(global::Novu.TimedConfigOrdinalValue?)

                    || typeToConvert == typeof(global::Novu.TimedConfigMonthlyType)

                    || typeToConvert == typeof(global::Novu.TimedConfigMonthlyType?)

                    || typeToConvert == typeof(global::Novu.DigestTimedMetadataUnit)

                    || typeToConvert == typeof(global::Novu.DigestTimedMetadataUnit?)

                    || typeToConvert == typeof(global::Novu.DigestTimedMetadataType)

                    || typeToConvert == typeof(global::Novu.DigestTimedMetadataType?)

                    || typeToConvert == typeof(global::Novu.DelayRegularMetadataUnit)

                    || typeToConvert == typeof(global::Novu.DelayRegularMetadataUnit?)

                    || typeToConvert == typeof(global::Novu.DelayRegularMetadataType)

                    || typeToConvert == typeof(global::Novu.DelayRegularMetadataType?)

                    || typeToConvert == typeof(global::Novu.DelayScheduledMetadataType)

                    || typeToConvert == typeof(global::Novu.DelayScheduledMetadataType?)

                    || typeToConvert == typeof(global::Novu.NotificationTriggerType)

                    || typeToConvert == typeof(global::Novu.NotificationTriggerType?)

                    || typeToConvert == typeof(global::Novu.MessageStatusEnum)

                    || typeToConvert == typeof(global::Novu.MessageStatusEnum?)

                    || typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus)

                    || typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus?)

                    || typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel)

                    || typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.ChannelTypeEnum))
                {
                    return new global::Novu.JsonConverters.ChannelTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum))
                {
                    return new global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChatOrPushProviderEnum?))
                {
                    return new global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailBlockTypeEnum))
                {
                    return new global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailBlockTypeEnum?))
                {
                    return new global::Novu.JsonConverters.EmailBlockTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TextAlignEnum))
                {
                    return new global::Novu.JsonConverters.TextAlignEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TextAlignEnum?))
                {
                    return new global::Novu.JsonConverters.TextAlignEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelCTATypeEnum))
                {
                    return new global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelCTATypeEnum?))
                {
                    return new global::Novu.JsonConverters.ChannelCTATypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessageActionStatusEnum))
                {
                    return new global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessageActionStatusEnum?))
                {
                    return new global::Novu.JsonConverters.MessageActionStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ButtonTypeEnum))
                {
                    return new global::Novu.JsonConverters.ButtonTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ButtonTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ButtonTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestRegularMetadataUnit))
                {
                    return new global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestRegularMetadataUnit?))
                {
                    return new global::Novu.JsonConverters.DigestRegularMetadataUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestRegularMetadataType))
                {
                    return new global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestRegularMetadataType?))
                {
                    return new global::Novu.JsonConverters.DigestRegularMetadataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestRegularMetadataBackoffUnit))
                {
                    return new global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestRegularMetadataBackoffUnit?))
                {
                    return new global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigWeekDay))
                {
                    return new global::Novu.JsonConverters.TimedConfigWeekDayJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigWeekDay?))
                {
                    return new global::Novu.JsonConverters.TimedConfigWeekDayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigOrdinal))
                {
                    return new global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigOrdinal?))
                {
                    return new global::Novu.JsonConverters.TimedConfigOrdinalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigOrdinalValue))
                {
                    return new global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigOrdinalValue?))
                {
                    return new global::Novu.JsonConverters.TimedConfigOrdinalValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigMonthlyType))
                {
                    return new global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimedConfigMonthlyType?))
                {
                    return new global::Novu.JsonConverters.TimedConfigMonthlyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTimedMetadataUnit))
                {
                    return new global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTimedMetadataUnit?))
                {
                    return new global::Novu.JsonConverters.DigestTimedMetadataUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTimedMetadataType))
                {
                    return new global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestTimedMetadataType?))
                {
                    return new global::Novu.JsonConverters.DigestTimedMetadataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayRegularMetadataUnit))
                {
                    return new global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayRegularMetadataUnit?))
                {
                    return new global::Novu.JsonConverters.DelayRegularMetadataUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayRegularMetadataType))
                {
                    return new global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayRegularMetadataType?))
                {
                    return new global::Novu.JsonConverters.DelayRegularMetadataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayScheduledMetadataType))
                {
                    return new global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayScheduledMetadataType?))
                {
                    return new global::Novu.JsonConverters.DelayScheduledMetadataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.NotificationTriggerType))
                {
                    return new global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.NotificationTriggerType?))
                {
                    return new global::Novu.JsonConverters.NotificationTriggerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessageStatusEnum))
                {
                    return new global::Novu.JsonConverters.MessageStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessageStatusEnum?))
                {
                    return new global::Novu.JsonConverters.MessageStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus))
                {
                    return new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus?))
                {
                    return new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel))
                {
                    return new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel?))
                {
                    return new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter();
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
                    0 => new MessagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}