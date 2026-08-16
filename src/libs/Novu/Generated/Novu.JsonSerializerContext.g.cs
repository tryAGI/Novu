
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10_bd4488e3c194c3aa")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_1c828e943cdd55e4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_0ad4135aa31c63dd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>?), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10_688240e711d712de")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_c8c997b666659e86")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_0421199e9dafb346")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>), TypeInfoPropertyName = "ListLayoutResponseDto_System_Collections_Generic_List_global_Novu_LayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DataWrapperDto))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ApiKeyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentResponseDtoType), TypeInfoPropertyName = "EnvironmentResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ApiKeyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InBoundParseDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BridgeConfigurationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PayloadValidationErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PayloadValidationExceptionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.PayloadValidationErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventResponseDtoStatus), TypeInfoPropertyName = "TriggerEventResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCredentialsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberChannelDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberChannelDtoProviderId), TypeInfoPropertyName = "SubscriberChannelDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriberChannelDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TenantPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerRecipientsTypeEnum), TypeInfoPropertyName = "TriggerRecipientsTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailChannelOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SeverityLevelEnum), TypeInfoPropertyName = "SeverityLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.StepsOverrides>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>), TypeInfoPropertyName = "OneOfIListOneOfSubscriberPayloadDtoTopicPayloadDtoStringStringSubscriberPayloadDtoTopicPayloadDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>), TypeInfoPropertyName = "OneOfSubscriberPayloadDtoTopicPayloadDtoString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>), TypeInfoPropertyName = "OneOfStringSubscriberPayloadDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TenantPayloadDto>), TypeInfoPropertyName = "OneOfStringTenantPayloadDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TriggerEventRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringTriggerEventRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BulkTriggerEventDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TriggerEventRequestDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventToAllRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TriggerEventToAllRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringTriggerEventToAllRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventToAllRequestDtoContext2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RequestLogResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RequestLogResponseDtoSource), TypeInfoPropertyName = "RequestLogResponseDtoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetRequestsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.RequestLogResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TraceResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetRequestResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TraceResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowRunStepsDetailsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowRunStepsDetailsDtoStatus), TypeInfoPropertyName = "WorkflowRunStepsDetailsDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDtoStatus), TypeInfoPropertyName = "GetWorkflowRunsDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus), TypeInfoPropertyName = "GetWorkflowRunsDtoDeliveryLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDtoSeverity), TypeInfoPropertyName = "GetWorkflowRunsDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WorkflowRunStepsDetailsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetWorkflowRunsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepExecutionDetailDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepRunDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepRunDtoStatus), TypeInfoPropertyName = "StepRunDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepExecutionDetailDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDtoStatus), TypeInfoPropertyName = "GetWorkflowRunResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus), TypeInfoPropertyName = "GetWorkflowRunResponseDtoDeliveryLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDtoSeverity), TypeInfoPropertyName = "GetWorkflowRunResponseDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepRunDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChartsResponseDto))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SignalDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SignalDtoType), TypeInfoPropertyName = "SignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SignalDtoAction), TypeInfoPropertyName = "SignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AddReactionPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessagePayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TypingStatusDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto>), TypeInfoPropertyName = "OneOfMetadataSetSignalDtoMetadataDeleteSignalDtoMetadataClearSignalDtoTriggerSignalDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ToolResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>), TypeInfoPropertyName = "OneOfAgentReplyPayloadDtoTypingTypingStatusDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyPayloadDtoTyping), TypeInfoPropertyName = "AgentReplyPayloadDtoTyping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ReplyContentDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SentMessageInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ExpectedDnsRecordDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainResponseDtoStatus), TypeInfoPropertyName = "DomainResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ExpectedDnsRecordDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListDomainsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoCode), TypeInfoPropertyName = "DomainDiagnosticCheckDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoStatus), TypeInfoPropertyName = "DomainDiagnosticCheckDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoCode), TypeInfoPropertyName = "DomainDiagnosticIssueDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoSeverity), TypeInfoPropertyName = "DomainDiagnosticIssueDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiagnoseDomainResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteResponseDtoType), TypeInfoPropertyName = "DomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListDomainRoutesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.DomainRouteResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteDtoType), TypeInfoPropertyName = "DomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainRouteDtoType), TypeInfoPropertyName = "UpdateDomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteWebhookResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteAgentResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus), TypeInfoPropertyName = "TestDomainRouteResponseDtoDomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoType), TypeInfoPropertyName = "TestDomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteFromDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectStatusResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode), TypeInfoPropertyName = "DomainConnectStatusResponseDtoReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectApplyUrlResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateDomainConnectApplyUrlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CredentialsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ConfigurationsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoChannel), TypeInfoPropertyName = "IntegrationResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoKind), TypeInfoPropertyName = "IntegrationResponseDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoChannel), TypeInfoPropertyName = "CreateIntegrationRequestDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoKind), TypeInfoPropertyName = "CreateIntegrationRequestDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateIntegrationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AutoConfigureIntegrationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOAuthUrlResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringGenerateChatOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode), TypeInfoPropertyName = "GenerateChatOauthUrlRequestDtoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode), TypeInfoPropertyName = "GenerateChatOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringGenerateConnectOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode), TypeInfoPropertyName = "GenerateConnectOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLinkUserOauthUrlRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringGenerateLinkUserOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LinkChannelEndpointResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LinkChannelEndpointRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringLinkChannelEndpointRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LinkChannelEndpointRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ConfigureTelegramWebhookResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IssueTelegramMobileLinkResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IssueIntegrationMobileLinkRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetContextResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateContextRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateContextRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListContextsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetContextResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdatedSubscriberDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatedSubscriberDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FailedOperationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BulkCreateSubscriberResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.UpdatedSubscriberDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.CreatedSubscriberDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FailedOperationDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSubscriberRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BulkSubscriberCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatOrPushProviderEnum), TypeInfoPropertyName = "ChatOrPushProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelSettingsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ChannelSettingsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateSubscriberChannelRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateSubscriberOnlineFlagRequestDto))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActorTypeEnum), TypeInfoPropertyName = "ActorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActorFeedItemDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberFeedResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationFeedItemDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationFeedItemDtoStatus), TypeInfoPropertyName = "NotificationFeedItemDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FeedResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.NotificationFeedItemDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UnseenCountResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageMarkAsRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageMarkAsRequestDtoMarkAs), TypeInfoPropertyName = "MessageMarkAsRequestDtoMarkAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkAllMessageAsRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkAllMessageAsRequestDtoMarkAs), TypeInfoPropertyName = "MarkAllMessageAsRequestDtoMarkAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkMessageActionAsSeenDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkMessageActionAsSeenDtoStatus), TypeInfoPropertyName = "MarkMessageActionAsSeenDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListSubscribersResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriberResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PatchSubscriberRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RemoveSubscriberResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimeRangeDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DayScheduleDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TimeRangeDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WeeklyScheduleDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ScheduleDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberGlobalPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreferenceOverrideSourceEnum), TypeInfoPropertyName = "PreferenceOverrideSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberPreferenceOverrideDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberPreferencesWorkflowInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberWorkflowPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetSubscriberPreferencesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriberWorkflowPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreferenceLevelEnum), TypeInfoPropertyName = "PreferenceLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetPreferencesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PatchPreferenceChannelsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BulkUpdateSubscriberPreferenceItemDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BulkUpdateSubscriberPreferencesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.BulkUpdateSubscriberPreferenceItemDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>), TypeInfoPropertyName = "OneOfStringBulkUpdateSubscriberPreferencesDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BulkUpdateSubscriberPreferencesDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PatchSubscriberPreferencesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>), TypeInfoPropertyName = "OneOfStringPatchSubscriberPreferencesDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PatchSubscriberPreferencesDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriptionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListTopicSubscriptionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TopicSubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InboxSubscriberResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RedirectDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RedirectDtoTarget), TypeInfoPropertyName = "RedirectDtoTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InboxActionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InboxNotificationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetSubscriberNotificationsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetSubscriberNotificationsCountResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SnoozeSubscriberNotificationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkSubscriberNotificationsAsSeenDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateAllSubscriberNotificationsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UserResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceTypeEnum), TypeInfoPropertyName = "ResourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiComponentEnum), TypeInfoPropertyName = "UiComponentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>), TypeInfoPropertyName = "AnyOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.UiSchemaProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchemaGroupEnum), TypeInfoPropertyName = "UiSchemaGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsDtoEditorType), TypeInfoPropertyName = "EmailControlsDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutControlValuesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutControlsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutCreationSourceEnum), TypeInfoPropertyName = "LayoutCreationSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateLayoutDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateLayoutDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DuplicateLayoutDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.LayoutResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DirectionEnum), TypeInfoPropertyName = "DirectionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutResponseDtoSortField), TypeInfoPropertyName = "LayoutResponseDtoSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailLayoutRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberResponseDtoOptional))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutPreviewPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDtoResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType), TypeInfoPropertyName = "GenerateLayoutPreviewResponseDtoResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutPreviewRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetLayoutUsageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WorkflowInfoDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.MessageResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessageResponseDtoStatus), TypeInfoPropertyName = "DeleteMessageResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriberDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListTopicsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateUpdateTopicRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateTopicRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MetaDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSubscriptionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowPreferenceRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GroupPreferenceFilterDetailsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GroupPreferenceFilterDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriberIdentifierDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTopicSubscriptionsRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>), TypeInfoPropertyName = "OneOfStringTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateTopicSubscriptionsRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTopicSubscriptionsRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>), TypeInfoPropertyName = "OneOfStringWorkflowPreferenceRequestDtoGroupPreferenceFilterDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionsDeleteErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicSubscriptionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionsDeleteErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicSubscriberIdentifierDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteTopicSubscriptionsRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>), TypeInfoPropertyName = "OneOfStringDeleteTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionDetailsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateTopicSubscriptionRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariableValueResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariableResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariableResponseDtoType), TypeInfoPropertyName = "EnvironmentVariableResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariableWorkflowInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetEnvironmentVariableUsageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableWorkflowInfoDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariableValueDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateEnvironmentVariableRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateEnvironmentVariableRequestDtoType), TypeInfoPropertyName = "CreateEnvironmentVariableRequestDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateEnvironmentVariableRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateEnvironmentVariableRequestDtoType), TypeInfoPropertyName = "UpdateEnvironmentVariableRequestDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RuntimeIssueDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ControlsMetadataDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContentIssueEnum), TypeInfoPropertyName = "ContentIssueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepIssueSeverityEnum), TypeInfoPropertyName = "StepIssueSeverityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepContentIssueDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationIssueEnum), TypeInfoPropertyName = "IntegrationIssueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepIntegrationIssue))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10_bd4488e3c194c3aa")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_1c828e943cdd55e4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_0ad4135aa31c63dd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>?), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10_688240e711d712de")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_c8c997b666659e86")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_0421199e9dafb346")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>), TypeInfoPropertyName = "ListLayoutResponseDto_System_Collections_Generic_List_global_Novu_LayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepIssuesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailFromControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlDtoEditorType), TypeInfoPropertyName = "EmailControlDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SmsControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SmsControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SmsStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PushControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PushControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PushStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatControlDtoEditorType), TypeInfoPropertyName = "ChatControlDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayControlDtoType), TypeInfoPropertyName = "DelayControlDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayControlDtoUnit), TypeInfoPropertyName = "DelayControlDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LookBackWindowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LookBackWindowDtoUnit), TypeInfoPropertyName = "LookBackWindowDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestControlDtoType), TypeInfoPropertyName = "DigestControlDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestControlDtoUnit), TypeInfoPropertyName = "DigestControlDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleControlDtoType), TypeInfoPropertyName = "ThrottleControlDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleControlDtoUnit), TypeInfoPropertyName = "ThrottleControlDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CustomControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CustomControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CustomStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpMethodEnum), TypeInfoPropertyName = "HttpMethodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpRequestKeyValuePairDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpRequestControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>), TypeInfoPropertyName = "OneOfStringIListHttpRequestKeyValuePairDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpRequestControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpRequestStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InAppControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InAppControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InAppStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolControlDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolControlsMetadataResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolStepResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowAgentConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.WorkflowAgentConfigDtoProviders2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowAgentConfigDtoProviders2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowPreferencesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.ChannelPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowPreferencesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowStatusEnum), TypeInfoPropertyName = "WorkflowStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsItem), TypeInfoPropertyName = "StepsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponseDtoStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponseDtoStepDiscriminatorType), TypeInfoPropertyName = "WorkflowResponseDtoStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InAppStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.InAppControlDto, object>), TypeInfoPropertyName = "OneOfInAppControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.EmailControlDto, object>), TypeInfoPropertyName = "OneOfEmailControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SmsStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SmsControlDto, object>), TypeInfoPropertyName = "OneOfSmsControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PushStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.PushControlDto, object>), TypeInfoPropertyName = "OneOfPushControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.ChatControlDto, object>), TypeInfoPropertyName = "OneOfChatControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.DelayControlDto, object>), TypeInfoPropertyName = "OneOfDelayControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.DigestControlDto, object>), TypeInfoPropertyName = "OneOfDigestControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.ThrottleControlDto, object>), TypeInfoPropertyName = "OneOfThrottleControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.ToolControlDto, object>), TypeInfoPropertyName = "OneOfToolControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CustomStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.CustomControlDto, object>), TypeInfoPropertyName = "OneOfCustomControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpRequestStepUpsertDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>), TypeInfoPropertyName = "OneOfHttpRequestControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowCreationSourceEnum), TypeInfoPropertyName = "WorkflowCreationSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreferencesRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsItem2), TypeInfoPropertyName = "StepsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWorkflowDtoStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWorkflowDtoStepDiscriminatorType), TypeInfoPropertyName = "CreateWorkflowDtoStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsItem3), TypeInfoPropertyName = "StepsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateWorkflowDtoStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateWorkflowDtoStepDiscriminatorType), TypeInfoPropertyName = "UpdateWorkflowDtoStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepListResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowListResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepListResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponseDtoSortField), TypeInfoPropertyName = "WorkflowResponseDtoSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DuplicateWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.InAppRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SmsRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PushRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimeUnitEnum), TypeInfoPropertyName = "TimeUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestRegularOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestTimedOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayRenderOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreviewErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreviewPayloadDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>), TypeInfoPropertyName = "OneOfStringPreviewPayloadDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreviewPayloadDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10Type), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PatchWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetEnvironmentTagsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncActionEnum), TypeInfoPropertyName = "SyncActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FailedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SkippedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SyncedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.FailedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SkippedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PublishSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PublishEnvironmentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SyncResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceToPublishDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PublishEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UserInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceInfoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffActionEnum), TypeInfoPropertyName = "DiffActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDiffDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDiffDtoDiffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DependencyReasonEnum), TypeInfoPropertyName = "DependencyReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDependencyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceDiffResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentDiffSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffEnvironmentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffEnvironmentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkspaceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AuthDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoChannel), TypeInfoPropertyName = "GetChannelConnectionResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoProviderId), TypeInfoPropertyName = "GetChannelConnectionResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListChannelConnectionsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetChannelConnectionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateChannelConnectionRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode), TypeInfoPropertyName = "CreateChannelConnectionRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateChannelConnectionRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SlackChannelEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackChannelEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateSlackChannelEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackChannelEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackChannelEndpointDtoType), TypeInfoPropertyName = "CreateSlackChannelEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SlackUserEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackUserEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateSlackUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackUserEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackUserEndpointDtoType), TypeInfoPropertyName = "CreateSlackUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebhookEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateWebhookEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebhookEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebhookEndpointDtoType), TypeInfoPropertyName = "CreateWebhookEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PhoneEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePhoneEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreatePhoneEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePhoneEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePhoneEndpointDtoType), TypeInfoPropertyName = "CreatePhoneEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MsTeamsChannelEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsChannelEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateMsTeamsChannelEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsChannelEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType), TypeInfoPropertyName = "CreateMsTeamsChannelEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MsTeamsUserEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsUserEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateMsTeamsUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsUserEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsUserEndpointDtoType), TypeInfoPropertyName = "CreateMsTeamsUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TelegramChatEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTelegramChatEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateTelegramChatEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTelegramChatEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTelegramChatEndpointDtoType), TypeInfoPropertyName = "CreateTelegramChatEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebexPersonEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexPersonEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateWebexPersonEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateWebexPersonEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexPersonEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexPersonEndpointDtoType), TypeInfoPropertyName = "CreateWebexPersonEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebexRoomEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexRoomEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateWebexRoomEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateWebexRoomEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexRoomEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexRoomEndpointDtoType), TypeInfoPropertyName = "CreateWebexRoomEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LineUserEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateLineUserEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateLineUserEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateLineUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateLineUserEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateLineUserEndpointDtoType), TypeInfoPropertyName = "CreateLineUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PagerDutyServiceEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PagerDutyServiceEndpointDtoRegion), TypeInfoPropertyName = "PagerDutyServiceEndpointDtoRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePagerDutyServiceEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreatePagerDutyServiceEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePagerDutyServiceEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePagerDutyServiceEndpointDtoType), TypeInfoPropertyName = "CreatePagerDutyServiceEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OpsgenieIntegrationEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OpsgenieIntegrationEndpointDtoRegion), TypeInfoPropertyName = "OpsgenieIntegrationEndpointDtoRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateOpsgenieIntegrationEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateOpsgenieIntegrationEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoType), TypeInfoPropertyName = "CreateOpsgenieIntegrationEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GrafanaOnCallIntegrationEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateGrafanaOnCallIntegrationEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType), TypeInfoPropertyName = "CreateGrafanaOnCallIntegrationEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolWebhookEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolWebhookEndpointDtoMethod), TypeInfoPropertyName = "ToolWebhookEndpointDtoMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateToolWebhookEndpointDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateToolWebhookEndpointDtoContext2>), TypeInfoPropertyName = "OneOfStringCreateToolWebhookEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateToolWebhookEndpointDtoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateToolWebhookEndpointDtoType), TypeInfoPropertyName = "CreateToolWebhookEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoChannel), TypeInfoPropertyName = "GetChannelEndpointResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoProviderId), TypeInfoPropertyName = "GetChannelEndpointResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoType), TypeInfoPropertyName = "GetChannelEndpointResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListChannelEndpointsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateChannelEndpointRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UploadTranslationsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTranslationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTranslationRequestDtoResourceType), TypeInfoPropertyName = "CreateTranslationRequestDtoResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationResponseDtoResourceType), TypeInfoPropertyName = "TranslationResponseDtoResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetMasterJsonResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ImportMasterJsonRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ImportMasterJsonResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationGroupDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationGroupDtoResourceType), TypeInfoPropertyName = "TranslationGroupDtoResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EventBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EventBodyStatus), TypeInfoPropertyName = "EventBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookResultDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageFailedPushDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageFailedErrorDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageFailedDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookCreatedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookUpdatedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookDeletedWorkflowDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDomainDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailRouteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailAddressDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailMailDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WebhookInboundEmailAddressDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookMessageDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookMessageDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookMessageFailedDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookMessageFailedDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookCreatedWorkflowDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookDeletedWorkflowDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookPreferenceDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookPreferenceDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType), TypeInfoPropertyName = "WebhookInboundEmailDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject), TypeInfoPropertyName = "WebhookInboundEmailDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest), TypeInfoPropertyName = "ChannelEndpointsControllerCreateChannelEndpointRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType), TypeInfoPropertyName = "ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerUploadTranslationFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType), TypeInfoPropertyName = "TranslationControllerUploadTranslationFilesRequestResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerUploadMasterJsonEndpointRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerListAgentsOrderDirection), TypeInfoPropertyName = "AgentsControllerListAgentsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection), TypeInfoPropertyName = "AgentIntegrationsControllerListAgentIntegrationsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainsOrderDirection), TypeInfoPropertyName = "DomainsControllerListDomainsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection), TypeInfoPropertyName = "DomainsControllerListDomainRoutesOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContextsControllerListContextsOrderDirection), TypeInfoPropertyName = "ContextsControllerListContextsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerSearchSubscribersOrderDirection), TypeInfoPropertyName = "SubscribersControllerSearchSubscribersOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality), TypeInfoPropertyName = "SubscribersControllerGetSubscriberPreferencesCriticality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection), TypeInfoPropertyName = "SubscribersControllerListSubscriberTopicsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem), TypeInfoPropertyName = "SubscribersControllerGetSubscriberNotificationsSeverityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerCompleteNotificationActionActionType), TypeInfoPropertyName = "SubscribersControllerCompleteNotificationActionActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerRevertNotificationActionActionType), TypeInfoPropertyName = "SubscribersControllerRevertNotificationActionActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel), TypeInfoPropertyName = "MessagesControllerDeleteMessagesByTransactionIdChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicsOrderDirection), TypeInfoPropertyName = "TopicsControllerListTopicsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection), TypeInfoPropertyName = "TopicsControllerListTopicSubscriptionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection), TypeInfoPropertyName = "ChannelConnectionsControllerListChannelConnectionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode), TypeInfoPropertyName = "ChannelConnectionsControllerListChannelConnectionsConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel), TypeInfoPropertyName = "ChannelConnectionsControllerListChannelConnectionsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection), TypeInfoPropertyName = "ChannelEndpointsControllerListChannelEndpointsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel), TypeInfoPropertyName = "ChannelEndpointsControllerListChannelEndpointsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType), TypeInfoPropertyName = "TranslationControllerGetTranslationGroupEndpointResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerGetSingleTranslationResourceType), TypeInfoPropertyName = "TranslationControllerGetSingleTranslationResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerDeleteTranslationEndpointResourceType), TypeInfoPropertyName = "TranslationControllerDeleteTranslationEndpointResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType), TypeInfoPropertyName = "TranslationControllerDeleteTranslationGroupEndpointResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerV1ListMyEnvironmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EnvironmentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EventsControllerTriggerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EventsControllerTriggerBulkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.TriggerEventResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EventsControllerBroadcastEventToAllResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationsControllerGetNotificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerCreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerUpdateAgentBridgeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerGetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerUpdateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerCreateDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerGetDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerUpdateDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerVerifyDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerDiagnoseDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerCreateDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerGetDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerUpdateDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerTestDomainRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerGetDomainAutoConfigureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerStartDomainAutoConfigureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerCreateIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerRemoveIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerGetChatOAuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerGenerateConnectOAuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerGenerateLinkUserOAuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerLinkChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContextsControllerCreateContextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContextsControllerListContextsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContextsControllerUpdateContextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContextsControllerGetContextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerUpdateSubscriberChannelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerModifySubscriberChannelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerGetUnseenCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerMarkMessagesAsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerSearchSubscribersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerCreateSubscriberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerPatchSubscriberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerRemoveSubscriberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerUpdateSubscriberPreferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerBulkUpdateSubscriberPreferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetPreferencesResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerListSubscriberTopicsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetSubscriberNotificationsCountResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerGeneratePreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutsControllerGetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesControllerDeleteMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpsertTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpsertTopicResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerGetTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpdateTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerDeleteTopicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerCreateTopicSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerGetTopicSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerUpdateTopicSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerSearchWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerSyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerGetWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerPatchWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerGeneratePreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowControllerGetWorkflowStepDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetEnvironmentTagsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerPublishEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentsControllerDiffEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerCreateChannelConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerUpdateChannelConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.WebhookResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentResponseDtoType?), TypeInfoPropertyName = "NullableEnvironmentResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerEventResponseDtoStatus?), TypeInfoPropertyName = "NullableTriggerEventResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriberChannelDtoProviderId?), TypeInfoPropertyName = "NullableSubscriberChannelDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TriggerRecipientsTypeEnum?), TypeInfoPropertyName = "NullableTriggerRecipientsTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SeverityLevelEnum?), TypeInfoPropertyName = "NullableSeverityLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>?), TypeInfoPropertyName = "NullableOneOfIListOneOfSubscriberPayloadDtoTopicPayloadDtoStringStringSubscriberPayloadDtoTopicPayloadDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>?), TypeInfoPropertyName = "NullableOneOfSubscriberPayloadDtoTopicPayloadDtoString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>?), TypeInfoPropertyName = "NullableOneOfStringSubscriberPayloadDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TenantPayloadDto>?), TypeInfoPropertyName = "NullableOneOfStringTenantPayloadDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TriggerEventRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringTriggerEventRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TriggerEventToAllRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringTriggerEventToAllRequestDtoContext22")]
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
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10_bd4488e3c194c3aa")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_1c828e943cdd55e4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_0ad4135aa31c63dd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>?), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant10_688240e711d712de")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_c8c997b666659e86")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_0421199e9dafb346")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>), TypeInfoPropertyName = "ListLayoutResponseDto_System_Collections_Generic_List_global_Novu_LayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.BuilderFieldTypeEnum?), TypeInfoPropertyName = "NullableBuilderFieldTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOperator?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.FieldFilterPartDtoOn?), TypeInfoPropertyName = "NullableFieldFilterPartDtoOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepFilterDtoValue?), TypeInfoPropertyName = "NullableStepFilterDtoValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActivityNotificationJobResponseDtoType?), TypeInfoPropertyName = "NullableActivityNotificationJobResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RequestLogResponseDtoSource?), TypeInfoPropertyName = "NullableRequestLogResponseDtoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowRunStepsDetailsDtoStatus?), TypeInfoPropertyName = "NullableWorkflowRunStepsDetailsDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDtoStatus?), TypeInfoPropertyName = "NullableGetWorkflowRunsDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus?), TypeInfoPropertyName = "NullableGetWorkflowRunsDtoDeliveryLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunsDtoSeverity?), TypeInfoPropertyName = "NullableGetWorkflowRunsDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepRunDtoStatus?), TypeInfoPropertyName = "NullableStepRunDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDtoStatus?), TypeInfoPropertyName = "NullableGetWorkflowRunResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus?), TypeInfoPropertyName = "NullableGetWorkflowRunResponseDtoDeliveryLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetWorkflowRunResponseDtoSeverity?), TypeInfoPropertyName = "NullableGetWorkflowRunResponseDtoSeverity2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SignalDtoType?), TypeInfoPropertyName = "NullableSignalDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SignalDtoAction?), TypeInfoPropertyName = "NullableSignalDtoAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto>?), TypeInfoPropertyName = "NullableOneOfMetadataSetSignalDtoMetadataDeleteSignalDtoMetadataClearSignalDtoTriggerSignalDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>?), TypeInfoPropertyName = "NullableOneOfAgentReplyPayloadDtoTypingTypingStatusDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentReplyPayloadDtoTyping?), TypeInfoPropertyName = "NullableAgentReplyPayloadDtoTyping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainResponseDtoStatus?), TypeInfoPropertyName = "NullableDomainResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoCode?), TypeInfoPropertyName = "NullableDomainDiagnosticCheckDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticCheckDtoStatus?), TypeInfoPropertyName = "NullableDomainDiagnosticCheckDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoCode?), TypeInfoPropertyName = "NullableDomainDiagnosticIssueDtoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainDiagnosticIssueDtoSeverity?), TypeInfoPropertyName = "NullableDomainDiagnosticIssueDtoSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteResponseDtoType?), TypeInfoPropertyName = "NullableDomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainRouteDtoType?), TypeInfoPropertyName = "NullableDomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateDomainRouteDtoType?), TypeInfoPropertyName = "NullableUpdateDomainRouteDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus?), TypeInfoPropertyName = "NullableTestDomainRouteResponseDtoDomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TestDomainRouteResponseDtoType?), TypeInfoPropertyName = "NullableTestDomainRouteResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode?), TypeInfoPropertyName = "NullableDomainConnectStatusResponseDtoReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoChannel?), TypeInfoPropertyName = "NullableIntegrationResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationResponseDtoKind?), TypeInfoPropertyName = "NullableIntegrationResponseDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoChannel?), TypeInfoPropertyName = "NullableCreateIntegrationRequestDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateIntegrationRequestDtoKind?), TypeInfoPropertyName = "NullableCreateIntegrationRequestDtoKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringGenerateChatOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode?), TypeInfoPropertyName = "NullableGenerateChatOauthUrlRequestDtoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode?), TypeInfoPropertyName = "NullableGenerateChatOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringGenerateConnectOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode?), TypeInfoPropertyName = "NullableGenerateConnectOauthUrlRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringGenerateLinkUserOauthUrlRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.LinkChannelEndpointRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringLinkChannelEndpointRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatOrPushProviderEnum?), TypeInfoPropertyName = "NullableChatOrPushProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailBlockTypeEnum?), TypeInfoPropertyName = "NullableEmailBlockTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TextAlignEnum?), TypeInfoPropertyName = "NullableTextAlignEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelCTATypeEnum?), TypeInfoPropertyName = "NullableChannelCTATypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageActionStatusEnum?), TypeInfoPropertyName = "NullableMessageActionStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ButtonTypeEnum?), TypeInfoPropertyName = "NullableButtonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ActorTypeEnum?), TypeInfoPropertyName = "NullableActorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.NotificationFeedItemDtoStatus?), TypeInfoPropertyName = "NullableNotificationFeedItemDtoStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessageMarkAsRequestDtoMarkAs?), TypeInfoPropertyName = "NullableMessageMarkAsRequestDtoMarkAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkAllMessageAsRequestDtoMarkAs?), TypeInfoPropertyName = "NullableMarkAllMessageAsRequestDtoMarkAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MarkMessageActionAsSeenDtoStatus?), TypeInfoPropertyName = "NullableMarkMessageActionAsSeenDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreferenceOverrideSourceEnum?), TypeInfoPropertyName = "NullablePreferenceOverrideSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PreferenceLevelEnum?), TypeInfoPropertyName = "NullablePreferenceLevelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringBulkUpdateSubscriberPreferencesDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.PatchSubscriberPreferencesDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringPatchSubscriberPreferencesDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.RedirectDtoTarget?), TypeInfoPropertyName = "NullableRedirectDtoTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ResourceTypeEnum?), TypeInfoPropertyName = "NullableResourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiComponentEnum?), TypeInfoPropertyName = "NullableUiComponentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UiSchemaGroupEnum?), TypeInfoPropertyName = "NullableUiSchemaGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlsDtoEditorType?), TypeInfoPropertyName = "NullableEmailControlsDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutCreationSourceEnum?), TypeInfoPropertyName = "NullableLayoutCreationSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DirectionEnum?), TypeInfoPropertyName = "NullableDirectionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LayoutResponseDtoSortField?), TypeInfoPropertyName = "NullableLayoutResponseDtoSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType?), TypeInfoPropertyName = "NullableGenerateLayoutPreviewResponseDtoResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DeleteMessageResponseDtoStatus?), TypeInfoPropertyName = "NullableDeleteMessageResponseDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>?), TypeInfoPropertyName = "NullableOneOfStringTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateTopicSubscriptionsRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>?), TypeInfoPropertyName = "NullableOneOfStringWorkflowPreferenceRequestDtoGroupPreferenceFilterDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>?), TypeInfoPropertyName = "NullableOneOfStringDeleteTopicSubscriberIdentifierDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EnvironmentVariableResponseDtoType?), TypeInfoPropertyName = "NullableEnvironmentVariableResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateEnvironmentVariableRequestDtoType?), TypeInfoPropertyName = "NullableCreateEnvironmentVariableRequestDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateEnvironmentVariableRequestDtoType?), TypeInfoPropertyName = "NullableUpdateEnvironmentVariableRequestDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContentIssueEnum?), TypeInfoPropertyName = "NullableContentIssueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepIssueSeverityEnum?), TypeInfoPropertyName = "NullableStepIssueSeverityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationIssueEnum?), TypeInfoPropertyName = "NullableIntegrationIssueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlDtoEditorType?), TypeInfoPropertyName = "NullableEmailControlDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChatControlDtoEditorType?), TypeInfoPropertyName = "NullableChatControlDtoEditorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayControlDtoType?), TypeInfoPropertyName = "NullableDelayControlDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DelayControlDtoUnit?), TypeInfoPropertyName = "NullableDelayControlDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.LookBackWindowDtoUnit?), TypeInfoPropertyName = "NullableLookBackWindowDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestControlDtoType?), TypeInfoPropertyName = "NullableDigestControlDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DigestControlDtoUnit?), TypeInfoPropertyName = "NullableDigestControlDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleControlDtoType?), TypeInfoPropertyName = "NullableThrottleControlDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ThrottleControlDtoUnit?), TypeInfoPropertyName = "NullableThrottleControlDtoUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.HttpMethodEnum?), TypeInfoPropertyName = "NullableHttpMethodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>?), TypeInfoPropertyName = "NullableOneOfStringIListHttpRequestKeyValuePairDto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowStatusEnum?), TypeInfoPropertyName = "NullableWorkflowStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsItem?), TypeInfoPropertyName = "NullableStepsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponseDtoStepDiscriminatorType?), TypeInfoPropertyName = "NullableWorkflowResponseDtoStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.InAppControlDto, object>?), TypeInfoPropertyName = "NullableOneOfInAppControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.EmailControlDto, object>?), TypeInfoPropertyName = "NullableOneOfEmailControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SmsControlDto, object>?), TypeInfoPropertyName = "NullableOneOfSmsControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.PushControlDto, object>?), TypeInfoPropertyName = "NullableOneOfPushControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.ChatControlDto, object>?), TypeInfoPropertyName = "NullableOneOfChatControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.DelayControlDto, object>?), TypeInfoPropertyName = "NullableOneOfDelayControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.DigestControlDto, object>?), TypeInfoPropertyName = "NullableOneOfDigestControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.ThrottleControlDto, object>?), TypeInfoPropertyName = "NullableOneOfThrottleControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.ToolControlDto, object>?), TypeInfoPropertyName = "NullableOneOfToolControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.CustomControlDto, object>?), TypeInfoPropertyName = "NullableOneOfCustomControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.HttpRequestControlDto, object>?), TypeInfoPropertyName = "NullableOneOfHttpRequestControlDtoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowCreationSourceEnum?), TypeInfoPropertyName = "NullableWorkflowCreationSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsItem2?), TypeInfoPropertyName = "NullableStepsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWorkflowDtoStepDiscriminatorType?), TypeInfoPropertyName = "NullableCreateWorkflowDtoStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepsItem3?), TypeInfoPropertyName = "NullableStepsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateWorkflowDtoStepDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateWorkflowDtoStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WorkflowResponseDtoSortField?), TypeInfoPropertyName = "NullableWorkflowResponseDtoSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TimeUnitEnum?), TypeInfoPropertyName = "NullableTimeUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.PreviewPayloadDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringPreviewPayloadDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10Type?), TypeInfoPropertyName = "NullableGeneratePreviewResponseDtoResultVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SyncActionEnum?), TypeInfoPropertyName = "NullableSyncActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DiffActionEnum?), TypeInfoPropertyName = "NullableDiffActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DependencyReasonEnum?), TypeInfoPropertyName = "NullableDependencyReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoChannel?), TypeInfoPropertyName = "NullableGetChannelConnectionResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelConnectionResponseDtoProviderId?), TypeInfoPropertyName = "NullableGetChannelConnectionResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateChannelConnectionRequestDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateChannelConnectionRequestDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode?), TypeInfoPropertyName = "NullableCreateChannelConnectionRequestDtoConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateSlackChannelEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateSlackChannelEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackChannelEndpointDtoType?), TypeInfoPropertyName = "NullableCreateSlackChannelEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateSlackUserEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateSlackUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateSlackUserEndpointDtoType?), TypeInfoPropertyName = "NullableCreateSlackUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateWebhookEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateWebhookEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebhookEndpointDtoType?), TypeInfoPropertyName = "NullableCreateWebhookEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreatePhoneEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePhoneEndpointDtoType?), TypeInfoPropertyName = "NullableCreatePhoneEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateMsTeamsChannelEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType?), TypeInfoPropertyName = "NullableCreateMsTeamsChannelEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateMsTeamsUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsUserEndpointDtoType?), TypeInfoPropertyName = "NullableCreateMsTeamsUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateTelegramChatEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTelegramChatEndpointDtoType?), TypeInfoPropertyName = "NullableCreateTelegramChatEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateWebexPersonEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateWebexPersonEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexPersonEndpointDtoType?), TypeInfoPropertyName = "NullableCreateWebexPersonEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateWebexRoomEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateWebexRoomEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateWebexRoomEndpointDtoType?), TypeInfoPropertyName = "NullableCreateWebexRoomEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateLineUserEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateLineUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateLineUserEndpointDtoType?), TypeInfoPropertyName = "NullableCreateLineUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.PagerDutyServiceEndpointDtoRegion?), TypeInfoPropertyName = "NullablePagerDutyServiceEndpointDtoRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreatePagerDutyServiceEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePagerDutyServiceEndpointDtoType?), TypeInfoPropertyName = "NullableCreatePagerDutyServiceEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OpsgenieIntegrationEndpointDtoRegion?), TypeInfoPropertyName = "NullableOpsgenieIntegrationEndpointDtoRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateOpsgenieIntegrationEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoType?), TypeInfoPropertyName = "NullableCreateOpsgenieIntegrationEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateGrafanaOnCallIntegrationEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType?), TypeInfoPropertyName = "NullableCreateGrafanaOnCallIntegrationEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ToolWebhookEndpointDtoMethod?), TypeInfoPropertyName = "NullableToolWebhookEndpointDtoMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateToolWebhookEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateToolWebhookEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateToolWebhookEndpointDtoType?), TypeInfoPropertyName = "NullableCreateToolWebhookEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoChannel?), TypeInfoPropertyName = "NullableGetChannelEndpointResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoProviderId?), TypeInfoPropertyName = "NullableGetChannelEndpointResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoType?), TypeInfoPropertyName = "NullableGetChannelEndpointResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTranslationRequestDtoResourceType?), TypeInfoPropertyName = "NullableCreateTranslationRequestDtoResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationResponseDtoResourceType?), TypeInfoPropertyName = "NullableTranslationResponseDtoResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationGroupDtoResourceType?), TypeInfoPropertyName = "NullableTranslationGroupDtoResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EventBodyStatus?), TypeInfoPropertyName = "NullableEventBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookMessageDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookMessageDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookMessageFailedDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookMessageFailedDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookCreatedWorkflowDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookCreatedWorkflowDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookUpdatedWorkflowDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookDeletedWorkflowDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookDeletedWorkflowDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookPreferenceDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookPreferenceDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType?), TypeInfoPropertyName = "NullableWebhookInboundEmailDtoWebhookPayloadWrapperType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject?), TypeInfoPropertyName = "NullableWebhookInboundEmailDtoWebhookPayloadWrapperObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest?), TypeInfoPropertyName = "NullableChannelEndpointsControllerCreateChannelEndpointRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType?), TypeInfoPropertyName = "NullableChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType?), TypeInfoPropertyName = "NullableTranslationControllerUploadTranslationFilesRequestResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentsControllerListAgentsOrderDirection?), TypeInfoPropertyName = "NullableAgentsControllerListAgentsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection?), TypeInfoPropertyName = "NullableAgentIntegrationsControllerListAgentIntegrationsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainsOrderDirection?), TypeInfoPropertyName = "NullableDomainsControllerListDomainsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection?), TypeInfoPropertyName = "NullableDomainsControllerListDomainRoutesOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ContextsControllerListContextsOrderDirection?), TypeInfoPropertyName = "NullableContextsControllerListContextsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerSearchSubscribersOrderDirection?), TypeInfoPropertyName = "NullableSubscribersControllerSearchSubscribersOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality?), TypeInfoPropertyName = "NullableSubscribersControllerGetSubscriberPreferencesCriticality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection?), TypeInfoPropertyName = "NullableSubscribersControllerListSubscriberTopicsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem?), TypeInfoPropertyName = "NullableSubscribersControllerGetSubscriberNotificationsSeverityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerCompleteNotificationActionActionType?), TypeInfoPropertyName = "NullableSubscribersControllerCompleteNotificationActionActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscribersControllerRevertNotificationActionActionType?), TypeInfoPropertyName = "NullableSubscribersControllerRevertNotificationActionActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel?), TypeInfoPropertyName = "NullableMessagesControllerDeleteMessagesByTransactionIdChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicsOrderDirection?), TypeInfoPropertyName = "NullableTopicsControllerListTopicsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?), TypeInfoPropertyName = "NullableTopicsControllerListTopicSubscriptionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection?), TypeInfoPropertyName = "NullableChannelConnectionsControllerListChannelConnectionsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode?), TypeInfoPropertyName = "NullableChannelConnectionsControllerListChannelConnectionsConnectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?), TypeInfoPropertyName = "NullableChannelConnectionsControllerListChannelConnectionsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection?), TypeInfoPropertyName = "NullableChannelEndpointsControllerListChannelEndpointsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel?), TypeInfoPropertyName = "NullableChannelEndpointsControllerListChannelEndpointsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType?), TypeInfoPropertyName = "NullableTranslationControllerGetTranslationGroupEndpointResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerGetSingleTranslationResourceType?), TypeInfoPropertyName = "NullableTranslationControllerGetSingleTranslationResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerDeleteTranslationEndpointResourceType?), TypeInfoPropertyName = "NullableTranslationControllerDeleteTranslationEndpointResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType?), TypeInfoPropertyName = "NullableTranslationControllerDeleteTranslationGroupEndpointResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ApiKeyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.PayloadValidationErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriberChannelDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TriggerEventRequestDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTriggerVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTriggerDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DigestTimedConfigDtoWeekDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FieldFilterPartDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepFilterDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationStepResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationExecutionDetailResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepTypeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationJobResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityTopicDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ActivityNotificationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.RequestLogResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TraceResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TopicResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WorkflowRunStepsDetailsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetWorkflowRunsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepExecutionDetailDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepRunDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentToolDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentMcpServerDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentIntegrationSummaryDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentSkillInputDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AgentIntegrationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FileRefDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, object, global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ToolResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AddReactionPayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DeleteMessagePayloadDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ExpectedDnsRecordDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainDiagnosticCheckDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainDiagnosticIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.DomainRouteResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetContextResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.UpdatedSubscriberDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.CreatedSubscriberDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FailedOperationDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.CreateSubscriberRequestDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ChannelSettingsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.MessageButton>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationFeedItemDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TimedConfigWeekDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationStepData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationStepDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.NotificationTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::System.Collections.Generic.List<global::Novu.EmailBlock>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EmailBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriberResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TimeRangeDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriberPreferenceOverrideDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriberWorkflowPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.BulkUpdateSubscriberPreferenceItemDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.MessageResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionsDeleteErrorDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EnvironmentVariableWorkflowInfoDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EnvironmentVariableValueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepContentIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepIntegrationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::System.Collections.Generic.List<global::Novu.HttpRequestKeyValuePairDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.StepListResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WorkflowListResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SyncedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.FailedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SkippedWorkflowDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SyncResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceToPublishDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceDiffDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceDependencyDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ResourceDiffResultDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetChannelConnectionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WebhookInboundEmailAddressDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.ChannelTypeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WorkflowStatusEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EnvironmentResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TriggerEventResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.IntegrationResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetPreferencesResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetSubscriberNotificationsCountResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.EnvironmentVariableResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetEnvironmentTagsDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WebhookResultDto>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Novu.JsonConverters.StepsItemJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepsItem2JsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepsItem3JsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestJsonConverter());
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventToAllRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.LinkChannelEndpointRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PatchSubscriberPreferencesDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TopicSubscriberIdentifierDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.DeleteTopicSubscriberIdentifierDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.InAppControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.EmailControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SmsControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.PushControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DelayControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ThrottleControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ToolControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.CustomControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.HttpRequestControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PreviewPayloadDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9, global::Novu.GeneratePreviewResponseDtoResultVariant10>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackChannelEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackUserEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebhookEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePhoneEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTelegramChatEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebexPersonEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebexRoomEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateLineUserEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePagerDutyServiceEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateOpsgenieIntegrationEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateToolWebhookEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>());
            options.Converters.Add(new global::Novu.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType)

                    || typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.TriggerEventResponseDtoStatus)

                    || typeToConvert == typeof(global::Novu.TriggerEventResponseDtoStatus?)

                    || typeToConvert == typeof(global::Novu.SubscriberChannelDtoProviderId)

                    || typeToConvert == typeof(global::Novu.SubscriberChannelDtoProviderId?)

                    || typeToConvert == typeof(global::Novu.TriggerRecipientsTypeEnum)

                    || typeToConvert == typeof(global::Novu.TriggerRecipientsTypeEnum?)

                    || typeToConvert == typeof(global::Novu.SeverityLevelEnum)

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

                    || typeToConvert == typeof(global::Novu.ActivityNotificationJobResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.RequestLogResponseDtoSource)

                    || typeToConvert == typeof(global::Novu.RequestLogResponseDtoSource?)

                    || typeToConvert == typeof(global::Novu.WorkflowRunStepsDetailsDtoStatus)

                    || typeToConvert == typeof(global::Novu.WorkflowRunStepsDetailsDtoStatus?)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoStatus)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoStatus?)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus?)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoSeverity)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoSeverity?)

                    || typeToConvert == typeof(global::Novu.StepRunDtoStatus)

                    || typeToConvert == typeof(global::Novu.StepRunDtoStatus?)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoStatus)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoStatus?)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus?)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoSeverity)

                    || typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoSeverity?)

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

                    || typeToConvert == typeof(global::Novu.SignalDtoType)

                    || typeToConvert == typeof(global::Novu.SignalDtoType?)

                    || typeToConvert == typeof(global::Novu.SignalDtoAction)

                    || typeToConvert == typeof(global::Novu.SignalDtoAction?)

                    || typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping)

                    || typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping?)

                    || typeToConvert == typeof(global::Novu.DomainResponseDtoStatus)

                    || typeToConvert == typeof(global::Novu.DomainResponseDtoStatus?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode?)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity)

                    || typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity?)

                    || typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType)

                    || typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.DomainRouteDtoType)

                    || typeToConvert == typeof(global::Novu.DomainRouteDtoType?)

                    || typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType)

                    || typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType?)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus?)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType)

                    || typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode)

                    || typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode?)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel?)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind)

                    || typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind?)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel?)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind)

                    || typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind?)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode?)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode)

                    || typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode?)

                    || typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode)

                    || typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode?)

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

                    || typeToConvert == typeof(global::Novu.ActorTypeEnum)

                    || typeToConvert == typeof(global::Novu.ActorTypeEnum?)

                    || typeToConvert == typeof(global::Novu.NotificationFeedItemDtoStatus)

                    || typeToConvert == typeof(global::Novu.NotificationFeedItemDtoStatus?)

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

                    || typeToConvert == typeof(global::Novu.MessageMarkAsRequestDtoMarkAs)

                    || typeToConvert == typeof(global::Novu.MessageMarkAsRequestDtoMarkAs?)

                    || typeToConvert == typeof(global::Novu.MarkAllMessageAsRequestDtoMarkAs)

                    || typeToConvert == typeof(global::Novu.MarkAllMessageAsRequestDtoMarkAs?)

                    || typeToConvert == typeof(global::Novu.MarkMessageActionAsSeenDtoStatus)

                    || typeToConvert == typeof(global::Novu.MarkMessageActionAsSeenDtoStatus?)

                    || typeToConvert == typeof(global::Novu.PreferenceOverrideSourceEnum)

                    || typeToConvert == typeof(global::Novu.PreferenceOverrideSourceEnum?)

                    || typeToConvert == typeof(global::Novu.PreferenceLevelEnum)

                    || typeToConvert == typeof(global::Novu.PreferenceLevelEnum?)

                    || typeToConvert == typeof(global::Novu.RedirectDtoTarget)

                    || typeToConvert == typeof(global::Novu.RedirectDtoTarget?)

                    || typeToConvert == typeof(global::Novu.ResourceTypeEnum)

                    || typeToConvert == typeof(global::Novu.ResourceTypeEnum?)

                    || typeToConvert == typeof(global::Novu.UiComponentEnum)

                    || typeToConvert == typeof(global::Novu.UiComponentEnum?)

                    || typeToConvert == typeof(global::Novu.UiSchemaGroupEnum)

                    || typeToConvert == typeof(global::Novu.UiSchemaGroupEnum?)

                    || typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType)

                    || typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType?)

                    || typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum)

                    || typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum?)

                    || typeToConvert == typeof(global::Novu.DirectionEnum)

                    || typeToConvert == typeof(global::Novu.DirectionEnum?)

                    || typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField)

                    || typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField?)

                    || typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType)

                    || typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType?)

                    || typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus)

                    || typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus?)

                    || typeToConvert == typeof(global::Novu.EnvironmentVariableResponseDtoType)

                    || typeToConvert == typeof(global::Novu.EnvironmentVariableResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateEnvironmentVariableRequestDtoType)

                    || typeToConvert == typeof(global::Novu.CreateEnvironmentVariableRequestDtoType?)

                    || typeToConvert == typeof(global::Novu.UpdateEnvironmentVariableRequestDtoType)

                    || typeToConvert == typeof(global::Novu.UpdateEnvironmentVariableRequestDtoType?)

                    || typeToConvert == typeof(global::Novu.ContentIssueEnum)

                    || typeToConvert == typeof(global::Novu.ContentIssueEnum?)

                    || typeToConvert == typeof(global::Novu.StepIssueSeverityEnum)

                    || typeToConvert == typeof(global::Novu.StepIssueSeverityEnum?)

                    || typeToConvert == typeof(global::Novu.IntegrationIssueEnum)

                    || typeToConvert == typeof(global::Novu.IntegrationIssueEnum?)

                    || typeToConvert == typeof(global::Novu.EmailControlDtoEditorType)

                    || typeToConvert == typeof(global::Novu.EmailControlDtoEditorType?)

                    || typeToConvert == typeof(global::Novu.ChatControlDtoEditorType)

                    || typeToConvert == typeof(global::Novu.ChatControlDtoEditorType?)

                    || typeToConvert == typeof(global::Novu.DelayControlDtoType)

                    || typeToConvert == typeof(global::Novu.DelayControlDtoType?)

                    || typeToConvert == typeof(global::Novu.DelayControlDtoUnit)

                    || typeToConvert == typeof(global::Novu.DelayControlDtoUnit?)

                    || typeToConvert == typeof(global::Novu.LookBackWindowDtoUnit)

                    || typeToConvert == typeof(global::Novu.LookBackWindowDtoUnit?)

                    || typeToConvert == typeof(global::Novu.DigestControlDtoType)

                    || typeToConvert == typeof(global::Novu.DigestControlDtoType?)

                    || typeToConvert == typeof(global::Novu.DigestControlDtoUnit)

                    || typeToConvert == typeof(global::Novu.DigestControlDtoUnit?)

                    || typeToConvert == typeof(global::Novu.ThrottleControlDtoType)

                    || typeToConvert == typeof(global::Novu.ThrottleControlDtoType?)

                    || typeToConvert == typeof(global::Novu.ThrottleControlDtoUnit)

                    || typeToConvert == typeof(global::Novu.ThrottleControlDtoUnit?)

                    || typeToConvert == typeof(global::Novu.HttpMethodEnum)

                    || typeToConvert == typeof(global::Novu.HttpMethodEnum?)

                    || typeToConvert == typeof(global::Novu.WorkflowStatusEnum)

                    || typeToConvert == typeof(global::Novu.WorkflowStatusEnum?)

                    || typeToConvert == typeof(global::Novu.WorkflowResponseDtoStepDiscriminatorType)

                    || typeToConvert == typeof(global::Novu.WorkflowResponseDtoStepDiscriminatorType?)

                    || typeToConvert == typeof(global::Novu.WorkflowCreationSourceEnum)

                    || typeToConvert == typeof(global::Novu.WorkflowCreationSourceEnum?)

                    || typeToConvert == typeof(global::Novu.CreateWorkflowDtoStepDiscriminatorType)

                    || typeToConvert == typeof(global::Novu.CreateWorkflowDtoStepDiscriminatorType?)

                    || typeToConvert == typeof(global::Novu.UpdateWorkflowDtoStepDiscriminatorType)

                    || typeToConvert == typeof(global::Novu.UpdateWorkflowDtoStepDiscriminatorType?)

                    || typeToConvert == typeof(global::Novu.WorkflowResponseDtoSortField)

                    || typeToConvert == typeof(global::Novu.WorkflowResponseDtoSortField?)

                    || typeToConvert == typeof(global::Novu.TimeUnitEnum)

                    || typeToConvert == typeof(global::Novu.TimeUnitEnum?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9Type?)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10Type)

                    || typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10Type?)

                    || typeToConvert == typeof(global::Novu.SyncActionEnum)

                    || typeToConvert == typeof(global::Novu.SyncActionEnum?)

                    || typeToConvert == typeof(global::Novu.DiffActionEnum)

                    || typeToConvert == typeof(global::Novu.DiffActionEnum?)

                    || typeToConvert == typeof(global::Novu.DependencyReasonEnum)

                    || typeToConvert == typeof(global::Novu.DependencyReasonEnum?)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel?)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId)

                    || typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId?)

                    || typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode)

                    || typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode?)

                    || typeToConvert == typeof(global::Novu.CreateSlackChannelEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateSlackChannelEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateSlackUserEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateSlackUserEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateWebhookEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateWebhookEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreatePhoneEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreatePhoneEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateMsTeamsUserEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateMsTeamsUserEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateTelegramChatEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateTelegramChatEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateWebexPersonEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateWebexPersonEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateWebexRoomEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateWebexRoomEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateLineUserEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateLineUserEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.PagerDutyServiceEndpointDtoRegion)

                    || typeToConvert == typeof(global::Novu.PagerDutyServiceEndpointDtoRegion?)

                    || typeToConvert == typeof(global::Novu.CreatePagerDutyServiceEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreatePagerDutyServiceEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.OpsgenieIntegrationEndpointDtoRegion)

                    || typeToConvert == typeof(global::Novu.OpsgenieIntegrationEndpointDtoRegion?)

                    || typeToConvert == typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.ToolWebhookEndpointDtoMethod)

                    || typeToConvert == typeof(global::Novu.ToolWebhookEndpointDtoMethod?)

                    || typeToConvert == typeof(global::Novu.CreateToolWebhookEndpointDtoType)

                    || typeToConvert == typeof(global::Novu.CreateToolWebhookEndpointDtoType?)

                    || typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoChannel)

                    || typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoChannel?)

                    || typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoProviderId)

                    || typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoProviderId?)

                    || typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoType)

                    || typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoType?)

                    || typeToConvert == typeof(global::Novu.CreateTranslationRequestDtoResourceType)

                    || typeToConvert == typeof(global::Novu.CreateTranslationRequestDtoResourceType?)

                    || typeToConvert == typeof(global::Novu.TranslationResponseDtoResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationResponseDtoResourceType?)

                    || typeToConvert == typeof(global::Novu.TranslationGroupDtoResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationGroupDtoResourceType?)

                    || typeToConvert == typeof(global::Novu.EventBodyStatus)

                    || typeToConvert == typeof(global::Novu.EventBodyStatus?)

                    || typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType)

                    || typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType?)

                    || typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject)

                    || typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject?)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType?)

                    || typeToConvert == typeof(global::Novu.AgentsControllerListAgentsOrderDirection)

                    || typeToConvert == typeof(global::Novu.AgentsControllerListAgentsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection)

                    || typeToConvert == typeof(global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection)

                    || typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection?)

                    || typeToConvert == typeof(global::Novu.ContextsControllerListContextsOrderDirection)

                    || typeToConvert == typeof(global::Novu.ContextsControllerListContextsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerSearchSubscribersOrderDirection)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerSearchSubscribersOrderDirection?)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality?)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem?)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerCompleteNotificationActionActionType)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerCompleteNotificationActionActionType?)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerRevertNotificationActionActionType)

                    || typeToConvert == typeof(global::Novu.SubscribersControllerRevertNotificationActionActionType?)

                    || typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel)

                    || typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel?)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection)

                    || typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode?)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel)

                    || typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel?)

                    || typeToConvert == typeof(global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType?)

                    || typeToConvert == typeof(global::Novu.TranslationControllerGetSingleTranslationResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationControllerGetSingleTranslationResourceType?)

                    || typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationEndpointResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationEndpointResourceType?)

                    || typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType)

                    || typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType))
                {
                    return new global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EnvironmentResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TriggerEventResponseDtoStatus))
                {
                    return new global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TriggerEventResponseDtoStatus?))
                {
                    return new global::Novu.JsonConverters.TriggerEventResponseDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscriberChannelDtoProviderId))
                {
                    return new global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscriberChannelDtoProviderId?))
                {
                    return new global::Novu.JsonConverters.SubscriberChannelDtoProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TriggerRecipientsTypeEnum))
                {
                    return new global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TriggerRecipientsTypeEnum?))
                {
                    return new global::Novu.JsonConverters.TriggerRecipientsTypeEnumNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Novu.RequestLogResponseDtoSource))
                {
                    return new global::Novu.JsonConverters.RequestLogResponseDtoSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.RequestLogResponseDtoSource?))
                {
                    return new global::Novu.JsonConverters.RequestLogResponseDtoSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowRunStepsDetailsDtoStatus))
                {
                    return new global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowRunStepsDetailsDtoStatus?))
                {
                    return new global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoStatus))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoStatus?))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunsDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus?))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoSeverity))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunsDtoSeverity?))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepRunDtoStatus))
                {
                    return new global::Novu.JsonConverters.StepRunDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepRunDtoStatus?))
                {
                    return new global::Novu.JsonConverters.StepRunDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoStatus))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoStatus?))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus?))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoSeverity))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetWorkflowRunResponseDtoSeverity?))
                {
                    return new global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Novu.SignalDtoType))
                {
                    return new global::Novu.JsonConverters.SignalDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SignalDtoType?))
                {
                    return new global::Novu.JsonConverters.SignalDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SignalDtoAction))
                {
                    return new global::Novu.JsonConverters.SignalDtoActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SignalDtoAction?))
                {
                    return new global::Novu.JsonConverters.SignalDtoActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping))
                {
                    return new global::Novu.JsonConverters.AgentReplyPayloadDtoTypingJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.AgentReplyPayloadDtoTyping?))
                {
                    return new global::Novu.JsonConverters.AgentReplyPayloadDtoTypingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainResponseDtoStatus))
                {
                    return new global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainResponseDtoStatus?))
                {
                    return new global::Novu.JsonConverters.DomainResponseDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoCode?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticCheckDtoStatus?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoCode?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainDiagnosticIssueDtoSeverity?))
                {
                    return new global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType))
                {
                    return new global::Novu.JsonConverters.DomainRouteResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.DomainRouteResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteDtoType))
                {
                    return new global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainRouteDtoType?))
                {
                    return new global::Novu.JsonConverters.DomainRouteDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType))
                {
                    return new global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateDomainRouteDtoType?))
                {
                    return new global::Novu.JsonConverters.UpdateDomainRouteDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoDomainStatus?))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TestDomainRouteResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode))
                {
                    return new global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainConnectStatusResponseDtoReasonCode?))
                {
                    return new global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoChannel?))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationResponseDtoKind?))
                {
                    return new global::Novu.JsonConverters.IntegrationResponseDtoKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoChannel?))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateIntegrationRequestDtoKind?))
                {
                    return new global::Novu.JsonConverters.CreateIntegrationRequestDtoKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoMode?))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateChatOauthUrlRequestDtoConnectionMode?))
                {
                    return new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode))
                {
                    return new global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateConnectOauthUrlRequestDtoConnectionMode?))
                {
                    return new global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Novu.ActorTypeEnum))
                {
                    return new global::Novu.JsonConverters.ActorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ActorTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ActorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.NotificationFeedItemDtoStatus))
                {
                    return new global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.NotificationFeedItemDtoStatus?))
                {
                    return new global::Novu.JsonConverters.NotificationFeedItemDtoStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Novu.MessageMarkAsRequestDtoMarkAs))
                {
                    return new global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessageMarkAsRequestDtoMarkAs?))
                {
                    return new global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MarkAllMessageAsRequestDtoMarkAs))
                {
                    return new global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MarkAllMessageAsRequestDtoMarkAs?))
                {
                    return new global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MarkMessageActionAsSeenDtoStatus))
                {
                    return new global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MarkMessageActionAsSeenDtoStatus?))
                {
                    return new global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.PreferenceOverrideSourceEnum))
                {
                    return new global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.PreferenceOverrideSourceEnum?))
                {
                    return new global::Novu.JsonConverters.PreferenceOverrideSourceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.PreferenceLevelEnum))
                {
                    return new global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.PreferenceLevelEnum?))
                {
                    return new global::Novu.JsonConverters.PreferenceLevelEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.RedirectDtoTarget))
                {
                    return new global::Novu.JsonConverters.RedirectDtoTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.RedirectDtoTarget?))
                {
                    return new global::Novu.JsonConverters.RedirectDtoTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceTypeEnum))
                {
                    return new global::Novu.JsonConverters.ResourceTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ResourceTypeEnum?))
                {
                    return new global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiComponentEnum))
                {
                    return new global::Novu.JsonConverters.UiComponentEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiComponentEnum?))
                {
                    return new global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiSchemaGroupEnum))
                {
                    return new global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UiSchemaGroupEnum?))
                {
                    return new global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType))
                {
                    return new global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailControlsDtoEditorType?))
                {
                    return new global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum))
                {
                    return new global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutCreationSourceEnum?))
                {
                    return new global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DirectionEnum))
                {
                    return new global::Novu.JsonConverters.DirectionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DirectionEnum?))
                {
                    return new global::Novu.JsonConverters.DirectionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField))
                {
                    return new global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LayoutResponseDtoSortField?))
                {
                    return new global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType))
                {
                    return new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GenerateLayoutPreviewResponseDtoResultType?))
                {
                    return new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus))
                {
                    return new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DeleteMessageResponseDtoStatus?))
                {
                    return new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EnvironmentVariableResponseDtoType))
                {
                    return new global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EnvironmentVariableResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateEnvironmentVariableRequestDtoType))
                {
                    return new global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateEnvironmentVariableRequestDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateEnvironmentVariableRequestDtoType))
                {
                    return new global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateEnvironmentVariableRequestDtoType?))
                {
                    return new global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ContentIssueEnum))
                {
                    return new global::Novu.JsonConverters.ContentIssueEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ContentIssueEnum?))
                {
                    return new global::Novu.JsonConverters.ContentIssueEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepIssueSeverityEnum))
                {
                    return new global::Novu.JsonConverters.StepIssueSeverityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.StepIssueSeverityEnum?))
                {
                    return new global::Novu.JsonConverters.StepIssueSeverityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationIssueEnum))
                {
                    return new global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.IntegrationIssueEnum?))
                {
                    return new global::Novu.JsonConverters.IntegrationIssueEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailControlDtoEditorType))
                {
                    return new global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EmailControlDtoEditorType?))
                {
                    return new global::Novu.JsonConverters.EmailControlDtoEditorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChatControlDtoEditorType))
                {
                    return new global::Novu.JsonConverters.ChatControlDtoEditorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChatControlDtoEditorType?))
                {
                    return new global::Novu.JsonConverters.ChatControlDtoEditorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayControlDtoType))
                {
                    return new global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayControlDtoType?))
                {
                    return new global::Novu.JsonConverters.DelayControlDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayControlDtoUnit))
                {
                    return new global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DelayControlDtoUnit?))
                {
                    return new global::Novu.JsonConverters.DelayControlDtoUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LookBackWindowDtoUnit))
                {
                    return new global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.LookBackWindowDtoUnit?))
                {
                    return new global::Novu.JsonConverters.LookBackWindowDtoUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestControlDtoType))
                {
                    return new global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestControlDtoType?))
                {
                    return new global::Novu.JsonConverters.DigestControlDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestControlDtoUnit))
                {
                    return new global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DigestControlDtoUnit?))
                {
                    return new global::Novu.JsonConverters.DigestControlDtoUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ThrottleControlDtoType))
                {
                    return new global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ThrottleControlDtoType?))
                {
                    return new global::Novu.JsonConverters.ThrottleControlDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ThrottleControlDtoUnit))
                {
                    return new global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ThrottleControlDtoUnit?))
                {
                    return new global::Novu.JsonConverters.ThrottleControlDtoUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.HttpMethodEnum))
                {
                    return new global::Novu.JsonConverters.HttpMethodEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.HttpMethodEnum?))
                {
                    return new global::Novu.JsonConverters.HttpMethodEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowStatusEnum))
                {
                    return new global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowStatusEnum?))
                {
                    return new global::Novu.JsonConverters.WorkflowStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowResponseDtoStepDiscriminatorType))
                {
                    return new global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowResponseDtoStepDiscriminatorType?))
                {
                    return new global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowCreationSourceEnum))
                {
                    return new global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowCreationSourceEnum?))
                {
                    return new global::Novu.JsonConverters.WorkflowCreationSourceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWorkflowDtoStepDiscriminatorType))
                {
                    return new global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWorkflowDtoStepDiscriminatorType?))
                {
                    return new global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateWorkflowDtoStepDiscriminatorType))
                {
                    return new global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.UpdateWorkflowDtoStepDiscriminatorType?))
                {
                    return new global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowResponseDtoSortField))
                {
                    return new global::Novu.JsonConverters.WorkflowResponseDtoSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WorkflowResponseDtoSortField?))
                {
                    return new global::Novu.JsonConverters.WorkflowResponseDtoSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimeUnitEnum))
                {
                    return new global::Novu.JsonConverters.TimeUnitEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TimeUnitEnum?))
                {
                    return new global::Novu.JsonConverters.TimeUnitEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant2Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant3Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant4Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant5Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant6Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant7Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant8Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant9Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10Type))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GeneratePreviewResponseDtoResultVariant10Type?))
                {
                    return new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SyncActionEnum))
                {
                    return new global::Novu.JsonConverters.SyncActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SyncActionEnum?))
                {
                    return new global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DiffActionEnum))
                {
                    return new global::Novu.JsonConverters.DiffActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DiffActionEnum?))
                {
                    return new global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DependencyReasonEnum))
                {
                    return new global::Novu.JsonConverters.DependencyReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DependencyReasonEnum?))
                {
                    return new global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoChannel?))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelConnectionResponseDtoProviderId?))
                {
                    return new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode))
                {
                    return new global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateChannelConnectionRequestDtoConnectionMode?))
                {
                    return new global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateSlackChannelEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateSlackChannelEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateSlackUserEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateSlackUserEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWebhookEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWebhookEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreatePhoneEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreatePhoneEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateMsTeamsUserEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateMsTeamsUserEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateTelegramChatEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateTelegramChatEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWebexPersonEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateWebexPersonEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWebexPersonEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateWebexPersonEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWebexRoomEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateWebexRoomEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateWebexRoomEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateWebexRoomEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateLineUserEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateLineUserEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateLineUserEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateLineUserEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.PagerDutyServiceEndpointDtoRegion))
                {
                    return new global::Novu.JsonConverters.PagerDutyServiceEndpointDtoRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.PagerDutyServiceEndpointDtoRegion?))
                {
                    return new global::Novu.JsonConverters.PagerDutyServiceEndpointDtoRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreatePagerDutyServiceEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreatePagerDutyServiceEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreatePagerDutyServiceEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreatePagerDutyServiceEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.OpsgenieIntegrationEndpointDtoRegion))
                {
                    return new global::Novu.JsonConverters.OpsgenieIntegrationEndpointDtoRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.OpsgenieIntegrationEndpointDtoRegion?))
                {
                    return new global::Novu.JsonConverters.OpsgenieIntegrationEndpointDtoRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateOpsgenieIntegrationEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateOpsgenieIntegrationEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateOpsgenieIntegrationEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateGrafanaOnCallIntegrationEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateGrafanaOnCallIntegrationEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateGrafanaOnCallIntegrationEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ToolWebhookEndpointDtoMethod))
                {
                    return new global::Novu.JsonConverters.ToolWebhookEndpointDtoMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ToolWebhookEndpointDtoMethod?))
                {
                    return new global::Novu.JsonConverters.ToolWebhookEndpointDtoMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateToolWebhookEndpointDtoType))
                {
                    return new global::Novu.JsonConverters.CreateToolWebhookEndpointDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateToolWebhookEndpointDtoType?))
                {
                    return new global::Novu.JsonConverters.CreateToolWebhookEndpointDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoChannel))
                {
                    return new global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoChannel?))
                {
                    return new global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoProviderId))
                {
                    return new global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoProviderId?))
                {
                    return new global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoType))
                {
                    return new global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.GetChannelEndpointResponseDtoType?))
                {
                    return new global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateTranslationRequestDtoResourceType))
                {
                    return new global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.CreateTranslationRequestDtoResourceType?))
                {
                    return new global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationResponseDtoResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationResponseDtoResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationResponseDtoResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationGroupDtoResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationGroupDtoResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationGroupDtoResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EventBodyStatus))
                {
                    return new global::Novu.JsonConverters.EventBodyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.EventBodyStatus?))
                {
                    return new global::Novu.JsonConverters.EventBodyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType))
                {
                    return new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperType?))
                {
                    return new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject))
                {
                    return new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.WebhookInboundEmailDtoWebhookPayloadWrapperObject?))
                {
                    return new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType?))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerUploadTranslationFilesRequestResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.DomainsControllerListDomainRoutesOrderDirection?))
                {
                    return new global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ContextsControllerListContextsOrderDirection))
                {
                    return new global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ContextsControllerListContextsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerSearchSubscribersOrderDirection))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerSearchSubscribersOrderDirection?))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality?))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem?))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerCompleteNotificationActionActionType))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerCompleteNotificationActionActionType?))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerRevertNotificationActionActionType))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.SubscribersControllerRevertNotificationActionActionType?))
                {
                    return new global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel))
                {
                    return new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel?))
                {
                    return new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsConnectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsConnectionMode?))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsConnectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?))
                {
                    return new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection?))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel?))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerGetTranslationGroupEndpointResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerGetSingleTranslationResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerGetSingleTranslationResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationEndpointResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationEndpointResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType))
                {
                    return new global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.TranslationControllerDeleteTranslationGroupEndpointResourceType?))
                {
                    return new global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}