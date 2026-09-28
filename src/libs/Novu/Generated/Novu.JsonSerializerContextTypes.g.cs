
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
        public global::Novu.MetadataDeleteSignalDto? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoAction? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDto? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoAction? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDto? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDtoType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDto? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoKind? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolResultDto? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddReactionPayloadDto? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessagePayloadDto? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TypingStatusDto? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDto? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDtoTyping? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyContentDto? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SentMessageInfoDto? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ExpectedDnsRecordDto? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDto? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDtoStatus? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainsResponseDto? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainDto? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDto? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoCode? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoStatus? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDto? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoCode? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoSeverity? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiagnoseDomainResponseDto? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDto? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDtoType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainRoutesResponseDto? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDto? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDtoType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDto? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDtoType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteWebhookResultDto? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteAgentResultDto? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDto? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteFromDto? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteDto? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDto? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectApplyUrlResponseDto? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainConnectApplyUrlDto? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainDto? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDto? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDtoHmacSecretKeyEncoding? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConfigurationsDto? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDto? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDtoChannel? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDtoKind? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDto? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoChannel? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoKind? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateIntegrationRequestDto? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AutoConfigureIntegrationResponseDto? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOAuthUrlResponseDto? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDto? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoContext2? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDto? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoContext2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDto? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointResponseDto? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointRequestDto? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointRequestDtoContext2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConfigureTelegramWebhookResponseDto? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IssueTelegramMobileLinkResponseDto? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IssueIntegrationMobileLinkRequestDto? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetContextResponseDto? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateContextRequestDto? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateContextRequestDto? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListContextsResponseDto? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdatedSubscriberDto? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatedSubscriberDto? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedOperationDto? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkCreateSubscriberResponseDto? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriberRequestDto? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkSubscriberCreateDto? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatOrPushProviderEnum? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCredentials? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelSettingsDto? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDto? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateSubscriberChannelRequestDto? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateSubscriberOnlineFlagRequestDto? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlockTypeEnum? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TextAlignEnum? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlockStyles? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlock? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCTATypeEnum? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageCTAData? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageActionStatusEnum? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ButtonTypeEnum? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageButton? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageActionResult? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageAction? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageCTA? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActorTypeEnum? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActorFeedItemDto? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberFeedResponseDto? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationFeedItemDto? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationFeedItemDtoStatus? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FeedResponseDto? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UnseenCountResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationGroup? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceChannels? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadata? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataUnit? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataBackoffUnit? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfig? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigWeekDay? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigOrdinal? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigOrdinalValue? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigMonthlyType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadata? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadataUnit? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadataType? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadata? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadataUnit? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadataType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayScheduledMetadata? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayScheduledMetadataType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageTemplate? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyCallback? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationStepData? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationStepDto? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTrigger? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTriggerType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageStatusEnum? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageResponseDto? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EmailBlock>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDto? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeRangeDto? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DayScheduleDto? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ScheduleDto? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDto? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberDto? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDto? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxActionDto? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxNotificationDto? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserResponseDto? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiComponentEnum? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaProperty? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchema? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlsDto? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDto? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLayoutDto? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDto? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DirectionEnum? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesResponseDto? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicDto? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetaDto? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDto? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowIssueTypeEnum? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RuntimeIssueDto? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ControlsMetadataDto? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContentIssueEnum? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIssueSeverityEnum? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepContentIssueDto? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationIssueEnum? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIntegrationIssue? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIssuesDto? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepResponseDto? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailFromControlDto? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDto? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlDto? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlDto? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepResponseDto? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDto? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDtoEditorType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDto? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDto? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDto? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDto? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlDto? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpMethodEnum? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActionDto? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlDto? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlDto? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlsMetadataResponseDto? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepResponseDto? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDto? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDtoProviders2? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepUpsertDto? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ToolControlDto, object>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem2? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem3? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepListResponseDto? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailRenderOutput? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppRenderOutput? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsRenderOutput? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushRenderOutput? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatRenderOutput? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeUnitEnum? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularOutput? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedOutput? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRenderOutput? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewErrorDto? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10Type? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncActionEnum? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncResultDto? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishSummaryDto? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserInfoDto? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceInfoDto? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffActionEnum? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDto? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffSummaryDto? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkspaceDto? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AuthDto? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TelegramChatEndpointDto? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDto? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoContext2? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexPersonEndpointDto? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDto? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexPersonEndpointDtoContext2>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoContext2? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoType? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexRoomEndpointDto? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDto? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexRoomEndpointDtoContext2>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoContext2? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoType? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LineUserEndpointDto? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDto? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateLineUserEndpointDtoContext2>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoContext2? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoType? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDto? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDtoRegion? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDto? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoContext2? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDto? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDtoRegion? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDto? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GrafanaOnCallIntegrationEndpointDto? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDto? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDto? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDtoMethod? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDto? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateToolWebhookEndpointDtoContext2>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoContext2? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoType? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDto? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDto? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBody? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBodyStatus? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookResultDto? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookActorSubscriberDto? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookStatusEnum? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookChannelDataDto? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookResponseDto? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPushFailureReasonEnum? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPushErrorDto? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookErrorDto? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPayloadWithErrorDto? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPayloadDto? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadDto? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceChannelsDto? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookReplyCallbackDto? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PersistedWorkflowStepWebhookDto? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerTypeEnum? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TemplateVariableTypeEnum? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookTriggerVariableDto? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookSubscriberVariableDto? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerContextTypeEnum? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookReservedVariableDto? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerVariableDto>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookTriggerDto? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookSubscriberVariableDto>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookReservedVariableDto>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PersistedWorkflowWebhookDto? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PersistedWorkflowStepWebhookDto>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerDto>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadDto? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadDto? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadDto? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookWorkflowDto? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookTimeRangeDto? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookDayScheduleDto? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PreferenceWebhookTimeRangeDto>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookWeeklyScheduleDto? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookScheduleDto? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookObjectDto? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookPayloadDto? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookDomainDto? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookRouteDto? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAddressDto? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentContentDto? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentContentDtoType? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentDto? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookMailDto? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAttachmentDto>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookObjectDto? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookPayloadDto? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapper? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapperType? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapperObject? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapper? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapperType? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapperObject? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapper? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapperType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapperObject? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapper? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapperType? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapperObject? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapper? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapperType? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapperObject? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapper? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapperType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapperObject? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapper? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapperType? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapperObject? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapper? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapperType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapperObject? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapper? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapperType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapperObject? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapper? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapperType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapperObject? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapper? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapperType? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapperObject? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapper? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperType? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperObject? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapper? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapperType? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapperObject? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapper? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapperType? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapperObject? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapper? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapperType? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapperObject? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapper? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapperType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapperObject? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapper? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapperType? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapperObject? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsOrderDirection? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsOrderDirection? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesOrderDirection? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerCreateAgentResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsResponse? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentBridgeResponse? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerGetAgentResponse? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentResponse? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainResponse? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainResponse? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerVerifyDomainResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerDiagnoseDomainResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesResponse? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainRouteResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainRouteResponse? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainRouteResponse? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerTestDomainRouteResponse? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainAutoConfigureResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerStartDomainAutoConfigureResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerLinkChannelEndpointResponse? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse2? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type1021 { get; set; }

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
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ToolResultDto>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AddReactionPayloadDto>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DeleteMessagePayloadDto>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ExpectedDnsRecordDto>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainResponseDto>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticCheckDto>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticIssueDto>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainRouteResponseDto>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetContextResponseDto>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.UpdatedSubscriberDto>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreatedSubscriberDto>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedOperationDto>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreateSubscriberRequestDto>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageButton>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationFeedItemDto>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepData>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepDto>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTrigger>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EmailBlock>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberResponseDto>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimeRangeDto>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberPreferenceOverrideDto>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberWorkflowPreferenceDto>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageResponseDto>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionDto>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueResponseDto>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableWorkflowInfoDto>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueDto>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.RuntimeIssueDto>>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.RuntimeIssueDto>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem2>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem3>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepListResponseDto>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncResultDto>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookTriggerVariableDto>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookSubscriberVariableDto>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookReservedVariableDto>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PersistedWorkflowStepWebhookDto>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookTriggerDto>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PreferenceWebhookTimeRangeDto>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboundEmailWebhookAddressDto>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboundEmailWebhookAttachmentDto>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookResultDto>? ListType125 { get; set; }
    }
}