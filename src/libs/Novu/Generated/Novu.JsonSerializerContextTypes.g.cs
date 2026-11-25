
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
        public global::Novu.GetWorkflowRunsDtoDeliveryLifecycleDetail? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoSeverity? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowRunStepsDetailsDto>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunsResponseDto? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetWorkflowRunsDto>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepExecutionDetailDto? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepRunDto? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepRunDtoStatus? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepExecutionDetailDto>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDto? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleDetail? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoSeverity? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepRunDto>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChartsResponseDto? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentBehaviorDto? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentBehaviorDtoSubscriberAccess? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentBehaviorDtoReplyPolicy? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentToolDto? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentToolDtoType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentMcpServerDto? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeResponseDto? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentToolDto>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentMcpServerDto>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationSummaryDto? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDto? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDtoRuntime? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentResponseDtoVisibility? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationSummaryDto>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentSkillInputDto? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentSkillInputDtoType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeDto? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ManagedRuntimeDtoProviderId? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentSkillInputDto>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateAgentRequestDto? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateAgentRequestDtoRuntime? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentPlanUsageDto? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentPlanUsageDtoLimitSource? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListAgentsResponseDto? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentResponseDto>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentBridgeRequestDto? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentRequestDto? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationResponseIntegrationDto? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationResponseDto? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddAgentIntegrationRequestDto? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PlanUsageDto? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListAgentIntegrationsResponseDto? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AgentIntegrationResponseDto>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAgentIntegrationRequestDto? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FileRefDto? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkdownReplyContentDto? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CardReplyContentDto? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolApprovalCardReplyContentDto? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolApprovalRequestPayloadDto? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EditPayloadDto? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResolveDto? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDto? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDtoType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataSetSignalDtoAction? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDto? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataDeleteSignalDtoAction? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDto? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetadataClearSignalDtoAction? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDto? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerSignalDtoType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, object>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDto? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HumanSignalDtoKind? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolResultDto? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AddReactionPayloadDto? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessagePayloadDto? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TypingStatusDto? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDto? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyPayloadDtoTyping? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyContentDto? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SentMessageInfoDto? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ExpectedDnsRecordDto? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDto? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainResponseDtoStatus? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainsResponseDto? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainDto? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDto? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoCode? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoStatus? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDto? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoCode? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoSeverity? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiagnoseDomainResponseDto? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDto? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteResponseDtoType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListDomainRoutesResponseDto? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDto? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainRouteDtoType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDto? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainRouteDtoType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteWebhookResultDto? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteAgentResultDto? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDto? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteFromDto? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TestDomainRouteDto? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDto? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainConnectApplyUrlResponseDto? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateDomainConnectApplyUrlDto? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateDomainDto? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDto? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDtoHmacSecretKeyEncoding? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CredentialsDtoAuthMethod? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConfigurationsDto? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDto? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDtoChannel? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationResponseDtoKind? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDto? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoChannel? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoKind? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateIntegrationRequestDto? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AutoConfigureIntegrationResponseDto? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOAuthUrlResponseDto? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDto? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoContext2? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDto? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoContext2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDto? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointResponseDto? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointRequestDto? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LinkChannelEndpointRequestDtoContext2? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ConfigureTelegramWebhookResponseDto? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IssueTelegramMobileLinkResponseDto? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IssueIntegrationMobileLinkRequestDto? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetContextResponseDto? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateContextRequestDto? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateContextRequestDto? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListContextsResponseDto? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdatedSubscriberDto? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatedSubscriberDto? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedOperationDto? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkCreateSubscriberResponseDto? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriberRequestDto? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkSubscriberCreateDto? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatOrPushProviderEnum? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCredentials? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelSettingsDto? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDto? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateSubscriberChannelRequestDto? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateSubscriberOnlineFlagRequestDto? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlockTypeEnum? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TextAlignEnum? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlockStyles? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailBlock? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelCTATypeEnum? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageCTAData? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageActionStatusEnum? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ButtonTypeEnum? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageButton? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageActionResult? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageAction? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageCTA? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActorTypeEnum? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActorFeedItemDto? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberFeedResponseDto? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationFeedItemDto? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationFeedItemDtoStatus? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FeedResponseDto? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UnseenCountResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationGroup? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceChannels? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadata? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataUnit? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularMetadataBackoffUnit? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfig? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigWeekDay? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigOrdinal? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigOrdinalValue? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimedConfigMonthlyType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadata? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadataUnit? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedMetadataType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadata? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadataUnit? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRegularMetadataType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayScheduledMetadata? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayScheduledMetadataType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageTemplate? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ReplyCallback? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationStepData? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationStepDto? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTrigger? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationTriggerType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageStatusEnum? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageResponseDto? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EmailBlock>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDto? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeRangeDto? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DayScheduleDto? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ScheduleDto? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDto? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberDto? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriberTokenResponseDto? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.BaseSubscriberFieldsDto? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberTokenScopeEnum? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriberTokenRequestDto? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSubscriberTokenRequestDtoContext2>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriberTokenRequestDtoContext2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberTokenScopeEnum>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDto? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxActionDto? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboxNotificationDto? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserResponseDto? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiComponentEnum? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaProperty? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UiSchema? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlsDto? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDto? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLayoutDto? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDto? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DirectionEnum? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesResponseDto? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicDto? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MetaDto? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDto? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowIssueTypeEnum? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.RuntimeIssueDto? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ControlsMetadataDto? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContentIssueEnum? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIssueSeverityEnum? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepContentIssueDto? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationIssueEnum? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIntegrationIssue? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepIssuesDto? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepResponseDto? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object>>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailFromControlDto? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDto? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlDto? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlDto? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepResponseDto? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDto? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlDtoEditorType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDto? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDto? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDto? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoType? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDto? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlDto? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpMethodEnum? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActionDto? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlDto? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlDto? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolControlsMetadataResponseDto? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepResponseDto? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDto? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowAgentConfigDtoProviders2? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem3? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepUpsertDto? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.ToolControlDto, object>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepsItem2? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.StepListResponseDto? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailRenderOutput? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppRenderOutput? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsRenderOutput? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushRenderOutput? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatRenderOutput? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TimeUnitEnum? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestRegularOutput? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestTimedOutput? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayRenderOutput? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewErrorDto? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant10Type? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncActionEnum? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SyncResultDto? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishSummaryDto? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UserInfoDto? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceInfoDto? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffActionEnum? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDto? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffSummaryDto? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkspaceDto? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AuthDto? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TelegramChatEndpointDto? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDto? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoContext2? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoType? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexPersonEndpointDto? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDto? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexPersonEndpointDtoContext2>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoContext2? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDtoType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebexRoomEndpointDto? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDto? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebexRoomEndpointDtoContext2>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoContext2? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDtoType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LineUserEndpointDto? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDto? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateLineUserEndpointDtoContext2>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoContext2? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateLineUserEndpointDtoType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDto? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PagerDutyServiceEndpointDtoRegion? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDto? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoContext2? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDtoType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDto? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OpsgenieIntegrationEndpointDtoRegion? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDto? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDtoType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GrafanaOnCallIntegrationEndpointDto? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDto? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDto? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolWebhookEndpointDtoMethod? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDto? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateToolWebhookEndpointDtoContext2>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoContext2? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateToolWebhookEndpointDtoType? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDto? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDto? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBody? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventBodyStatus? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WebhookResultDto? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookActorSubscriberDto? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookStatusEnum? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookChannelDataDto? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookResponseDto? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPushFailureReasonEnum? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPushErrorDto? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookErrorDto? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPayloadWithErrorDto? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageWebhookPayloadDto? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadDto? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceChannelsDto? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookReplyCallbackDto? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PersistedWorkflowStepWebhookDto? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerTypeEnum? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TemplateVariableTypeEnum? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookTriggerVariableDto? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookSubscriberVariableDto? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TriggerContextTypeEnum? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookReservedVariableDto? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerVariableDto>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowWebhookTriggerDto? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookSubscriberVariableDto>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookReservedVariableDto>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PersistedWorkflowWebhookDto? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PersistedWorkflowStepWebhookDto>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerDto>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadDto? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadDto? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadDto? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookWorkflowDto? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookTimeRangeDto? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookDayScheduleDto? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.PreferenceWebhookTimeRangeDto>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookWeeklyScheduleDto? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookScheduleDto? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookObjectDto? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceWebhookPayloadDto? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookDomainDto? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookRouteDto? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAddressDto? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentContentDto? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentContentDtoType? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookAttachmentDto? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookMailDto? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAttachmentDto>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookObjectDto? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.InboundEmailWebhookPayloadDto? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapper? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapperType? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSentWebhookPayloadWrapperObject? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapper? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapperType? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageFailedWebhookPayloadWrapperObject? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapper? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapperType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeliveredWebhookPayloadWrapperObject? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapper? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapperType? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSeenWebhookPayloadWrapperObject? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapper? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapperType? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageReadWebhookPayloadWrapperObject? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapper? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapperType? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnreadWebhookPayloadWrapperObject? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapper? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapperType? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageArchivedWebhookPayloadWrapperObject? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapper? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapperType? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnarchivedWebhookPayloadWrapperObject? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapper? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapperType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageSnoozedWebhookPayloadWrapperObject? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapper? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapperType? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageUnsnoozedWebhookPayloadWrapperObject? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapper? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapperType? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessageDeletedWebhookPayloadWrapperObject? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapper? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowCreatedWebhookPayloadWrapperObject? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapper? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapperType? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowUpdatedWebhookPayloadWrapperObject? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapper? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapperType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowDeletedWebhookPayloadWrapperObject? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapper? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapperType? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowPublishedWebhookPayloadWrapperObject? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapper? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapperType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.PreferenceUpdatedWebhookPayloadWrapperObject? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapper? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapperType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailReceivedWebhookPayloadWrapperObject? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityControllerGetLogsSource? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityControllerGetWorkflowRunsStatuse>? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityControllerGetWorkflowRunsStatuse? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ActivityControllerGetWorkflowRunsSeverityItem>? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityControllerGetWorkflowRunsSeverityItem? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsOrderDirection? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsOrderDirection? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesOrderDirection? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityControllerGetRequestTracesResponse? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ActivityControllerGetWorkflowRunResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerCreateAgentResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerListAgentsResponse? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentBridgeResponse? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerGetAgentResponse? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentsControllerUpdateAgentResponse? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainsResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainResponse? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainResponse? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainResponse? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerVerifyDomainResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerDiagnoseDomainResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesResponse? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainRouteResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainRouteResponse? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainRouteResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerTestDomainRouteResponse? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerGetDomainAutoConfigureResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.DomainsControllerStartDomainAutoConfigureResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerLinkChannelEndpointResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberTokenResponse? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type1042 { get; set; }

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
        public global::System.Collections.Generic.List<global::Novu.SubscriberTokenScopeEnum>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageResponseDto>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionDto>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueResponseDto>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableWorkflowInfoDto>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueDto>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem3>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.RuntimeIssueDto>>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.RuntimeIssueDto>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem2>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepListResponseDto>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncResultDto>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookTriggerVariableDto>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookSubscriberVariableDto>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookReservedVariableDto>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PersistedWorkflowStepWebhookDto>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowWebhookTriggerDto>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.PreferenceWebhookTimeRangeDto>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboundEmailWebhookAddressDto>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboundEmailWebhookAttachmentDto>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityControllerGetWorkflowRunsStatuse>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ActivityControllerGetWorkflowRunsSeverityItem>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookResultDto>? ListType129 { get; set; }
    }
}