#nullable enable

namespace Audra.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSpeechXAudraCommercialUseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audra.CreateSpeechXAudraCommercialUse>
    {
        /// <inheritdoc />
        public override global::Audra.CreateSpeechXAudraCommercialUse Read(
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
                        return global::Audra.CreateSpeechXAudraCommercialUseExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audra.CreateSpeechXAudraCommercialUse)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audra.CreateSpeechXAudraCommercialUse);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audra.CreateSpeechXAudraCommercialUse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audra.CreateSpeechXAudraCommercialUseExtensions.ToValueString(value));
        }
    }
}
