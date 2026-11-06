
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.DataWrapperDto? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ErrorDto? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConstraintValidation? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ValidationErrorDto? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ConstraintValidation>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ApiKeyDto? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentResponseDto? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentResponseDtoType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ApiKeyDto>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentRequestDto? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InBoundParseDomainDto? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BridgeConfigurationDto? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentRequestDto? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PayloadValidationErrorDto? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PayloadValidationExceptionDto? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PayloadValidationErrorDto>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerEventResponseDto? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerEventResponseDtoStatus? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCredentialsDto? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberChannelDto? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberChannelDtoProviderId? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPayloadDto? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberChannelDto>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TenantPayloadDto? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerRecipientsTypeEnum? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicPayloadDto? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsOverrides? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailChannelOverrides? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelOverrides? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SeverityLevelEnum? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerOverrides? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.StepsOverrides>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerEventRequestDto? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TriggerEventRequestDtoContext2>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerEventRequestDtoContext2? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkTriggerEventDto? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventRequestDto>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerEventToAllRequestDto? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TriggerEventToAllRequestDtoContext2>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerEventToAllRequestDtoContext2? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelTypeEnum? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepTypeEnum? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationSubscriberResponseDto? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceOriginEnum? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTriggerVariable? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTriggerDto? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTriggerDtoType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTriggerVariable>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationTemplateResponseDto? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTriggerDto>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTypeEnum? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestUnitEnum? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OrdinalEnum? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OrdinalValueEnum? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MonthlyTypeEnum? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedConfigDto? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DigestTimedConfigDtoWeekDay>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedConfigDtoWeekDay? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestMetadataDto? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestMetadataDtoUnit? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ExecutionDetailsStatusEnum? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ProvidersIdEnum? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ExecutionDetailsSourceEnum? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationExecutionDetailResponseDto? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BuilderFieldTypeEnum? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FieldFilterPartDto? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FieldFilterPartDtoOperator? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FieldFilterPartDtoOn? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepFilterDto? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepFilterDtoValue? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FieldFilterPartDto>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageTemplateDto? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationStepResponseDto? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityNotificationStepResponseDto>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationJobResponseDto? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationJobResponseDtoType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityNotificationExecutionDetailResponseDto>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityTopicDto? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityNotificationResponseDto? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepTypeEnum>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityNotificationJobResponseDto>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityTopicDto>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivitiesResponseDto? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityNotificationResponseDto>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RequestLogResponseDto? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RequestLogResponseDtoSource? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetRequestsResponseDto? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.RequestLogResponseDto>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TraceResponseDto? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetRequestResponseDto? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TraceResponseDto>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicResponseDto? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowRunStepsDetailsDto? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowRunStepsDetailsDtoStatus? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsDto? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoStatus? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoSeverity? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowRunStepsDetailsDto>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsResponseDto? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetWorkflowRunsDto>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepExecutionDetailDto? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepRunDto? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepRunDtoStatus? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepExecutionDetailDto>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDto? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoStatus? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoSeverity? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepRunDto>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChartsResponseDto? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentBehaviorDto? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentBehaviorDtoSubscriberAccess? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentBehaviorDtoReplyPolicy? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentToolDto? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentToolDtoType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentMcpServerDto? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeResponseDto? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentToolDto>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentMcpServerDto>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationSummaryDto? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDto? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDtoRuntime? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDtoVisibility? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationSummaryDto>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentSkillInputDto? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentSkillInputDtoType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeDto? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeDtoProviderId? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentSkillInputDto>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateAgentRequestDto? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateAgentRequestDtoRuntime? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentPlanUsageDto? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentPlanUsageDtoLimitSource? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListAgentsResponseDto? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentResponseDto>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentBridgeRequestDto? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentRequestDto? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationResponseIntegrationDto? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationResponseDto? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddAgentIntegrationRequestDto? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PlanUsageDto? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListAgentIntegrationsResponseDto? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationResponseDto>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentIntegrationRequestDto? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FileRefDto? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkdownReplyContentDto? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CardReplyContentDto? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolApprovalCardReplyContentDto? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolApprovalRequestPayloadDto? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EditPayloadDto? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResolveDto? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDto? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDtoType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDtoAction? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDto? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoAction? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDto? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoAction? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDto? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDtoType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDto? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoKind? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolResultDto? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddReactionPayloadDto? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessagePayloadDto? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TypingStatusDto? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDto? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDtoTyping? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyContentDto? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SentMessageInfoDto? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ExpectedDnsRecordDto? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDto? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDtoStatus? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainsResponseDto? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainDto? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDto? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoCode? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoStatus? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDto? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoCode? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoSeverity? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiagnoseDomainResponseDto? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDto? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDtoType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainRoutesResponseDto? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDto? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDtoType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDto? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDtoType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteWebhookResultDto? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteAgentResultDto? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDto? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteFromDto? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteDto? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDto? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectApplyUrlResponseDto? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainConnectApplyUrlDto? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainDto? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDto? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDtoHmacSecretKeyEncoding? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDtoAuthMethod? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConfigurationsDto? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDto? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDtoChannel? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDtoKind? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDto? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoChannel? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoKind? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateIntegrationRequestDto? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AutoConfigureIntegrationResponseDto? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOAuthUrlResponseDto? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDto? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoContext2? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDto? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoContext2? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDto? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointResponseDto? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointRequestDto? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointRequestDtoContext2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConfigureTelegramWebhookResponseDto? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IssueTelegramMobileLinkResponseDto? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IssueIntegrationMobileLinkRequestDto? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetContextResponseDto? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateContextRequestDto? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateContextRequestDto? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListContextsResponseDto? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdatedSubscriberDto? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatedSubscriberDto? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedOperationDto? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkCreateSubscriberResponseDto? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriberRequestDto? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkSubscriberCreateDto? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatOrPushProviderEnum? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCredentials? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelSettingsDto? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDto? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateSubscriberChannelRequestDto? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateSubscriberOnlineFlagRequestDto? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlockTypeEnum? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TextAlignEnum? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlockStyles? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlock? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCTATypeEnum? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageCTAData? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageActionStatusEnum? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ButtonTypeEnum? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageButton? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageActionResult? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageAction? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageCTA? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActorTypeEnum? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActorFeedItemDto? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberFeedResponseDto? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationFeedItemDto? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationFeedItemDtoStatus? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FeedResponseDto? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UnseenCountResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationGroup? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceChannels? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadata? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataUnit? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataBackoffUnit? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfig? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigWeekDay? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigOrdinal? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigOrdinalValue? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigMonthlyType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadata? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadataUnit? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadataType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadata? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadataUnit? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadataType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayScheduledMetadata? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayScheduledMetadataType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageTemplate? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyCallback? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationStepData? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationStepDto? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTrigger? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTriggerType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponse? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageStatusEnum? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageResponseDto? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EmailBlock>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDto? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeRangeDto? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DayScheduleDto? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ScheduleDto? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDto? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberDto? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDto? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxActionDto? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxNotificationDto? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserResponseDto? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiComponentEnum? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaProperty? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchema? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlsDto? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDto? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLayoutDto? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDto? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DirectionEnum? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesResponseDto? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicDto? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetaDto? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDto? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowIssueTypeEnum? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RuntimeIssueDto? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ControlsMetadataDto? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContentIssueEnum? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIssueSeverityEnum? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepContentIssueDto? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationIssueEnum? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIntegrationIssue? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIssuesDto? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepResponseDto? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object>>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailFromControlDto? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDto? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlDto? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlDto? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepResponseDto? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDto? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDtoEditorType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDto? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDto? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDto? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDto? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlDto? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpMethodEnum? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActionDto? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlDto? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlDto? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlsMetadataResponseDto? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepResponseDto? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDto? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDtoProviders2? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepUpsertDto? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ToolControlDto, object>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem2? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem3? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepListResponseDto? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailRenderOutput? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppRenderOutput? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsRenderOutput? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushRenderOutput? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatRenderOutput? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeUnitEnum? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularOutput? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedOutput? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRenderOutput? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewErrorDto? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10Type? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncActionEnum? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncResultDto? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishSummaryDto? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserInfoDto? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceInfoDto? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffActionEnum? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDto? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffSummaryDto? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkspaceDto? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AuthDto? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TelegramChatEndpointDto? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDto? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoContext2? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoType? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexPersonEndpointDto? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDto? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexPersonEndpointDtoContext2>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoContext2? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexRoomEndpointDto? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDto? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexRoomEndpointDtoContext2>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoContext2? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoType? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LineUserEndpointDto? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDto? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateLineUserEndpointDtoContext2>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoContext2? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDto? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDtoRegion? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDto? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoContext2? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoType? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDto? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDtoRegion? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDto? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoType? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GrafanaOnCallIntegrationEndpointDto? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDto? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDto? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDtoMethod? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDto? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateToolWebhookEndpointDtoContext2>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoContext2? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoType? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDto? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDto? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBody? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBodyStatus? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookResultDto? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookActorSubscriberDto? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookStatusEnum? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookChannelDataDto? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookResponseDto? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPushFailureReasonEnum? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPushErrorDto? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookErrorDto? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPayloadWithErrorDto? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPayloadDto? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadDto? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceChannelsDto? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookReplyCallbackDto? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PersistedWorkflowStepWebhookDto? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerTypeEnum? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TemplateVariableTypeEnum? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookTriggerVariableDto? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookSubscriberVariableDto? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerContextTypeEnum? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookReservedVariableDto? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerVariableDto>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookTriggerDto? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookSubscriberVariableDto>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookReservedVariableDto>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PersistedWorkflowWebhookDto? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PersistedWorkflowStepWebhookDto>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerDto>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadDto? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadDto? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadDto? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookWorkflowDto? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookTimeRangeDto? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookDayScheduleDto? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PreferenceWebhookTimeRangeDto>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookWeeklyScheduleDto? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookScheduleDto? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookObjectDto? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookPayloadDto? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookDomainDto? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookRouteDto? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAddressDto? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentContentDto? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentContentDtoType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentDto? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookMailDto? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAttachmentDto>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookObjectDto? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookPayloadDto? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapper? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapperType? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapperObject? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapper? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapperType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapperObject? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapper? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapperType? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapperObject? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapper? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapperType? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapperObject? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapper? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapperType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapperObject? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapper? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapperType? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapperObject? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapper? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapperType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapperObject? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapper? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapperType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapperObject? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapper? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapperType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapperObject? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapper? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapperType? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapperObject? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapper? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapperType? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapperObject? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapper? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperType? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperObject? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapper? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapperType? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapperObject? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapper? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapperType? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapperObject? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapper? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapperType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapperObject? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapper? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapperType? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapperObject? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapper? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapperType? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapperObject? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsOrderDirection? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsOrderDirection? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesOrderDirection? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenType? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerCreateAgentResponse? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentBridgeResponse? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerGetAgentResponse? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentResponse? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainResponse? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerVerifyDomainResponse? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerDiagnoseDomainResponse? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesResponse? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainRouteResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainRouteResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainRouteResponse? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerTestDomainRouteResponse? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainAutoConfigureResponse? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerStartDomainAutoConfigureResponse? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerLinkChannelEndpointResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse2? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type1025 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ApiKeyDto>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PayloadValidationErrorDto>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberChannelDto>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventRequestDto>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTriggerVariable>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTriggerDto>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DigestTimedConfigDtoWeekDay>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FieldFilterPartDto>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepFilterDto>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityNotificationStepResponseDto>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityNotificationExecutionDetailResponseDto>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepTypeEnum>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityNotificationJobResponseDto>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityTopicDto>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityNotificationResponseDto>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.RequestLogResponseDto>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TraceResponseDto>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TopicResponseDto>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowRunStepsDetailsDto>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetWorkflowRunsDto>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepExecutionDetailDto>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepRunDto>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AgentToolDto>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AgentMcpServerDto>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AgentIntegrationSummaryDto>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AgentSkillInputDto>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AgentResponseDto>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AgentIntegrationResponseDto>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FileRefDto>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ToolResultDto>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AddReactionPayloadDto>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DeleteMessagePayloadDto>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ExpectedDnsRecordDto>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainResponseDto>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticCheckDto>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticIssueDto>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainRouteResponseDto>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetContextResponseDto>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.UpdatedSubscriberDto>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreatedSubscriberDto>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedOperationDto>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreateSubscriberRequestDto>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageButton>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationFeedItemDto>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepData>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepDto>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTrigger>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EmailBlock>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberResponseDto>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimeRangeDto>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberPreferenceOverrideDto>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberWorkflowPreferenceDto>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageResponseDto>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionDto>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueResponseDto>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableWorkflowInfoDto>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueDto>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.RuntimeIssueDto>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.RuntimeIssueDto>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem2>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem3>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepListResponseDto>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncResultDto>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookTriggerVariableDto>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookSubscriberVariableDto>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookReservedVariableDto>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PersistedWorkflowStepWebhookDto>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookTriggerDto>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PreferenceWebhookTimeRangeDto>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboundEmailWebhookAddressDto>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboundEmailWebhookAttachmentDto>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookResultDto>? ListType126 { get; set; }
    }
}