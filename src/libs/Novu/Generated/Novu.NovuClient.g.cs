
#nullable enable

namespace Novu
{
    /// <summary>
    /// Novu REST API. Please see https://docs.novu.co/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class NovuClient : global::Novu.INovuClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.novu.co";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Novu.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Novu.JsonConverters.EnvironmentResponseDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.EnvironmentResponseDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TriggerEventResponseDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.TriggerEventResponseDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscriberChannelDtoProviderIdJsonConverter(),
                    new global::Novu.JsonConverters.SubscriberChannelDtoProviderIdNullableJsonConverter(),
                    new global::Novu.JsonConverters.TriggerRecipientsTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.TriggerRecipientsTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.SeverityLevelEnumJsonConverter(),
                    new global::Novu.JsonConverters.SeverityLevelEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.ChannelTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.StepTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.StepTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ResourceOriginEnumJsonConverter(),
                    new global::Novu.JsonConverters.ResourceOriginEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.NotificationTriggerDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.NotificationTriggerDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.DigestTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestUnitEnumJsonConverter(),
                    new global::Novu.JsonConverters.DigestUnitEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.OrdinalEnumJsonConverter(),
                    new global::Novu.JsonConverters.OrdinalEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.OrdinalValueEnumJsonConverter(),
                    new global::Novu.JsonConverters.OrdinalValueEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.MonthlyTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.MonthlyTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayJsonConverter(),
                    new global::Novu.JsonConverters.DigestTimedConfigDtoWeekDayNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestMetadataDtoUnitJsonConverter(),
                    new global::Novu.JsonConverters.DigestMetadataDtoUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter(),
                    new global::Novu.JsonConverters.ExecutionDetailsStatusEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ProvidersIdEnumJsonConverter(),
                    new global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter(),
                    new global::Novu.JsonConverters.ExecutionDetailsSourceEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.BuilderFieldTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.BuilderFieldTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.FieldFilterPartDtoOperatorJsonConverter(),
                    new global::Novu.JsonConverters.FieldFilterPartDtoOperatorNullableJsonConverter(),
                    new global::Novu.JsonConverters.FieldFilterPartDtoOnJsonConverter(),
                    new global::Novu.JsonConverters.FieldFilterPartDtoOnNullableJsonConverter(),
                    new global::Novu.JsonConverters.StepFilterDtoValueJsonConverter(),
                    new global::Novu.JsonConverters.StepFilterDtoValueNullableJsonConverter(),
                    new global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunsDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityNullableJsonConverter(),
                    new global::Novu.JsonConverters.StepRunDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.StepRunDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunResponseDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityJsonConverter(),
                    new global::Novu.JsonConverters.GetWorkflowRunResponseDtoSeverityNullableJsonConverter(),
                    new global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter(),
                    new global::Novu.JsonConverters.IntegrationResponseDtoChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter(),
                    new global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChatOrPushProviderEnumJsonConverter(),
                    new global::Novu.JsonConverters.ChatOrPushProviderEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.EmailBlockTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.TextAlignEnumJsonConverter(),
                    new global::Novu.JsonConverters.TextAlignEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelCTATypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.ChannelCTATypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.MessageActionStatusEnumJsonConverter(),
                    new global::Novu.JsonConverters.MessageActionStatusEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ButtonTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.ButtonTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.ActorTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.ActorTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.NotificationFeedItemDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.NotificationFeedItemDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestRegularMetadataUnitJsonConverter(),
                    new global::Novu.JsonConverters.DigestRegularMetadataUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestRegularMetadataTypeJsonConverter(),
                    new global::Novu.JsonConverters.DigestRegularMetadataTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitJsonConverter(),
                    new global::Novu.JsonConverters.DigestRegularMetadataBackoffUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigWeekDayJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigWeekDayNullableJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigOrdinalJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigOrdinalNullableJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigOrdinalValueJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigOrdinalValueNullableJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigMonthlyTypeJsonConverter(),
                    new global::Novu.JsonConverters.TimedConfigMonthlyTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestTimedMetadataUnitJsonConverter(),
                    new global::Novu.JsonConverters.DigestTimedMetadataUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestTimedMetadataTypeJsonConverter(),
                    new global::Novu.JsonConverters.DigestTimedMetadataTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DelayRegularMetadataUnitJsonConverter(),
                    new global::Novu.JsonConverters.DelayRegularMetadataUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.DelayRegularMetadataTypeJsonConverter(),
                    new global::Novu.JsonConverters.DelayRegularMetadataTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DelayScheduledMetadataTypeJsonConverter(),
                    new global::Novu.JsonConverters.DelayScheduledMetadataTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.NotificationTriggerTypeJsonConverter(),
                    new global::Novu.JsonConverters.NotificationTriggerTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.MessageStatusEnumJsonConverter(),
                    new global::Novu.JsonConverters.MessageStatusEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsJsonConverter(),
                    new global::Novu.JsonConverters.MessageMarkAsRequestDtoMarkAsNullableJsonConverter(),
                    new global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsJsonConverter(),
                    new global::Novu.JsonConverters.MarkAllMessageAsRequestDtoMarkAsNullableJsonConverter(),
                    new global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.MarkMessageActionAsSeenDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.PreferenceOverrideSourceEnumJsonConverter(),
                    new global::Novu.JsonConverters.PreferenceOverrideSourceEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter(),
                    new global::Novu.JsonConverters.PreferenceLevelEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.RedirectDtoTargetJsonConverter(),
                    new global::Novu.JsonConverters.RedirectDtoTargetNullableJsonConverter(),
                    new global::Novu.JsonConverters.ResourceTypeEnumJsonConverter(),
                    new global::Novu.JsonConverters.ResourceTypeEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.UiComponentEnumJsonConverter(),
                    new global::Novu.JsonConverters.UiComponentEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.UiSchemaGroupEnumJsonConverter(),
                    new global::Novu.JsonConverters.UiSchemaGroupEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.EmailControlsDtoEditorTypeJsonConverter(),
                    new global::Novu.JsonConverters.EmailControlsDtoEditorTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.LayoutCreationSourceEnumJsonConverter(),
                    new global::Novu.JsonConverters.LayoutCreationSourceEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.DirectionEnumJsonConverter(),
                    new global::Novu.JsonConverters.DirectionEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.LayoutResponseDtoSortFieldJsonConverter(),
                    new global::Novu.JsonConverters.LayoutResponseDtoSortFieldNullableJsonConverter(),
                    new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeJsonConverter(),
                    new global::Novu.JsonConverters.GenerateLayoutPreviewResponseDtoResultTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusJsonConverter(),
                    new global::Novu.JsonConverters.DeleteMessageResponseDtoStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.EnvironmentVariableResponseDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateEnvironmentVariableRequestDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.UpdateEnvironmentVariableRequestDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.ContentIssueEnumJsonConverter(),
                    new global::Novu.JsonConverters.ContentIssueEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter(),
                    new global::Novu.JsonConverters.IntegrationIssueEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.EmailControlDtoEditorTypeJsonConverter(),
                    new global::Novu.JsonConverters.EmailControlDtoEditorTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DelayControlDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.DelayControlDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DelayControlDtoUnitJsonConverter(),
                    new global::Novu.JsonConverters.DelayControlDtoUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.LookBackWindowDtoUnitJsonConverter(),
                    new global::Novu.JsonConverters.LookBackWindowDtoUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestControlDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.DigestControlDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.DigestControlDtoUnitJsonConverter(),
                    new global::Novu.JsonConverters.DigestControlDtoUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.ThrottleControlDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.ThrottleControlDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.ThrottleControlDtoUnitJsonConverter(),
                    new global::Novu.JsonConverters.ThrottleControlDtoUnitNullableJsonConverter(),
                    new global::Novu.JsonConverters.HttpMethodEnumJsonConverter(),
                    new global::Novu.JsonConverters.HttpMethodEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowStatusEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowResponseDtoStepDiscriminatorTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowCreationSourceEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeJsonConverter(),
                    new global::Novu.JsonConverters.UpdateWorkflowDtoStepDiscriminatorTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowResponseDtoSortFieldJsonConverter(),
                    new global::Novu.JsonConverters.WorkflowResponseDtoSortFieldNullableJsonConverter(),
                    new global::Novu.JsonConverters.TimeUnitEnumJsonConverter(),
                    new global::Novu.JsonConverters.TimeUnitEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant2TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant3TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant4TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant5TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant6TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant7TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant8TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeJsonConverter(),
                    new global::Novu.JsonConverters.GeneratePreviewResponseDtoResultVariant9TypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.SyncActionEnumJsonConverter(),
                    new global::Novu.JsonConverters.SyncActionEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.DiffActionEnumJsonConverter(),
                    new global::Novu.JsonConverters.DiffActionEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.DependencyReasonEnumJsonConverter(),
                    new global::Novu.JsonConverters.DependencyReasonEnumNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelConnectionResponseDtoChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelConnectionResponseDtoProviderIdNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateSlackChannelEndpointDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateSlackUserEndpointDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateWebhookEndpointDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreatePhoneEndpointDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateMsTeamsChannelEndpointDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateMsTeamsUserEndpointDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelEndpointResponseDtoChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelEndpointResponseDtoProviderIdNullableJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeJsonConverter(),
                    new global::Novu.JsonConverters.GetChannelEndpointResponseDtoTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.CreateTranslationRequestDtoResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationResponseDtoResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationResponseDtoResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationGroupDtoResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationGroupDtoResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.EventBodyStatusJsonConverter(),
                    new global::Novu.JsonConverters.EventBodyStatusNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageDtoWebhookPayloadWrapperObjectNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectJsonConverter(),
                    new global::Novu.JsonConverters.WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter(),
                    new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter(),
                    new global::Novu.JsonConverters.WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter(),
                    new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter(),
                    new global::Novu.JsonConverters.WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeJsonConverter(),
                    new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectJsonConverter(),
                    new global::Novu.JsonConverters.WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter(),
                    new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectJsonConverter(),
                    new global::Novu.JsonConverters.WebhookPreferenceDtoWebhookPayloadWrapperObjectNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerUploadTranslationFilesRequestResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.ContextsControllerListContextsOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerSearchSubscribersOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerListSubscriberTopicsOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerGetSubscriberNotificationsSeverityItemNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerCompleteNotificationActionActionTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeJsonConverter(),
                    new global::Novu.JsonConverters.SubscribersControllerRevertNotificationActionActionTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelJsonConverter(),
                    new global::Novu.JsonConverters.MessagesControllerDeleteMessagesByTransactionIdChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.TopicsControllerListTopicsOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelJsonConverter(),
                    new global::Novu.JsonConverters.ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionJsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsOrderDirectionNullableJsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelJsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerListChannelEndpointsChannelNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerGetTranslationGroupEndpointResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerGetSingleTranslationResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerDeleteTranslationEndpointResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeJsonConverter(),
                    new global::Novu.JsonConverters.TranslationControllerDeleteTranslationGroupEndpointResourceTypeNullableJsonConverter(),
                    new global::Novu.JsonConverters.StepsItemJsonConverter(),
                    new global::Novu.JsonConverters.StepsItem2JsonConverter(),
                    new global::Novu.JsonConverters.StepsItem3JsonConverter(),
                    new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestJsonConverter(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventRequestDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.SubscriberPayloadDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TenantPayloadDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TriggerEventToAllRequestDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.GenerateChatOauthUrlRequestDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Novu.EmailBlock>, string>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.BulkUpdateSubscriberPreferencesDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PatchSubscriberPreferencesDtoContext2>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>(),
                    new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.TopicSubscriberIdentifierDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateTopicSubscriptionsRequestDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.DeleteTopicSubscriberIdentifierDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.InAppControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.EmailControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SmsControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.PushControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ChatControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DelayControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.ThrottleControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.CustomControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.HttpRequestControlDto, object>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.PreviewPayloadDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<object, global::Novu.GeneratePreviewResponseDtoResultVariant2, global::Novu.GeneratePreviewResponseDtoResultVariant3, global::Novu.GeneratePreviewResponseDtoResultVariant4, global::Novu.GeneratePreviewResponseDtoResultVariant5, global::Novu.GeneratePreviewResponseDtoResultVariant6, global::Novu.GeneratePreviewResponseDtoResultVariant7, global::Novu.GeneratePreviewResponseDtoResultVariant8, global::Novu.GeneratePreviewResponseDtoResultVariant9>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateChannelConnectionRequestDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackChannelEndpointDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateSlackUserEndpointDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateWebhookEndpointDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreatePhoneEndpointDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsChannelEndpointDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<string, global::Novu.CreateMsTeamsUserEndpointDtoContext2>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>(),
                    new global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto>(),
                    new global::Novu.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public ActivityClient Activity => new ActivityClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChannelConnectionsClient ChannelConnections => new ChannelConnectionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsClient ChannelEndpoints => new ChannelEndpointsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ContextsClient Contexts => new ContextsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariablesClient EnvironmentVariables => new EnvironmentVariablesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Environments allow you to manage different stages of your application development lifecycle. Each environment has its own set of API keys and configurations, enabling you to separate development, staging, and production workflows.
        /// </summary>
        public EnvironmentsClient Environments => new EnvironmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Events represent a change in state of a subscriber. They are used to trigger workflows, and enable you to send notifications to subscribers based on their actions.
        /// </summary>
        public EventsClient Events => new EventsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// With the help of the Integration Store, you can easily integrate your favorite delivery provider. During the runtime of the API, the Integrations Store is responsible for storing the configurations of all the providers.
        /// </summary>
        public IntegrationsClient Integrations => new IntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Layouts are reusable wrappers for your email notifications.
        /// </summary>
        public LayoutsClient Layouts => new LayoutsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// A message in Novu represents a notification delivered to a recipient on a particular channel. Messages contain information about the request that triggered its delivery, a view of the data sent to the recipient, and a timeline of its lifecycle events. Learn more about messages.
        /// </summary>
        public MessagesClient Messages => new MessagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public NotificationsClient Notifications => new NotificationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// A subscriber in Novu represents someone who should receive a message. A subscriber's profile information contains important attributes about the subscriber that will be used in messages (name, email). The subscriber object can contain other key-value pairs that can be used to further personalize your messages.
        /// </summary>
        public SubscribersClient Subscribers => new SubscribersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Topics are a way to group subscribers together so that they can be notified of events at once. A topic is identified by a custom key. This can be helpful for things like sending out marketing emails or notifying users of new features. Topics can also be used to send notifications to the subscribers who have been grouped together based on their interests, location, activities and much more.
        /// </summary>
        public TopicsClient Topics => new TopicsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Used to localize your notifications to different languages.
        /// </summary>
        public TranslationsClient Translations => new TranslationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// All notifications are sent via a workflow. Each workflow acts as a container for the logic and blueprint that are associated with a type of notification in your system.
        /// </summary>
        public WorkflowsClient Workflows => new WorkflowsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the NovuClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public NovuClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Novu.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Novu.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}