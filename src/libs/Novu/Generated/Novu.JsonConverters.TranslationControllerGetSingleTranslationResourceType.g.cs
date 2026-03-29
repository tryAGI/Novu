#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranslationControllerGetSingleTranslationResourceTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.TranslationControllerGetSingleTranslationResourceType>
    {
        /// <inheritdoc />
        public override global::Novu.TranslationControllerGetSingleTranslationResourceType Read(
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
                        return global::Novu.TranslationControllerGetSingleTranslationResourceTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.TranslationControllerGetSingleTranslationResourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.TranslationControllerGetSingleTranslationResourceType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.TranslationControllerGetSingleTranslationResourceType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.TranslationControllerGetSingleTranslationResourceTypeExtensions.ToValueString(value));
        }
    }
}
