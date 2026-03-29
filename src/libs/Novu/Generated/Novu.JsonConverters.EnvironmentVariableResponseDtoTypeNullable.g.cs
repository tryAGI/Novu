#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentVariableResponseDtoTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.EnvironmentVariableResponseDtoType?>
    {
        /// <inheritdoc />
        public override global::Novu.EnvironmentVariableResponseDtoType? Read(
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
                        return global::Novu.EnvironmentVariableResponseDtoTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.EnvironmentVariableResponseDtoType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.EnvironmentVariableResponseDtoType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.EnvironmentVariableResponseDtoType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.EnvironmentVariableResponseDtoTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
