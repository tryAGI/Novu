
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
        public global::Novu.ExpectedDnsRecordDto? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainResponseDto? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainResponseDtoStatus? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListDomainsResponseDto? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateDomainDto? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDto? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoCode? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoStatus? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDto? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoCode? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoSeverity? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiagnoseDomainResponseDto? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteResponseDto? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteResponseDtoType? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListDomainRoutesResponseDto? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteDto? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteDtoType? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateDomainRouteDto? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateDomainRouteDtoType? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteWebhookResultDto? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteAgentResultDto? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteResponseDto? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoType? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteFromDto? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteDto? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDto? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainConnectApplyUrlResponseDto? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateDomainConnectApplyUrlDto? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateDomainDto? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CredentialsDto? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ConfigurationsDto? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDto? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDtoChannel? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDtoKind? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDto? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoChannel? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoKind? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateIntegrationRequestDto? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AutoConfigureIntegrationResponseDto? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOAuthUrlResponseDto? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDto? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoContext2? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDto? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoContext2? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDto? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetContextResponseDto? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateContextRequestDto? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateContextRequestDto? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListContextsResponseDto? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdatedSubscriberDto? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatedSubscriberDto? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FailedOperationDto? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkCreateSubscriberResponseDto? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSubscriberRequestDto? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkSubscriberCreateDto? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatOrPushProviderEnum? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelCredentials? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelSettingsDto? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberResponseDto? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateSubscriberChannelRequestDto? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateSubscriberOnlineFlagRequestDto? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlockTypeEnum? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TextAlignEnum? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlockStyles? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlock? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelCTATypeEnum? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageCTAData? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageActionStatusEnum? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ButtonTypeEnum? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageButton? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageActionResult? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageAction? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageCTA? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActorTypeEnum? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActorFeedItemDto? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberFeedResponseDto? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationFeedItemDto? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationFeedItemDtoStatus? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FeedResponseDto? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UnseenCountResponse? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationGroup? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferenceChannels? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadata? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataUnit? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataType? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataBackoffUnit? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfig? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigWeekDay? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigOrdinal? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigOrdinalValue? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigMonthlyType? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadata? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadataUnit? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadataType? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadata? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadataUnit? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadataType? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayScheduledMetadata? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayScheduledMetadataType? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageTemplate? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ReplyCallback? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationStepData? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationStepDto? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationTrigger? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationTriggerType? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponse? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageStatusEnum? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageResponseDto? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EmailBlock>? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageMarkAsRequestDto? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimeRangeDto? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DayScheduleDto? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ScheduleDto? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowDto? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberDto? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RedirectDto? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxActionDto? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxNotificationDto? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UserResponseDto? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiComponentEnum? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchemaProperty? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchema? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsDto? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutControlsDto? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutResponseDto? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateLayoutDto? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DirectionEnum? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesResponseDto? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicDto? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MetaDto? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionDto? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RuntimeIssueDto? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ControlsMetadataDto? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContentIssueEnum? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepContentIssueDto? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationIssueEnum? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepIntegrationIssue? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepIssuesDto? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepResponseDto? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlDto? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsControlDto? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushControlDto? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepResponseDto? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatControlDto? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDto? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDtoType? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LookBackWindowDto? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDto? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDtoType? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDto? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomControlDto? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpMethodEnum? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActionDto? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppControlDto? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem2? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem3? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepListResponseDto? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailRenderOutput? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppRenderOutput? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsRenderOutput? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushRenderOutput? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatRenderOutput? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimeUnitEnum? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularOutput? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedOutput? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRenderOutput? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewErrorDto? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncActionEnum? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncResultDto? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishSummaryDto? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UserInfoDto? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceInfoDto? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffActionEnum? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffDto? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffSummaryDto? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkspaceDto? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AuthDto? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TelegramChatEndpointDto? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDto? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoContext2? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDtoType? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationResponseDto? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationGroupDto? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventBody? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventBodyStatus? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookResultDto? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDto? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageFailedPushDto? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageFailedErrorDto? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDto? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDto? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDto? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDto? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDto? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDomainDto? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailRouteDto? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailAddressDto? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailMailDto? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookInboundEmailAddressDto>? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDto? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapper? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperType? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapper? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapper? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapper? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapper? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapper? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapper? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainsOrderDirection? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesOrderDirection? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainsResponse? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainResponse? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerGetDomainResponse? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainResponse? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerVerifyDomainResponse? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerDiagnoseDomainResponse? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesResponse? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainRouteResponse? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerGetDomainRouteResponse? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainRouteResponse? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerTestDomainRouteResponse? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerGetDomainAutoConfigureResponse? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerStartDomainAutoConfigureResponse? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse2? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type808 { get; set; }

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
        public global::System.Collections.Generic.List<global::Novu.ExpectedDnsRecordDto>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainResponseDto>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticCheckDto>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainDiagnosticIssueDto>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.DomainRouteResponseDto>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetContextResponseDto>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.UpdatedSubscriberDto>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreatedSubscriberDto>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedOperationDto>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreateSubscriberRequestDto>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageButton>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationFeedItemDto>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepData>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepDto>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTrigger>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EmailBlock>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberResponseDto>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimeRangeDto>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberPreferenceOverrideDto>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberWorkflowPreferenceDto>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageResponseDto>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionDto>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueResponseDto>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableWorkflowInfoDto>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueDto>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem2>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem3>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepListResponseDto>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncResultDto>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookInboundEmailAddressDto>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookResultDto>? ListType103 { get; set; }
    }
}