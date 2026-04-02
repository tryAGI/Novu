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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminator>(ref readerCopy, options);

            global::Novu.CreateSlackChannelEndpointDto? slackChannel = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackChannel)
            {
                slackChannel = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreateSlackChannelEndpointDto>(ref reader, options);
            }
            global::Novu.CreateSlackUserEndpointDto? slackUser = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.SlackUser)
            {
                slackUser = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreateSlackUserEndpointDto>(ref reader, options);
            }
            global::Novu.CreateWebhookEndpointDto? webhook = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreateWebhookEndpointDto>(ref reader, options);
            }
            global::Novu.CreatePhoneEndpointDto? phone = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.Phone)
            {
                phone = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreatePhoneEndpointDto>(ref reader, options);
            }
            global::Novu.CreateMsTeamsChannelEndpointDto? msTeamsChannel = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsChannel)
            {
                msTeamsChannel = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreateMsTeamsChannelEndpointDto>(ref reader, options);
            }
            global::Novu.CreateMsTeamsUserEndpointDto? msTeamsUser = default;
            if (discriminator?.Type == global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType.MsTeamsUser)
            {
                msTeamsUser = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreateMsTeamsUserEndpointDto>(ref reader, options);
            }

            var __value = new global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequest(
                discriminator?.Type,
                slackChannel,

                slackUser,

                webhook,

                phone,

                msTeamsChannel,

                msTeamsUser
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

            if (value.IsSlackChannel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannel, typeof(global::Novu.CreateSlackChannelEndpointDto), options);
            }
            else if (value.IsSlackUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackUser, typeof(global::Novu.CreateSlackUserEndpointDto), options);
            }
            else if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::Novu.CreateWebhookEndpointDto), options);
            }
            else if (value.IsPhone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phone, typeof(global::Novu.CreatePhoneEndpointDto), options);
            }
            else if (value.IsMsTeamsChannel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MsTeamsChannel, typeof(global::Novu.CreateMsTeamsChannelEndpointDto), options);
            }
            else if (value.IsMsTeamsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MsTeamsUser, typeof(global::Novu.CreateMsTeamsUserEndpointDto), options);
            }
        }
    }
}