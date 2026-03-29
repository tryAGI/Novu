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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.WorkflowResponseDtoStepDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.WorkflowResponseDtoStepDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.WorkflowResponseDtoStepDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Novu.InAppStepResponseDto? inApp = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.InApp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.InAppStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.InAppStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.InAppStepResponseDto)}");
                inApp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.EmailStepResponseDto? email = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Email)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.EmailStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.EmailStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.EmailStepResponseDto)}");
                email = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.SmsStepResponseDto? sms = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.SmsStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.SmsStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.SmsStepResponseDto)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.PushStepResponseDto? push = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Push)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.PushStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.PushStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.PushStepResponseDto)}");
                push = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.ChatStepResponseDto? chat = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ChatStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ChatStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.ChatStepResponseDto)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.DelayStepResponseDto? delay = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Delay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DelayStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DelayStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.DelayStepResponseDto)}");
                delay = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.DigestStepResponseDto? digest = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Digest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DigestStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DigestStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.DigestStepResponseDto)}");
                digest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CustomStepResponseDto? custom = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CustomStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CustomStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CustomStepResponseDto)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.ThrottleStepResponseDto? throttle = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.Throttle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ThrottleStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ThrottleStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.ThrottleStepResponseDto)}");
                throttle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.HttpRequestStepResponseDto? httpRequest = default;
            if (discriminator?.Type == global::Novu.WorkflowResponseDtoStepDiscriminatorType.HttpRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.HttpRequestStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.HttpRequestStepResponseDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.HttpRequestStepResponseDto)}");
                httpRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInApp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.InAppStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.InAppStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.InAppStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InApp, typeInfo);
            }
            else if (value.IsEmail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.EmailStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.EmailStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.EmailStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.SmsStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.SmsStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.SmsStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeInfo);
            }
            else if (value.IsPush)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.PushStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.PushStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.PushStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Push, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ChatStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ChatStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.ChatStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsDelay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DelayStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DelayStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.DelayStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delay, typeInfo);
            }
            else if (value.IsDigest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DigestStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DigestStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.DigestStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Digest, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CustomStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CustomStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CustomStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeInfo);
            }
            else if (value.IsThrottle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ThrottleStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ThrottleStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.ThrottleStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttle, typeInfo);
            }
            else if (value.IsHttpRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.HttpRequestStepResponseDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.HttpRequestStepResponseDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.HttpRequestStepResponseDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HttpRequest, typeInfo);
            }
        }
    }
}