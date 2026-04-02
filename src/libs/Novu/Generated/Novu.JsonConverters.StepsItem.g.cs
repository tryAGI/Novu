#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public class StepsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.StepsItem>
    {
        /// <inheritdoc />
        public override global::Novu.StepsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.WorkflowResponseDtoStepDiscriminator>(ref readerCopy, options);

            global::Novu.InAppStepResponseDto? inApp = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.InApp)
            {
                inApp = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.InAppStepResponseDto>(ref reader, options);
            }
            global::Novu.EmailStepResponseDto? email = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Email)
            {
                email = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.EmailStepResponseDto>(ref reader, options);
            }
            global::Novu.SmsStepResponseDto? sms = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.SmsStepResponseDto>(ref reader, options);
            }
            global::Novu.PushStepResponseDto? push = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Push)
            {
                push = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.PushStepResponseDto>(ref reader, options);
            }
            global::Novu.ChatStepResponseDto? chat = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Chat)
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.ChatStepResponseDto>(ref reader, options);
            }
            global::Novu.DelayStepResponseDto? delay = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Delay)
            {
                delay = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.DelayStepResponseDto>(ref reader, options);
            }
            global::Novu.DigestStepResponseDto? digest = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Digest)
            {
                digest = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.DigestStepResponseDto>(ref reader, options);
            }
            global::Novu.CustomStepResponseDto? custom = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Custom)
            {
                custom = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.CustomStepResponseDto>(ref reader, options);
            }
            global::Novu.ThrottleStepResponseDto? throttle = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Throttle)
            {
                throttle = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.ThrottleStepResponseDto>(ref reader, options);
            }
            global::Novu.HttpRequestStepResponseDto? httpRequest = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.HttpRequest)
            {
                httpRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Novu.HttpRequestStepResponseDto>(ref reader, options);
            }

            var __value = new global::Novu.StepsItem(
                discriminator?.Type,
                inApp,

                email,

                sms,

                push,

                chat,

                delay,

                digest,

                custom,

                throttle,

                httpRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.StepsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInApp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InApp, typeof(global::Novu.InAppStepResponseDto), options);
            }
            else if (value.IsEmail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email, typeof(global::Novu.EmailStepResponseDto), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::Novu.SmsStepResponseDto), options);
            }
            else if (value.IsPush)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Push, typeof(global::Novu.PushStepResponseDto), options);
            }
            else if (value.IsChat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeof(global::Novu.ChatStepResponseDto), options);
            }
            else if (value.IsDelay)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delay, typeof(global::Novu.DelayStepResponseDto), options);
            }
            else if (value.IsDigest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Digest, typeof(global::Novu.DigestStepResponseDto), options);
            }
            else if (value.IsCustom)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeof(global::Novu.CustomStepResponseDto), options);
            }
            else if (value.IsThrottle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttle, typeof(global::Novu.ThrottleStepResponseDto), options);
            }
            else if (value.IsHttpRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HttpRequest, typeof(global::Novu.HttpRequestStepResponseDto), options);
            }
        }
    }
}