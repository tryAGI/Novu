
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
            typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter),

            typeof(global::Novu.JsonConverters.SeverityLevelEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.StepTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestUnitEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DigestUnitEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalEnumJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalValueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalValueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MonthlyTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ProvidersIdEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorNullableJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepFilterDtoValueJsonConverter),

            typeof(global::Novu.JsonConverters.StepFilterDtoValueNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.RequestLogResponseDtoSourceJsonConverter),

            typeof(global::Novu.JsonConverters.RequestLogResponseDtoSourceNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepRunDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.StepRunDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DomainResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoKindJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoKindNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.EmailBlockTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TextAlignEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TextAlignEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelCTATypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MessageActionStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ButtonTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ButtonTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ActorTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ActorTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigWeekDayJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigWeekDayNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MessageStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter),

            typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter),

            typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceLevelEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.RedirectDtoTargetJsonConverter),

            typeof(global::Novu.JsonConverters.RedirectDtoTargetNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UiComponentEnumJsonConverter),

            typeof(global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter),

            typeof(global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DirectionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DirectionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ContentIssueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ContentIssueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationIssueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.HttpMethodEnumJsonConverter),

            typeof(global::Novu.JsonConverters.HttpMethodEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoSortFieldJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoSortFieldNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimeUnitEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TimeUnitEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SyncActionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DiffActionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DependencyReasonEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EventBodyStatusJsonConverter),

            typeof(global::Novu.JsonConverters.EventBodyStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter),

            typeof(global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepsItemJsonConverter),

            typeof(global::Novu.JsonConverters.StepsItem2JsonConverter),

            typeof(global::Novu.JsonConverters.StepsItem3JsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestJsonConverter),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventToAllRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PatchSubscriberPreferencesDtoContext2>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TopicSubscriberIdentifierDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.DeleteTopicSubscriberIdentifierDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.InAppControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.EmailControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SmsControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.PushControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DelayControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ThrottleControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.CustomControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.HttpRequestControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PreviewPayloadDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackChannelEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackUserEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebhookEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePhoneEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTelegramChatEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>),

            typeof(global::Novu.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9_d819718aa0a1ad4d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>), TypeInfoPropertyName = "TelegramChatEndpointDto_4d499288bedd416f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>?), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9_c21c4294b0aad1ee")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>?), TypeInfoPropertyName = "TelegramChatEndpointDto_72bcdf72cda336d0")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.TopicSubscriptionResponseDto))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionPreferenceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.SubscriptionResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepContentIssueDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationIssueEnum), TypeInfoPropertyName = "IntegrationIssueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepIntegrationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepIssuesDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepContentIssueDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.StepIntegrationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.StepResponseDto))]
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
            typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter),

            typeof(global::Novu.JsonConverters.SeverityLevelEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.StepTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestUnitEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DigestUnitEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalEnumJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalValueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalValueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MonthlyTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ProvidersIdEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorNullableJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepFilterDtoValueJsonConverter),

            typeof(global::Novu.JsonConverters.StepFilterDtoValueNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.RequestLogResponseDtoSourceJsonConverter),

            typeof(global::Novu.JsonConverters.RequestLogResponseDtoSourceNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepRunDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.StepRunDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DomainResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoKindJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoKindNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.EmailBlockTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TextAlignEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TextAlignEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelCTATypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MessageActionStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ButtonTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ButtonTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ActorTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ActorTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigWeekDayJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigWeekDayNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MessageStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter),

            typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter),

            typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceLevelEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.RedirectDtoTargetJsonConverter),

            typeof(global::Novu.JsonConverters.RedirectDtoTargetNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UiComponentEnumJsonConverter),

            typeof(global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter),

            typeof(global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DirectionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DirectionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ContentIssueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ContentIssueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationIssueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.HttpMethodEnumJsonConverter),

            typeof(global::Novu.JsonConverters.HttpMethodEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoSortFieldJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoSortFieldNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimeUnitEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TimeUnitEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SyncActionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DiffActionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DependencyReasonEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EventBodyStatusJsonConverter),

            typeof(global::Novu.JsonConverters.EventBodyStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter),

            typeof(global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepsItemJsonConverter),

            typeof(global::Novu.JsonConverters.StepsItem2JsonConverter),

            typeof(global::Novu.JsonConverters.StepsItem3JsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestJsonConverter),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventToAllRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PatchSubscriberPreferencesDtoContext2>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TopicSubscriberIdentifierDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.DeleteTopicSubscriberIdentifierDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.InAppControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.EmailControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SmsControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.PushControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DelayControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ThrottleControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.CustomControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.HttpRequestControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PreviewPayloadDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackChannelEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackUserEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebhookEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePhoneEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTelegramChatEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>),

            typeof(global::Novu.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9_d819718aa0a1ad4d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>), TypeInfoPropertyName = "TelegramChatEndpointDto_4d499288bedd416f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>?), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9_c21c4294b0aad1ee")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>?), TypeInfoPropertyName = "TelegramChatEndpointDto_72bcdf72cda336d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>), TypeInfoPropertyName = "ListLayoutResponseDto_System_Collections_Generic_List_global_Novu_LayoutResponseDto")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoChannel), TypeInfoPropertyName = "GetChannelEndpointResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoProviderId), TypeInfoPropertyName = "GetChannelEndpointResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoType), TypeInfoPropertyName = "GetChannelEndpointResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListChannelEndpointsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Novu.GetChannelEndpointResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.UpdateChannelEndpointRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>), TypeInfoPropertyName = "OneOfSlackChannelEndpointDtoSlackUserEndpointDtoWebhookEndpointDtoPhoneEndpointDto2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.IntegrationIssueEnum?), TypeInfoPropertyName = "NullableIntegrationIssueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.EmailControlDtoEditorType?), TypeInfoPropertyName = "NullableEmailControlDtoEditorType2")]
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
            typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerEventResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.SubscriberChannelDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TriggerRecipientsTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter),

            typeof(global::Novu.JsonConverters.SeverityLevelEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.StepTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestUnitEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DigestUnitEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalEnumJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalValueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.OrdinalValueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MonthlyTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestMetadataDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ProvidersIdEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.BuilderFieldTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOperatorNullableJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter),

            typeof(global::Novu.JsonConverters.FieldFilterPartDtoOnNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepFilterDtoValueJsonConverter),

            typeof(global::Novu.JsonConverters.StepFilterDtoValueNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.RequestLogResponseDtoSourceJsonConverter),

            typeof(global::Novu.JsonConverters.RequestLogResponseDtoSourceNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepRunDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.StepRunDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DomainResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter),

            typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainRouteDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateDomainRouteDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter),

            typeof(global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoKindJsonConverter),

            typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoKindNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.EmailBlockTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TextAlignEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TextAlignEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelCTATypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MessageActionStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ButtonTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ButtonTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ActorTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ActorTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationFeedItemDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigWeekDayJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigWeekDayNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigOrdinalValueNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TimedConfigMonthlyTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestTimedMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayRegularMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayScheduledMetadataTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter),

            typeof(global::Novu.JsonConverters.NotificationTriggerTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.MessageStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter),

            typeof(global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter),

            typeof(global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceOverrideSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter),

            typeof(global::Novu.JsonConverters.PreferenceLevelEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.RedirectDtoTargetJsonConverter),

            typeof(global::Novu.JsonConverters.RedirectDtoTargetNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UiComponentEnumJsonConverter),

            typeof(global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter),

            typeof(global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DirectionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DirectionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter),

            typeof(global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter),

            typeof(global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter),

            typeof(global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ContentIssueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.ContentIssueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter),

            typeof(global::Novu.JsonConverters.IntegrationIssueEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.EmailControlDtoEditorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DelayControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.LookBackWindowDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.DigestControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter),

            typeof(global::Novu.JsonConverters.ThrottleControlDtoUnitNullableJsonConverter),

            typeof(global::Novu.JsonConverters.HttpMethodEnumJsonConverter),

            typeof(global::Novu.JsonConverters.HttpMethodEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowStatusEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoSortFieldJsonConverter),

            typeof(global::Novu.JsonConverters.WorkflowResponseDtoSortFieldNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TimeUnitEnumJsonConverter),

            typeof(global::Novu.JsonConverters.TimeUnitEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeJsonConverter),

            typeof(global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SyncActionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DiffActionEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DependencyReasonEnumJsonConverter),

            typeof(global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdNullableJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter),

            typeof(global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationResponseDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationGroupDtoResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.EventBodyStatusJsonConverter),

            typeof(global::Novu.JsonConverters.EventBodyStatusNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectJsonConverter),

            typeof(global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeJsonConverter),

            typeof(global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter),

            typeof(global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionNullableJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelJsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeJsonConverter),

            typeof(global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeNullableJsonConverter),

            typeof(global::Novu.JsonConverters.StepsItemJsonConverter),

            typeof(global::Novu.JsonConverters.StepsItem2JsonConverter),

            typeof(global::Novu.JsonConverters.StepsItem3JsonConverter),

            typeof(global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestJsonConverter),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventToAllRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PatchSubscriberPreferencesDtoContext2>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>),

            typeof(global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TopicSubscriberIdentifierDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.DeleteTopicSubscriberIdentifierDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Novu.HttpRequestKeyValuePairDto>>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.InAppControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.EmailControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SmsControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.PushControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DelayControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ThrottleControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.CustomControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.HttpRequestControlDto, object>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PreviewPayloadDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackChannelEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackUserEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebhookEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePhoneEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTelegramChatEndpointDtoContext2>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>),

            typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>),

            typeof(global::Novu.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ListLayoutResponseDto), TypeInfoPropertyName = "ListLayoutResponseDto_Novu_ListLayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9_d819718aa0a1ad4d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>), TypeInfoPropertyName = "TelegramChatEndpointDto_4d499288bedd416f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>?), TypeInfoPropertyName = "GeneratePreviewResponseDtoResultVariant9_c21c4294b0aad1ee")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>?), TypeInfoPropertyName = "TelegramChatEndpointDto_72bcdf72cda336d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.LayoutResponseDto>), TypeInfoPropertyName = "ListLayoutResponseDto_System_Collections_Generic_List_global_Novu_LayoutResponseDto")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreatePhoneEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreatePhoneEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreatePhoneEndpointDtoType?), TypeInfoPropertyName = "NullableCreatePhoneEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateMsTeamsChannelEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsChannelEndpointDtoType?), TypeInfoPropertyName = "NullableCreateMsTeamsChannelEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateMsTeamsUserEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateMsTeamsUserEndpointDtoType?), TypeInfoPropertyName = "NullableCreateMsTeamsUserEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, global::Novu.CreateTelegramChatEndpointDtoContext2>?), TypeInfoPropertyName = "NullableOneOfStringCreateTelegramChatEndpointDtoContext22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.CreateTelegramChatEndpointDtoType?), TypeInfoPropertyName = "NullableCreateTelegramChatEndpointDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoChannel?), TypeInfoPropertyName = "NullableGetChannelEndpointResponseDtoChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoProviderId?), TypeInfoPropertyName = "NullableGetChannelEndpointResponseDtoProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.GetChannelEndpointResponseDtoType?), TypeInfoPropertyName = "NullableGetChannelEndpointResponseDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>?), TypeInfoPropertyName = "NullableOneOfSlackChannelEndpointDtoSlackUserEndpointDtoWebhookEndpointDtoPhoneEndpointDto2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.TopicSubscriptionResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.InboxNotificationDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.WorkflowInfoDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.MessageResponseDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.SubscriptionPreferenceDto>))]
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
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default
            );

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
            options.Converters.Add(new global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TriggerEventResponseDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscriberChannelDtoProviderIdNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TriggerRecipientsTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SeverityLevelEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SeverityLevelEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ResourceOriginEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.NotificationTriggerDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestUnitEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestUnitEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.OrdinalEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.OrdinalEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.OrdinalValueEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.OrdinalValueEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MonthlyTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestMetadataDtoUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ExecutionDetailsStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ProvidersIdEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ExecutionDetailsSourceEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.BuilderFieldTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.FieldFilterPartDtoOperatorNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.FieldFilterPartDtoOnNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepFilterDtoValueJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepFilterDtoValueNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.RequestLogResponseDtoSourceJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.RequestLogResponseDtoSourceNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunsDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepRunDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.StepRunDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainResponseDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainResponseDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainRouteResponseDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainRouteResponseDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainRouteDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainRouteDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UpdateDomainRouteDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UpdateDomainRouteDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainConnectStatusResponseDtoReasonCodeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.IntegrationResponseDtoKindNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateIntegrationRequestDtoKindJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateIntegrationRequestDtoKindNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoModeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateChatOauthUrlRequestDtoConnectionModeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateConnectOauthUrlRequestDtoConnectionModeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EmailBlockTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TextAlignEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TextAlignEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelCTATypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessageActionStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ButtonTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ButtonTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ActorTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ActorTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.NotificationFeedItemDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestRegularMetadataUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestRegularMetadataTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigWeekDayJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigWeekDayNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigOrdinalNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigOrdinalValueNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimedConfigMonthlyTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTimedMetadataUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestTimedMetadataTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayRegularMetadataUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayRegularMetadataTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayScheduledMetadataTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.NotificationTriggerTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessageStatusEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessageStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.PreferenceOverrideSourceEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.PreferenceLevelEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.RedirectDtoTargetJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.RedirectDtoTargetNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ResourceTypeEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UiComponentEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DirectionEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DirectionEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ContentIssueEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ContentIssueEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.IntegrationIssueEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EmailControlDtoEditorTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayControlDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DelayControlDtoUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.LookBackWindowDtoUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestControlDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DigestControlDtoUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ThrottleControlDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ThrottleControlDtoUnitNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.HttpMethodEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.HttpMethodEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowCreationSourceEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowResponseDtoSortFieldJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WorkflowResponseDtoSortFieldNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimeUnitEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TimeUnitEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SyncActionEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DiffActionEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DependencyReasonEnumJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateChannelConnectionRequestDtoConnectionModeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateTelegramChatEndpointDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationResponseDtoResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationGroupDtoResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EventBodyStatusJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.EventBodyStatusNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.WebhookInboundEmailDtoWebhookPayloadWrapperObjectNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainsControllerListDomainsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.DomainsControllerListDomainRoutesOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeJsonConverter());
            options.Converters.Add(new global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeNullableJsonConverter());
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateConnectOauthUrlRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateLinkUserOauthUrlRequestDtoContext2>());
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.CustomControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.HttpRequestControlDto, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PreviewPayloadDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackChannelEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackUserEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebhookEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePhoneEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTelegramChatEndpointDtoContext2>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>());
            options.Converters.Add(new global::Novu.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}