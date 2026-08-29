
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
        public global::Novu.AgentToolDto? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentToolDtoType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentMcpServerDto? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeResponseDto? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentToolDto>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentMcpServerDto>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationSummaryDto? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDto? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDtoRuntime? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDtoVisibility? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationSummaryDto>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentSkillInputDto? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentSkillInputDtoType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeDto? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeDtoProviderId? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentSkillInputDto>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateAgentRequestDto? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateAgentRequestDtoRuntime? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentPlanUsageDto? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentPlanUsageDtoLimitSource? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListAgentsResponseDto? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentResponseDto>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentBridgeRequestDto? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentRequestDto? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationResponseIntegrationDto? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationResponseDto? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddAgentIntegrationRequestDto? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PlanUsageDto? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListAgentIntegrationsResponseDto? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationResponseDto>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentIntegrationRequestDto? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FileRefDto? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkdownReplyContentDto? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CardReplyContentDto? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolApprovalCardReplyContentDto? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolApprovalRequestPayloadDto? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EditPayloadDto? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResolveDto? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDto? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDtoType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDtoAction? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDto? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoAction? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDto? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoAction? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDto? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDtoType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDto? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoKind? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SignalDto? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SignalDtoType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SignalDtoAction? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SignalDtoKind? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolResultDto? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddReactionPayloadDto? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessagePayloadDto? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TypingStatusDto? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDto? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDtoTyping? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyContentDto? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SentMessageInfoDto? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ExpectedDnsRecordDto? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDto? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDtoStatus? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainsResponseDto? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainDto? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDto? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoCode? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoStatus? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDto? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoCode? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoSeverity? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiagnoseDomainResponseDto? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDto? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDtoType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainRoutesResponseDto? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDto? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDtoType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDto? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDtoType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteWebhookResultDto? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteAgentResultDto? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDto? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteFromDto? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteDto? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDto? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectApplyUrlResponseDto? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainConnectApplyUrlDto? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainDto? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDto? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDtoHmacSecretKeyEncoding? Type245 { get; set; }
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
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeRangeDto? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DayScheduleDto? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ScheduleDto? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDto? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberDto? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDto? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxActionDto? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxNotificationDto? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserResponseDto? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiComponentEnum? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaProperty? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchema? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDto? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlsDto? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDto? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLayoutDto? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DirectionEnum? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesResponseDto? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicDto? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetaDto? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDto? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type488 { get; set; }
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
        public global::Novu.EmailFromControlDto? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDto? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlDto? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlDto? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepResponseDto? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDto? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDtoEditorType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDto? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDto? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDto? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDto? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlDto? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpMethodEnum? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActionDto? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlDto? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlDto? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlsMetadataResponseDto? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepResponseDto? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDto? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDtoProviders2? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepUpsertDto? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ToolControlDto, object>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem2? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem3? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepListResponseDto? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailRenderOutput? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppRenderOutput? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsRenderOutput? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushRenderOutput? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatRenderOutput? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeUnitEnum? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularOutput? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedOutput? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRenderOutput? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewErrorDto? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10Type? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncActionEnum? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncResultDto? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishSummaryDto? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserInfoDto? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceInfoDto? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffActionEnum? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDto? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffSummaryDto? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkspaceDto? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AuthDto? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TelegramChatEndpointDto? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDto? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoContext2? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexPersonEndpointDto? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDto? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexPersonEndpointDtoContext2>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoContext2? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexRoomEndpointDto? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDto? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexRoomEndpointDtoContext2>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoContext2? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoType? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LineUserEndpointDto? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDto? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateLineUserEndpointDtoContext2>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoContext2? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDto? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDtoRegion? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDto? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoContext2? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDto? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDtoRegion? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDto? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GrafanaOnCallIntegrationEndpointDto? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDto? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDto? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDtoMethod? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDto? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateToolWebhookEndpointDtoContext2>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoContext2? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoType? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDto? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDto? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBody? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBodyStatus? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookResultDto? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageDto? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedPushDto? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedErrorDto? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageFailedDto? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDto? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDto? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDto? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookPreferenceDto? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailDomainDto? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailRouteDto? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailAddressDto? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailMailDto? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookInboundEmailAddressDto>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailDto? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapper? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperType? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapper? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapper? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapper? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapper? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapper? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapper? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsOrderDirection? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsOrderDirection? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesOrderDirection? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerCreateAgentResponse? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsResponse? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentBridgeResponse? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerGetAgentResponse? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentResponse? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainResponse? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerVerifyDomainResponse? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerDiagnoseDomainResponse? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesResponse? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainRouteResponse? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainRouteResponse? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainRouteResponse? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerTestDomainRouteResponse? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainAutoConfigureResponse? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerStartDomainAutoConfigureResponse? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerLinkChannelEndpointResponse? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse2? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type958 { get; set; }

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
        public global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ToolResultDto>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.AddReactionPayloadDto>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DeleteMessagePayloadDto>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ExpectedDnsRecordDto>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainResponseDto>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticCheckDto>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticIssueDto>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainRouteResponseDto>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetContextResponseDto>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.UpdatedSubscriberDto>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreatedSubscriberDto>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedOperationDto>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreateSubscriberRequestDto>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageButton>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationFeedItemDto>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepData>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepDto>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTrigger>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EmailBlock>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>? ListType61 { get; set; }
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
        public global::System.Collections.Generic.List<global::Novu.StepsItem2>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem3>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepListResponseDto>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncResultDto>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookInboundEmailAddressDto>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookResultDto>? ListType116 { get; set; }
    }
}