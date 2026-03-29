#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscribersControllerSearchSubscribersOrderDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.SubscribersControllerSearchSubscribersOrderDirection>
    {
        /// <inheritdoc />
        public override global::Novu.SubscribersControllerSearchSubscribersOrderDirection Read(
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
                        return global::Novu.SubscribersControllerSearchSubscribersOrderDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.SubscribersControllerSearchSubscribersOrderDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.SubscribersControllerSearchSubscribersOrderDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.SubscribersControllerSearchSubscribersOrderDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.SubscribersControllerSearchSubscribersOrderDirectionExtensions.ToValueString(value));
        }
    }
}
