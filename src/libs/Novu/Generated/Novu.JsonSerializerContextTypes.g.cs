
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
        public global::Novu.CredentialsDto? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ConfigurationsDto? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDto? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationResponseDtoChannel? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDto? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateIntegrationRequestDtoChannel? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateIntegrationRequestDto? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AutoConfigureIntegrationResponseDto? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOAuthUrlResponseDto? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDto? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoContext2? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoMode? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetContextResponseDto? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateContextRequestDto? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateContextRequestDto? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListContextsResponseDto? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdatedSubscriberDto? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatedSubscriberDto? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FailedOperationDto? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkCreateSubscriberResponseDto? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSubscriberRequestDto? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkSubscriberCreateDto? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatOrPushProviderEnum? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelCredentials? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelSettingsDto? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberResponseDto? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateSubscriberChannelRequestDto? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateSubscriberOnlineFlagRequestDto? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlockTypeEnum? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TextAlignEnum? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlockStyles? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailBlock? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelCTATypeEnum? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageCTAData? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageActionStatusEnum? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ButtonTypeEnum? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageButton? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageActionResult? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageAction? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageButton>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageCTA? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActorTypeEnum? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActorFeedItemDto? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberFeedResponseDto? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationFeedItemDto? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationFeedItemDtoStatus? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FeedResponseDto? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UnseenCountResponse? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationGroup? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferenceChannels? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadata? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataUnit? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataType? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularMetadataBackoffUnit? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfig? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimedConfigWeekDay>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigWeekDay? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigOrdinal? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigOrdinalValue? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimedConfigMonthlyType? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadata? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadataUnit? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedMetadataType? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadata? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadataUnit? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRegularMetadataType? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayScheduledMetadata? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayScheduledMetadataType? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageTemplate? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ReplyCallback? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationStepData? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationStepDto? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationTrigger? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationTriggerType? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponse? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepDto>? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.NotificationTrigger>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageStatusEnum? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageResponseDto? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EmailBlock>? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageMarkAsRequestDto? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageMarkAsRequestDtoMarkAs? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDto? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkAllMessageAsRequestDtoMarkAs? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDto? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkMessageActionAsSeenDtoStatus? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListSubscribersResponseDto? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberRequestDto? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RemoveSubscriberResponseDto? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimeRangeDto? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DayScheduleDto? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WeeklyScheduleDto? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ScheduleDto? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberGlobalPreferenceDto? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferenceOverrideSourceEnum? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferenceOverrideDto? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberPreferencesWorkflowInfoDto? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberWorkflowPreferenceDto? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberPreferencesDto? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferenceLevelEnum? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowDto? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetPreferencesResponseDto? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchPreferenceChannelsDto? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferenceItemDto? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDto? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.BulkUpdateSubscriberPreferencesDtoContext2? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDto? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchSubscriberPreferencesDtoContext2? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberDto? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriptionResponseDto? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListTopicSubscriptionsResponseDto? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxSubscriberResponseDto? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RedirectDto? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RedirectDtoTarget? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxActionDto? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationWorkflowDto? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InboxNotificationDto? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberNotificationsResponseDto? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetSubscriberNotificationsCountResponseDto? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SnoozeSubscriberNotificationDto? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MarkSubscriberNotificationsAsSeenDto? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateAllSubscriberNotificationsDto? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UserResponseDto? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceTypeEnum? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiComponentEnum? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchemaProperty? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchemaGroupEnum? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UiSchema? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsDto? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsDtoEditorType? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutControlValuesDto? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutControlsDto? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutResponseDto? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutCreationSourceEnum? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateLayoutDto? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateLayoutDto? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DuplicateLayoutDto? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListLayoutResponseDto? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DirectionEnum? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutResponseDtoSortField? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailLayoutRenderOutput? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriberResponseDtoOptional? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutPreviewPayloadDto? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDto? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResult? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GenerateLayoutPreviewResponseDtoResultType? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutPreviewRequestDto? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowInfoDto? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetLayoutUsageResponseDto? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesResponseDto? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteMessageResponseDto? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteMessageResponseDtoStatus? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriberDto? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListTopicsResponseDto? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateUpdateTopicRequestDto? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateTopicRequestDto? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicResponseDto? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicDto? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionPreferenceDto? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionResponseDto? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MetaDto? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionErrorDto? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSubscriptionsResponseDto? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferenceRequestDto? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GroupPreferenceFilterDetailsDto? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GroupPreferenceFilterDto? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicSubscriberIdentifierDto? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDto? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTopicSubscriptionsRequestDtoContext2? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionDto? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionsDeleteErrorDto? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsResponseDto? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriberIdentifierDto? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DeleteTopicSubscriptionsRequestDto? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscriptionDetailsResponseDto? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateTopicSubscriptionRequestDto? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableValueResponseDto? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDto? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableResponseDtoType? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableWorkflowInfoDto? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetEnvironmentVariableUsageResponseDto? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariableValueDto? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDto? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateEnvironmentVariableRequestDtoType? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDto? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateEnvironmentVariableRequestDtoType? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.RuntimeIssueDto? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ControlsMetadataDto? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContentIssueEnum? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepContentIssueDto? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationIssueEnum? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepIntegrationIssue? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepIssuesDto? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepResponseDto? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlDto? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlDtoEditorType? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailControlsMetadataResponseDto? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepResponseDto? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsControlDto? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsControlsMetadataResponseDto? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepResponseDto? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushControlDto? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushControlsMetadataResponseDto? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepResponseDto? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatControlDto? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatControlsMetadataResponseDto? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepResponseDto? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDto? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDtoType? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlDtoUnit? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayControlsMetadataResponseDto? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepResponseDto? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LookBackWindowDto? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LookBackWindowDtoUnit? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDto? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDtoType? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlDtoUnit? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestControlsMetadataResponseDto? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepResponseDto? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDto? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDtoType? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlDtoUnit? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleControlsMetadataResponseDto? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepResponseDto? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomControlDto? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomControlsMetadataResponseDto? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepResponseDto? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpMethodEnum? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestKeyValuePairDto? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestControlDto? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestControlsMetadataResponseDto? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ActionDto? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppControlDto? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppControlsMetadataResponseDto? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepResponseDto? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferenceDto? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelPreferenceDto? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferencesDto? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowPreferencesResponseDto? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowStatusEnum? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDto? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem>? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminator? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepUpsertDto? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.InAppControlDto, object>? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepUpsertDto? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.EmailControlDto, object>? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepUpsertDto? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.SmsControlDto, object>? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepUpsertDto? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.PushControlDto, object>? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepUpsertDto? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.ChatControlDto, object>? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepUpsertDto? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DelayControlDto, object>? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepUpsertDto? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.DigestControlDto, object>? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.ThrottleControlDto, object>? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepUpsertDto? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.CustomControlDto, object>? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowCreationSourceEnum? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreferencesRequestDto? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDto? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem2>? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem2? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminator? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWorkflowDtoStepDiscriminatorType? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncWorkflowDto? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDto? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepsItem3>? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepsItem3? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminator? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.StepListResponseDto? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowListResponseDto? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListWorkflowResponse? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowResponseDtoSortField? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DuplicateWorkflowDto? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailRenderOutput? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppRenderOutput? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsRenderOutput? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushRenderOutput? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatRenderOutput? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TimeUnitEnum? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestRegularOutput? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestTimedOutput? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayRenderOutput? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewErrorDto? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewPayloadDto? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PreviewPayloadDtoContext2? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDto? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant2Type? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant3Type? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant4Type? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant5Type? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant6Type? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant7Type? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant8Type? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewResponseDtoResultVariant9Type? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GeneratePreviewRequestDto? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PatchWorkflowDto? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetEnvironmentTagsDto? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncActionEnum? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncedWorkflowDto? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.FailedWorkflowDto? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SkippedWorkflowDto? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SyncResultDto? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishSummaryDto? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishEnvironmentResponseDto? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SyncResultDto>? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceToPublishDto? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PublishEnvironmentRequestDto? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UserInfoDto? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceInfoDto? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffActionEnum? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffDto? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffDtoDiffs? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffSummaryDto? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DependencyReasonEnum? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDependencyDto? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ResourceDiffResultDto? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentDiffSummaryDto? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffEnvironmentResponseDto? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DiffEnvironmentRequestDto? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkspaceDto? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AuthDto? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDto? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoChannel? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelConnectionResponseDtoProviderId? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListChannelConnectionsResponseDto? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDto? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoContext2? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateChannelConnectionRequestDtoConnectionMode? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateChannelConnectionRequestDto? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SlackChannelEndpointDto? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoContext2? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDtoType? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SlackUserEndpointDto? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoContext2? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDtoType? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookEndpointDto? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoContext2? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDtoType? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PhoneEndpointDto? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoContext2? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDtoType? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MsTeamsChannelEndpointDto? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoContext2? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDtoType? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MsTeamsUserEndpointDto? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoContext2? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDtoType? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDto? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoChannel? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoProviderId? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetChannelEndpointResponseDtoType? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ListChannelEndpointsResponseDto? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateChannelEndpointRequestDto? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UploadTranslationsResponseDto? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTranslationRequestDto? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTranslationRequestDtoResourceType? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationResponseDto? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationResponseDtoResourceType? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.GetMasterJsonResponseDto? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ImportMasterJsonRequestDto? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ImportMasterJsonResponseDto? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationGroupDto? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationGroupDtoResourceType? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventBody? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventBodyStatus? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookResultDto? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDto? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageFailedPushDto? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessageFailedErrorDto? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDto? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDto? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDto? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDto? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDto? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapper? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperType? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapper? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapper? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapper? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapper? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapper? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequest? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerUploadMasterJsonEndpointRequest? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerListContextsOrderDirection? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersOrderDirection? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerCompleteNotificationActionActionType? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerRevertNotificationActionActionType? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicsOrderDirection? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerGetSingleTranslationResourceType? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationEndpointResourceType? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerTriggerResponse? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerTriggerBulkResponse? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EventsControllerBroadcastEventToAllResponse? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.NotificationsControllerGetNotificationResponse? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerCreateIntegrationResponse? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerRemoveIntegrationResponse? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.IntegrationsControllerGetChatOAuthUrlResponse? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerCreateContextResponse? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerListContextsResponse? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerUpdateContextResponse? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ContextsControllerGetContextResponse? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerGetUnseenCountResponse? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkMessagesAsResponse? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerSearchSubscribersResponse? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerCreateSubscriberResponse? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberResponse? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerPatchSubscriberResponse? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerRemoveSubscriberResponse? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberPreferencesResponse? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerListSubscriberTopicsResponse? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsResponse? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerCreateResponse? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerListResponse? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerUpdateResponse? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGetResponse? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerDuplicateResponse? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGeneratePreviewResponse? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.LayoutsControllerGetUsageResponse? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.MessagesControllerDeleteMessageResponse? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicsResponse? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpsertTopicResponse2? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerGetTopicResponse? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicResponse? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerDeleteTopicResponse? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerListTopicSubscriptionsResponse? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerCreateTopicSubscriptionsResponse? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerGetTopicSubscriptionResponse? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.TopicsControllerUpdateTopicSubscriptionResponse? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerCreateResponse? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerSearchWorkflowsResponse? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerSyncResponse? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerUpdateResponse? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowResponse? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerPatchWorkflowResponse? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGeneratePreviewResponse? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.WorkflowControllerGetWorkflowStepDataResponse? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerPublishEnvironmentResponse? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EnvironmentsControllerDiffEnvironmentResponse? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>? Type730 { get; set; }

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
        public global::System.Collections.Generic.List<global::Novu.GetContextResponseDto>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.UpdatedSubscriberDto>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreatedSubscriberDto>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedOperationDto>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.CreateSubscriberRequestDto>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageButton>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationFeedItemDto>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepData>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationStepDto>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.NotificationTrigger>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EmailBlock>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberResponseDto>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TimeRangeDto>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberPreferenceOverrideDto>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriberWorkflowPreferenceDto>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.BulkUpdateSubscriberPreferenceItemDto>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.MessageResponseDto>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionDto>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueResponseDto>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableWorkflowInfoDto>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueDto>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem2>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepsItem3>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.StepListResponseDto>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SyncResultDto>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.WebhookResultDto>? ListType97 { get; set; }
    }
}