#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class DomainDiagnosticIssueDtoCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.DomainDiagnosticIssueDtoCode?>
    {
        /// <inheritdoc />
        public override global::Novu.DomainDiagnosticIssueDtoCode? Read(
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
                        return global::Novu.DomainDiagnosticIssueDtoCodeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.DomainDiagnosticIssueDtoCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.DomainDiagnosticIssueDtoCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.DomainDiagnosticIssueDtoCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.DomainDiagnosticIssueDtoCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
