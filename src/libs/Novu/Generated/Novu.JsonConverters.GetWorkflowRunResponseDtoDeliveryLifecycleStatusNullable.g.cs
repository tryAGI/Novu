#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWorkflowRunResponseDtoDeliveryLifecycleStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus?>
    {
        /// <inheritdoc />
        public override global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.GetWorkflowRunResponseDtoDeliveryLifecycleStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
