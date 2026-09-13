
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentBehaviorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentBehaviorDtoSubscriberAccess), TypeInfoPropertyName = "AgentBehaviorDtoSubscriberAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentToolDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentToolDtoType), TypeInfoPropertyName = "AgentToolDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentMcpServerDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ManagedRuntimeResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AgentToolDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AgentMcpServerDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentResponseDtoRuntime), TypeInfoPropertyName = "AgentResponseDtoRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentResponseDtoVisibility), TypeInfoPropertyName = "AgentResponseDtoVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AgentIntegrationSummaryDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentSkillInputDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentSkillInputDtoType), TypeInfoPropertyName = "AgentSkillInputDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ManagedRuntimeDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ManagedRuntimeDtoProviderId), TypeInfoPropertyName = "ManagedRuntimeDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AgentSkillInputDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateAgentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateAgentRequestDtoRuntime), TypeInfoPropertyName = "CreateAgentRequestDtoRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentPlanUsageDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentPlanUsageDtoLimitSource), TypeInfoPropertyName = "AgentPlanUsageDtoLimitSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListAgentsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AgentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateAgentBridgeRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateAgentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationResponseIntegrationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AddAgentIntegrationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PlanUsageDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListAgentIntegrationsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AgentIntegrationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateAgentIntegrationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FileRefDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkdownReplyContentDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FileRefDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CardReplyContentDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolApprovalCardReplyContentDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolApprovalRequestPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EditPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>), TypeInfoPropertyName = "OneOfMarkdownReplyContentDtoCardReplyContentDtoToolApprovalCardReplyContentDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResolveDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataSetSignalDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataSetSignalDtoType), TypeInfoPropertyName = "MetadataSetSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataSetSignalDtoAction), TypeInfoPropertyName = "MetadataSetSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataDeleteSignalDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataDeleteSignalDtoType), TypeInfoPropertyName = "MetadataDeleteSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataDeleteSignalDtoAction), TypeInfoPropertyName = "MetadataDeleteSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataClearSignalDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataClearSignalDtoType), TypeInfoPropertyName = "MetadataClearSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataClearSignalDtoAction), TypeInfoPropertyName = "MetadataClearSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerSignalDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerSignalDtoType), TypeInfoPropertyName = "TriggerSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>), TypeInfoPropertyName = "OneOfStringObjectIListOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HumanSignalDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HumanSignalDtoType), TypeInfoPropertyName = "HumanSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HumanSignalDtoKind), TypeInfoPropertyName = "HumanSignalDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AddReactionPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessagePayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TypingStatusDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>), TypeInfoPropertyName = "OneOfMetadataSetSignalDtoMetadataDeleteSignalDtoMetadataClearSignalDtoTriggerSignalDtoHumanSignalDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ToolResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>), TypeInfoPropertyName = "OneOfAgentReplyPayloadDtoTypingTypingStatusDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyPayloadDtoTyping), TypeInfoPropertyName = "AgentReplyPayloadDtoTyping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SentMessageInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerListAgentsOrderDirection), TypeInfoPropertyName = "AgentsControllerListAgentsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection), TypeInfoPropertyName = "AgentIntegrationsControllerListAgentIntegrationsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerCreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerUpdateAgentBridgeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerGetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerUpdateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelTypeEnum?), TypeInfoPropertyName = "NullableChannelTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentBehaviorDtoSubscriberAccess?), TypeInfoPropertyName = "NullableAgentBehaviorDtoSubscriberAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentToolDtoType?), TypeInfoPropertyName = "NullableAgentToolDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentResponseDtoRuntime?), TypeInfoPropertyName = "NullableAgentResponseDtoRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentResponseDtoVisibility?), TypeInfoPropertyName = "NullableAgentResponseDtoVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentSkillInputDtoType?), TypeInfoPropertyName = "NullableAgentSkillInputDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ManagedRuntimeDtoProviderId?), TypeInfoPropertyName = "NullableManagedRuntimeDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateAgentRequestDtoRuntime?), TypeInfoPropertyName = "NullableCreateAgentRequestDtoRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentPlanUsageDtoLimitSource?), TypeInfoPropertyName = "NullableAgentPlanUsageDtoLimitSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>?), TypeInfoPropertyName = "NullableOneOfMarkdownReplyContentDtoCardReplyContentDtoToolApprovalCardReplyContentDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataSetSignalDtoType?), TypeInfoPropertyName = "NullableMetadataSetSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataSetSignalDtoAction?), TypeInfoPropertyName = "NullableMetadataSetSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataDeleteSignalDtoType?), TypeInfoPropertyName = "NullableMetadataDeleteSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataDeleteSignalDtoAction?), TypeInfoPropertyName = "NullableMetadataDeleteSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataClearSignalDtoType?), TypeInfoPropertyName = "NullableMetadataClearSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetadataClearSignalDtoAction?), TypeInfoPropertyName = "NullableMetadataClearSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerSignalDtoType?), TypeInfoPropertyName = "NullableTriggerSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>?), TypeInfoPropertyName = "NullableOneOfStringObjectIListOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, object>?), TypeInfoPropertyName = "NullableOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HumanSignalDtoType?), TypeInfoPropertyName = "NullableHumanSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HumanSignalDtoKind?), TypeInfoPropertyName = "NullableHumanSignalDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>?), TypeInfoPropertyName = "NullableOneOfMetadataSetSignalDtoMetadataDeleteSignalDtoMetadataClearSignalDtoTriggerSignalDtoHumanSignalDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>?), TypeInfoPropertyName = "NullableOneOfAgentReplyPayloadDtoTypingTypingStatusDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyPayloadDtoTyping?), TypeInfoPropertyName = "NullableAgentReplyPayloadDtoTyping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerListAgentsOrderDirection?), TypeInfoPropertyName = "NullableAgentsControllerListAgentsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection?), TypeInfoPropertyName = "NullableAgentIntegrationsControllerListAgentIntegrationsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentToolDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentMcpServerDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentIntegrationSummaryDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentSkillInputDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentIntegrationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FileRefDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, object, global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ToolResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AddReactionPayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DeleteMessagePayloadDto>))]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>());
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

                    || typeToConvert == typeof(global::Novu.AgentBehaviorDtoSubscriberAccess)

                    || typeToConvert == typeof(global::Novu.AgentBehaviorDtoSubscriberAccess?)

                    || typeToConvert == typeof(global::Novu.AgentToolDtoType)

                    || typeToConvert == typeof(global::Novu.AgentToolDtoType?)

                    || typeToConvert == typeof(global::Novu.AgentResponseDtoRuntime)

                    || typeToConvert == typeof(global::Novu.AgentResponseDtoRuntime?)

                    || typeToConvert == typeof(global::Novu.AgentResponseDtoVisibility)

                    || typeToConvert == typeof(global::Novu.AgentResponseDtoVisibility?)

                    || typeToConvert == typeof(global::Novu.AgentSkillInputDtoType)

                    || typeToConvert == typeof(global::Novu.AgentSkillInputDtoType?)

                    || typeToConvert == typeof(global::Novu.ManagedRuntimeDtoProviderId)

                    || typeToConvert == typeof(global::Novu.ManagedRuntimeDtoProviderId?)

                    || typeToConvert == typeof(global::Novu.CreateAgentRequestDtoRuntime)

                    || typeToConvert == typeof(global::Novu.CreateAgentRequestDtoRuntime?)

                    || typeToConvert == typeof(global::Novu.AgentPlanUsageDtoLimitSource)

                    || typeToConvert == typeof(global::Novu.AgentPlanUsageDtoLimitSource?)

                    || typeToConvert == typeof(global::Novu.MetadataSetSignalDtoType)

                    || typeToConvert == typeof(global::Novu.MetadataSetSignalDtoType?)

                    || typeToConvert == typeof(global::Novu.MetadataSetSignalDtoAction)

                    || typeToConvert == typeof(global::Novu.MetadataSetSignalDtoAction?)

                    || typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoType)

                    || typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoType?)

                    || typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoAction)

                    || typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoAction?)

                    || typeToConvert == typeof(global::Novu.MetadataClearSignalDtoType)

                    || typeToConvert == typeof(global::Novu.MetadataClearSignalDtoType?)

                    || typeToConvert == typeof(global::Novu.MetadataClearSignalDtoAction)

                    || typeToConvert == typeof(global::Novu.MetadataClearSignalDtoAction?)

                    || typeToConvert == typeof(global::Novu.TriggerSignalDtoType)

                    || typeToConvert == typeof(global::Novu.TriggerSignalDtoType?)

                    || typeToConvert == typeof(global::Novu.HumanSignalDtoType)

                    || typeToConvert == typeof(global::Novu.HumanSignalDtoType?)

                    || typeToConvert == typeof(global::Novu.HumanSignalDtoKind)

                    || typeToConvert == typeof(global::Novu.HumanSignalDtoKind?)

                    || typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping)

                    || typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping?)

                    || typeToConvert == typeof(global::Novu.AgentsControllerListAgentsOrderDirection)

                    || typeToConvert == typeof(global::Novu.AgentsControllerListAgentsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection)

                    || typeToConvert == typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection?);
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

                if (typeToConvert == typeof(global::Novu.AgentBehaviorDtoSubscriberAccess))
                {
                    return new global::Novu.JsonConverters.AgentBehaviorDtoSubscriberAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentBehaviorDtoSubscriberAccess?))
                {
                    return new global::Novu.JsonConverters.AgentBehaviorDtoSubscriberAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentToolDtoType))
                {
                    return new global::Novu.JsonConverters.AgentToolDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentToolDtoType?))
                {
                    return new global::Novu.JsonConverters.AgentToolDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentResponseDtoRuntime))
                {
                    return new global::Novu.JsonConverters.AgentResponseDtoRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentResponseDtoRuntime?))
                {
                    return new global::Novu.JsonConverters.AgentResponseDtoRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentResponseDtoVisibility))
                {
                    return new global::Novu.JsonConverters.AgentResponseDtoVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentResponseDtoVisibility?))
                {
                    return new global::Novu.JsonConverters.AgentResponseDtoVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentSkillInputDtoType))
                {
                    return new global::Novu.JsonConverters.AgentSkillInputDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentSkillInputDtoType?))
                {
                    return new global::Novu.JsonConverters.AgentSkillInputDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ManagedRuntimeDtoProviderId))
                {
                    return new global::Novu.JsonConverters.ManagedRuntimeDtoProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ManagedRuntimeDtoProviderId?))
                {
                    return new global::Novu.JsonConverters.ManagedRuntimeDtoProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateAgentRequestDtoRuntime))
                {
                    return new global::Novu.JsonConverters.CreateAgentRequestDtoRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateAgentRequestDtoRuntime?))
                {
                    return new global::Novu.JsonConverters.CreateAgentRequestDtoRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentPlanUsageDtoLimitSource))
                {
                    return new global::Novu.JsonConverters.AgentPlanUsageDtoLimitSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentPlanUsageDtoLimitSource?))
                {
                    return new global::Novu.JsonConverters.AgentPlanUsageDtoLimitSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataSetSignalDtoType))
                {
                    return new global::Novu.JsonConverters.MetadataSetSignalDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataSetSignalDtoType?))
                {
                    return new global::Novu.JsonConverters.MetadataSetSignalDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataSetSignalDtoAction))
                {
                    return new global::Novu.JsonConverters.MetadataSetSignalDtoActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataSetSignalDtoAction?))
                {
                    return new global::Novu.JsonConverters.MetadataSetSignalDtoActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoType))
                {
                    return new global::Novu.JsonConverters.MetadataDeleteSignalDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoType?))
                {
                    return new global::Novu.JsonConverters.MetadataDeleteSignalDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoAction))
                {
                    return new global::Novu.JsonConverters.MetadataDeleteSignalDtoActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataDeleteSignalDtoAction?))
                {
                    return new global::Novu.JsonConverters.MetadataDeleteSignalDtoActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataClearSignalDtoType))
                {
                    return new global::Novu.JsonConverters.MetadataClearSignalDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataClearSignalDtoType?))
                {
                    return new global::Novu.JsonConverters.MetadataClearSignalDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataClearSignalDtoAction))
                {
                    return new global::Novu.JsonConverters.MetadataClearSignalDtoActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MetadataClearSignalDtoAction?))
                {
                    return new global::Novu.JsonConverters.MetadataClearSignalDtoActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TriggerSignalDtoType))
                {
                    return new global::Novu.JsonConverters.TriggerSignalDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TriggerSignalDtoType?))
                {
                    return new global::Novu.JsonConverters.TriggerSignalDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.HumanSignalDtoType))
                {
                    return new global::Novu.JsonConverters.HumanSignalDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.HumanSignalDtoType?))
                {
                    return new global::Novu.JsonConverters.HumanSignalDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.HumanSignalDtoKind))
                {
                    return new global::Novu.JsonConverters.HumanSignalDtoKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.HumanSignalDtoKind?))
                {
                    return new global::Novu.JsonConverters.HumanSignalDtoKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping))
                {
                    return new global::Novu.JsonConverters.AgentReplyPayloadDtoTypingJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping?))
                {
                    return new global::Novu.JsonConverters.AgentReplyPayloadDtoTypingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentsControllerListAgentsOrderDirection))
                {
                    return new global::Novu.JsonConverters.AgentsControllerListAgentsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentsControllerListAgentsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.AgentsControllerListAgentsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection))
                {
                    return new global::Novu.JsonConverters.AgentIntegrationsControllerListAgentIntegrationsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.AgentIntegrationsControllerListAgentIntegrationsOrderDirectionNullableJsonConverter();
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
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}