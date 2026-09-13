
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_1c828e943cdd55e4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>), TypeInfoPropertyName = "ToolWebhookEndpointDto_0ad4135aa31c63dd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.MsTeamsChannelEndpointDto, global::Novu.MsTeamsUserEndpointDto, global::Novu.TelegramChatEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.LineUserEndpointDto, global::Novu.PagerDutyServiceEndpointDto, global::Novu.OpsgenieIntegrationEndpointDto, global::Novu.GrafanaOnCallIntegrationEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_c8c997b666659e86")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<global::Novu.SlackChannelEndpointDto, global::Novu.SlackUserEndpointDto, global::Novu.WebhookEndpointDto, global::Novu.PhoneEndpointDto, global::Novu.WebexRoomEndpointDto, global::Novu.WebexPersonEndpointDto, global::Novu.ToolWebhookEndpointDto>?), TypeInfoPropertyName = "ToolWebhookEndpointDto_0421199e9dafb346")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ProvidersIdEnum), TypeInfoPropertyName = "ProvidersIdEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest), TypeInfoPropertyName = "ChannelEndpointsControllerCreateChannelEndpointRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType), TypeInfoPropertyName = "ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection), TypeInfoPropertyName = "ChannelEndpointsControllerListChannelEndpointsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel), TypeInfoPropertyName = "ChannelEndpointsControllerListChannelEndpointsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerGetChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerUpdateChannelEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.AnyOf<string, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ProvidersIdEnum?), TypeInfoPropertyName = "NullableProvidersIdEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest?), TypeInfoPropertyName = "NullableChannelEndpointsControllerCreateChannelEndpointRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType?), TypeInfoPropertyName = "NullableChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection?), TypeInfoPropertyName = "NullableChannelEndpointsControllerListChannelEndpointsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel?), TypeInfoPropertyName = "NullableChannelEndpointsControllerListChannelEndpointsChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Novu.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.AnyOf<string, double?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Novu.GetChannelEndpointResponseDto>))]
    internal sealed partial class ChannelEndpointsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelEndpointsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChannelEndpointsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChannelEndpointsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
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
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Novu.OneOf<string, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<global::Novu.AnyOf<string, double?, bool?, object>>>());
            options.Converters.Add(new global::Novu.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>());
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
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Novu.ProvidersIdEnum)

                    || typeToConvert == typeof(global::Novu.ProvidersIdEnum?)

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

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsOrderDirection?)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel)

                    || typeToConvert == typeof(global::Novu.ChannelEndpointsControllerListChannelEndpointsChannel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Novu.ProvidersIdEnum))
                {
                    return new global::Novu.JsonConverters.ProvidersIdEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ProvidersIdEnum?))
                {
                    return new global::Novu.JsonConverters.ProvidersIdEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType?))
                {
                    return new global::Novu.JsonConverters.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorTypeNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new ChannelEndpointsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}