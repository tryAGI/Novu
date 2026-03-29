#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class DelayRegularMetadataUnitJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.DelayRegularMetadataUnit>
    {
        /// <inheritdoc />
        public override global::Novu.DelayRegularMetadataUnit Read(
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
                        return global::Novu.DelayRegularMetadataUnitExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.DelayRegularMetadataUnit)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.DelayRegularMetadataUnit);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.DelayRegularMetadataUnit value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.DelayRegularMetadataUnitExtensions.ToValueString(value));
        }
    }
}
