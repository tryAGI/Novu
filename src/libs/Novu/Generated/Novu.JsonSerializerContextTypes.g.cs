
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
        public global::Novu.GetRequestsResponseDto? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.RequestLogResponseDto>? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TraceResponseDto? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetRequestResponseDto? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TraceResponseDto>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicResponseDto? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowRunStepsDetailsDto? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowRunStepsDetailsDtoStatus? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunsDto? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoStatus? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunsDtoSeverity? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowRunStepsDetailsDto>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunsResponseDto? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetWorkflowRunsDto>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepExecutionDetailDto? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepRunDto? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepRunDtoStatus? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepExecutionDetailDto>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDto? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoStatus? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetWorkflowRunResponseDtoSeverity? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepRunDto>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChartsResponseDto? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ExpectedDnsRecordDto? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainResponseDto? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainResponseDtoStatus? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListDomainsResponseDto? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateDomainDto? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDto? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoCode? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticCheckDtoStatus? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDto? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoCode? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainDiagnosticIssueDtoSeverity? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiagnoseDomainResponseDto? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteResponseDto? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteResponseDtoType? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListDomainRoutesResponseDto? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteDto? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainRouteDtoType? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateDomainRouteDto? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateDomainRouteDtoType? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteWebhookResultDto? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteAgentResultDto? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteResponseDto? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteResponseDtoType? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteFromDto? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TestDomainRouteDto? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDto? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainConnectStatusResponseDtoReasonCode? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainConnectApplyUrlResponseDto? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateDomainConnectApplyUrlDto? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateDomainDto? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CredentialsDto? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ConfigurationsDto? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDto? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDtoChannel? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDto? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoChannel? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateIntegrationRequestDto? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AutoConfigureIntegrationResponseDto? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOAuthUrlResponseDto? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDto? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoContext2? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDto? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoContext2? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDto? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetContextResponseDto? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateContextRequestDto? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateContextRequestDto? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListContextsResponseDto? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdatedSubscriberDto? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatedSubscriberDto? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FailedOperationDto? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkCreateSubscriberResponseDto? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSubscriberRequestDto? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkSubscriberCreateDto? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatOrPushProviderEnum? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelCredentials? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelSettingsDto? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberResponseDto? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateSubscriberChannelRequestDto? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateSubscriberOnlineFlagRequestDto? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlockTypeEnum? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TextAlignEnum? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlockStyles? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlock? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelCTATypeEnum? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageCTAData? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageActionStatusEnum? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ButtonTypeEnum? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageButton? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageActionResult? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageAction? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageCTA? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActorTypeEnum? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActorFeedItemDto? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberFeedResponseDto? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationFeedItemDto? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationFeedItemDtoStatus? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FeedResponseDto? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UnseenCountResponse? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationGroup? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferenceChannels? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadata? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataUnit? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataType? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataBackoffUnit? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfig? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigWeekDay? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigOrdinal? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigOrdinalValue? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigMonthlyType? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadata? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadataUnit? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadataType? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadata? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadataUnit? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadataType? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayScheduledMetadata? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayScheduledMetadataType? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageTemplate? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ReplyCallback? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationStepData? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationStepDto? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationTrigger? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationTriggerType? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponse? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageStatusEnum? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageResponseDto? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EmailBlock>? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageMarkAsRequestDto? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimeRangeDto? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DayScheduleDto? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ScheduleDto? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowDto? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberDto? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RedirectDto? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxActionDto? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxNotificationDto? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UserResponseDto? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiComponentEnum? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchemaProperty? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchema? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsDto? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutControlsDto? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutResponseDto? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateLayoutDto? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DirectionEnum? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesResponseDto? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicDto? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MetaDto? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionDto? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RuntimeIssueDto? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ControlsMetadataDto? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContentIssueEnum? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepContentIssueDto? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationIssueEnum? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepIntegrationIssue? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepIssuesDto? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepResponseDto? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlDto? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsControlDto? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushControlDto? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepResponseDto? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatControlDto? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDto? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDtoType? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LookBackWindowDto? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDto? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDtoType? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDto? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomControlDto? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpMethodEnum? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActionDto? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppControlDto? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem2? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem3? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepListResponseDto? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailRenderOutput? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppRenderOutput? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsRenderOutput? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushRenderOutput? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatRenderOutput? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimeUnitEnum? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularOutput? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedOutput? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRenderOutput? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewErrorDto? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncActionEnum? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncResultDto? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishSummaryDto? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UserInfoDto? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceInfoDto? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffActionEnum? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffDto? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffSummaryDto? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkspaceDto? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AuthDto? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationResponseDto? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationGroupDto? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventBody? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventBodyStatus? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookResultDto? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDto? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageFailedPushDto? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageFailedErrorDto? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDto? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDto? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDto? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDto? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDto? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDomainDto? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailRouteDto? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailAddressDto? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailMailDto? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookInboundEmailAddressDto>? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDto? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapper? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperType? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapper? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapper? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapper? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapper? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapper? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapper? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainsOrderDirection? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesOrderDirection? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainsResponse? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainResponse? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerGetDomainResponse? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainResponse? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerVerifyDomainResponse? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerDiagnoseDomainResponse? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerListDomainRoutesResponse? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerCreateDomainRouteResponse? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerGetDomainRouteResponse? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerUpdateDomainRouteResponse? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerTestDomainRouteResponse? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerGetDomainAutoConfigureResponse? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DomainsControllerStartDomainAutoConfigureResponse? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse2? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type800 { get; set; }

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