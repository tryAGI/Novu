#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public class StepsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.StepsItem3>
    {
        /// <inheritdoc />
        public override global::Novu.StepsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.UpdateWorkflowDtoStepDiscriminator>(ref readerCopy, options);

            global::Novu.InAppStepUpsertDto? inApp = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.InApp)
            {
                inApp = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.InAppStepUpsertDto>(ref reader, options);
            }
            global::Novu.EmailStepUpsertDto? email = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Email)
            {
                email = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.EmailStepUpsertDto>(ref reader, options);
            }
            global::Novu.SmsStepUpsertDto? sms = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.SmsStepUpsertDto>(ref reader, options);
            }
            global::Novu.PushStepUpsertDto? push = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Push)
            {
                push = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.PushStepUpsertDto>(ref reader, options);
            }
            global::Novu.ChatStepUpsertDto? chat = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Chat)
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.ChatStepUpsertDto>(ref reader, options);
            }
            global::Novu.DelayStepUpsertDto? delay = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Delay)
            {
                delay = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.DelayStepUpsertDto>(ref reader, options);
            }
            global::Novu.DigestStepUpsertDto? digest = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Digest)
            {
                digest = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.DigestStepUpsertDto>(ref reader, options);
            }
            global::Novu.CustomStepUpsertDto? custom = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.Custom)
            {
                custom = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CustomStepUpsertDto>(ref reader, options);
            }
            global::Novu.HttpRequestStepUpsertDto? httpRequest = default;
            if (discriminator?.Type == global::Novu.UpdateWorkflowDtoStepDiscriminatorType.HttpRequest)
            {
                httpRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.HttpRequestStepUpsertDto>(ref reader, options);
            }

            var __value = new global::Novu.StepsItem3(
                discriminator?.Type,
                inApp,

                email,

                sms,

                push,

                chat,

                delay,

                digest,

                custom,

                httpRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.StepsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInApp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InApp, typeof(global::Novu.InAppStepUpsertDto), options);
            }
            else if (value.IsEmail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email, typeof(global::Novu.EmailStepUpsertDto), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::Novu.SmsStepUpsertDto), options);
            }
            else if (value.IsPush)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Push, typeof(global::Novu.PushStepUpsertDto), options);
            }
            else if (value.IsChat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeof(global::Novu.ChatStepUpsertDto), options);
            }
            else if (value.IsDelay)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delay, typeof(global::Novu.DelayStepUpsertDto), options);
            }
            else if (value.IsDigest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Digest, typeof(global::Novu.DigestStepUpsertDto), options);
            }
            else if (value.IsCustom)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeof(global::Novu.CustomStepUpsertDto), options);
            }
            else if (value.IsHttpRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HttpRequest, typeof(global::Novu.HttpRequestStepUpsertDto), options);
            }
        }
    }
}