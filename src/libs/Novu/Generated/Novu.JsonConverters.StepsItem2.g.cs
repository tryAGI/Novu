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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CreateWorkflowDtoStepDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CreateWorkflowDtoStepDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CreateWorkflowDtoStepDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Novu.InAppStepUpsertDto? inApp = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.InApp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.InAppStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.InAppStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.InAppStepUpsertDto)}");
                inApp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.EmailStepUpsertDto? email = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Email)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.EmailStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.EmailStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.EmailStepUpsertDto)}");
                email = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.SmsStepUpsertDto? sms = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.SmsStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.SmsStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.SmsStepUpsertDto)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.PushStepUpsertDto? push = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Push)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.PushStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.PushStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.PushStepUpsertDto)}");
                push = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.ChatStepUpsertDto? chat = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ChatStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ChatStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.ChatStepUpsertDto)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.DelayStepUpsertDto? delay = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Delay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DelayStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DelayStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.DelayStepUpsertDto)}");
                delay = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.DigestStepUpsertDto? digest = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Digest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DigestStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DigestStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.DigestStepUpsertDto)}");
                digest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.ThrottleStepUpsertDto? throttle = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Throttle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ThrottleStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ThrottleStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.ThrottleStepUpsertDto)}");
                throttle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.CustomStepUpsertDto? custom = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CustomStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CustomStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.CustomStepUpsertDto)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Novu.HttpRequestStepUpsertDto? httpRequest = default;
            if (discriminator?.Type == global::Novu.CreateWorkflowDtoStepDiscriminatorType.HttpRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.HttpRequestStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.HttpRequestStepUpsertDto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Novu.HttpRequestStepUpsertDto)}");
                httpRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInApp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.InAppStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.InAppStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.InAppStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InApp!, typeInfo);
            }
            else if (value.IsEmail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.EmailStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.EmailStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.EmailStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email!, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.SmsStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.SmsStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.SmsStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms!, typeInfo);
            }
            else if (value.IsPush)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.PushStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.PushStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.PushStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Push!, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ChatStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ChatStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.ChatStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat!, typeInfo);
            }
            else if (value.IsDelay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DelayStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DelayStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.DelayStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delay!, typeInfo);
            }
            else if (value.IsDigest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.DigestStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.DigestStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.DigestStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Digest!, typeInfo);
            }
            else if (value.IsThrottle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.ThrottleStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.ThrottleStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.ThrottleStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttle!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.CustomStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.CustomStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.CustomStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsHttpRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Novu.HttpRequestStepUpsertDto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Novu.HttpRequestStepUpsertDto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Novu.HttpRequestStepUpsertDto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HttpRequest!, typeInfo);
            }
        }
    }
}