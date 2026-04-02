#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public class StepsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.StepsItem2>
    {
        /// <inheritdoc />
        public override global::Novu.StepsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CreateWorkflowDtoStepDiscriminator>(ref readerCopy, options);

            global::Novu.InAppStepUpsertDto? inApp = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.InApp)
            {
                inApp = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.InAppStepUpsertDto>(ref reader, options);
            }
            global::Novu.EmailStepUpsertDto? email = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Email)
            {
                email = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.EmailStepUpsertDto>(ref reader, options);
            }
            global::Novu.SmsStepUpsertDto? sms = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.SmsStepUpsertDto>(ref reader, options);
            }
            global::Novu.PushStepUpsertDto? push = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Push)
            {
                push = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.PushStepUpsertDto>(ref reader, options);
            }
            global::Novu.ChatStepUpsertDto? chat = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Chat)
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.ChatStepUpsertDto>(ref reader, options);
            }
            global::Novu.DelayStepUpsertDto? delay = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Delay)
            {
                delay = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.DelayStepUpsertDto>(ref reader, options);
            }
            global::Novu.DigestStepUpsertDto? digest = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Digest)
            {
                digest = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.DigestStepUpsertDto>(ref reader, options);
            }
            global::Novu.ThrottleStepUpsertDto? throttle = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Throttle)
            {
                throttle = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.ThrottleStepUpsertDto>(ref reader, options);
            }
            global::Novu.CustomStepUpsertDto? custom = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Custom)
            {
                custom = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CustomStepUpsertDto>(ref reader, options);
            }
            global::Novu.HttpRequestStepUpsertDto? httpRequest = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.HttpRequest)
            {
                httpRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.HttpRequestStepUpsertDto>(ref reader, options);
            }

            var __value = new global::Novu.StepsItem2(
                discriminator?.Type,
                inApp,

                email,

                sms,

                push,

                chat,

                delay,

                digest,

                throttle,

                custom,

                httpRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.StepsItem2 value,
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
            else if (value.IsThrottle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttle, typeof(global::Novu.ThrottleStepUpsertDto), options);
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