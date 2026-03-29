#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteMessageResponseDtoStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.DeleteMessageResponseDtoStatus?>
    {
        /// <inheritdoc />
        public override global::Novu.DeleteMessageResponseDtoStatus? Read(
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
                        return global::Novu.DeleteMessageResponseDtoStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.DeleteMessageResponseDtoStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.DeleteMessageResponseDtoStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.DeleteMessageResponseDtoStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.DeleteMessageResponseDtoStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
