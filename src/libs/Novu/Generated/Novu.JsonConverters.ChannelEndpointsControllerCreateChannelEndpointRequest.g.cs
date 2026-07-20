#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public class ChannelEndpointsControllerCreateChannelEndpointRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest>
    {
        /// <inheritdoc />
        public override global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Novu.CreateSlackChannelEndpointDto? slackChannel = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateSlackChannelEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateSlackChannelEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateSlackChannelEndpointDto)}");
                slackChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateSlackUserEndpointDto? slackUser = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateSlackUserEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateSlackUserEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateSlackUserEndpointDto)}");
                slackUser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateWebhookEndpointDto? webhook = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWebhookEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWebhookEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateWebhookEndpointDto)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreatePhoneEndpointDto? phone = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Phone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreatePhoneEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreatePhoneEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreatePhoneEndpointDto)}");
                phone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateMsTeamsChannelEndpointDto? msTeamsChannel = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateMsTeamsChannelEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateMsTeamsChannelEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateMsTeamsChannelEndpointDto)}");
                msTeamsChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateMsTeamsUserEndpointDto? msTeamsUser = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateMsTeamsUserEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateMsTeamsUserEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateMsTeamsUserEndpointDto)}");
                msTeamsUser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateTelegramChatEndpointDto? telegramChat = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.TelegramChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateTelegramChatEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateTelegramChatEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateTelegramChatEndpointDto)}");
                telegramChat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateWebexRoomEndpointDto? webexRoom = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.WebexRoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWebexRoomEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWebexRoomEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateWebexRoomEndpointDto)}");
                webexRoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateWebexPersonEndpointDto? webexPerson = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.WebexPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWebexPersonEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWebexPersonEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateWebexPersonEndpointDto)}");
                webexPerson = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateLineUserEndpointDto? lineUser = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.LineUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateLineUserEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateLineUserEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateLineUserEndpointDto)}");
                lineUser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreatePagerDutyServiceEndpointDto? pagerdutyService = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.PagerdutyService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreatePagerDutyServiceEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreatePagerDutyServiceEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreatePagerDutyServiceEndpointDto)}");
                pagerdutyService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CreateOpsgenieIntegrationEndpointDto? opsgenieIntegration = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.OpsgenieIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateOpsgenieIntegrationEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateOpsgenieIntegrationEndpointDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateOpsgenieIntegrationEndpointDto)}");
                opsgenieIntegration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest(
                discriminator?.Type,
                slackChannel,

                slackUser,

                webhook,

                phone,

                msTeamsChannel,

                msTeamsUser,

                telegramChat,

                webexRoom,

                webexPerson,

                lineUser,

                pagerdutyService,

                opsgenieIntegration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateSlackChannelEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateSlackChannelEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateSlackChannelEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannel!, typeInfo);
            }
            else if (value.IsSlackUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateSlackUserEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateSlackUserEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateSlackUserEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackUser!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWebhookEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWebhookEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateWebhookEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreatePhoneEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreatePhoneEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreatePhoneEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phone!, typeInfo);
            }
            else if (value.IsMsTeamsChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateMsTeamsChannelEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateMsTeamsChannelEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateMsTeamsChannelEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MsTeamsChannel!, typeInfo);
            }
            else if (value.IsMsTeamsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateMsTeamsUserEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateMsTeamsUserEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateMsTeamsUserEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MsTeamsUser!, typeInfo);
            }
            else if (value.IsTelegramChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateTelegramChatEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateTelegramChatEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateTelegramChatEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TelegramChat!, typeInfo);
            }
            else if (value.IsWebexRoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWebexRoomEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWebexRoomEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateWebexRoomEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebexRoom!, typeInfo);
            }
            else if (value.IsWebexPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWebexPersonEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWebexPersonEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateWebexPersonEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebexPerson!, typeInfo);
            }
            else if (value.IsLineUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateLineUserEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateLineUserEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateLineUserEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LineUser!, typeInfo);
            }
            else if (value.IsPagerdutyService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreatePagerDutyServiceEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreatePagerDutyServiceEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreatePagerDutyServiceEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PagerdutyService!, typeInfo);
            }
            else if (value.IsOpsgenieIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateOpsgenieIntegrationEndpointDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateOpsgenieIntegrationEndpointDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CreateOpsgenieIntegrationEndpointDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpsgenieIntegration!, typeInfo);
            }
        }
    }
}