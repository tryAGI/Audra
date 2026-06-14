#nullable enable

namespace Audra.JsonConverters
{
    /// <inheritdoc />
    public sealed class CaptionedSpeechRequestDeliveryProfileJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audra.CaptionedSpeechRequestDeliveryProfile>
    {
        /// <inheritdoc />
        public override global::Audra.CaptionedSpeechRequestDeliveryProfile Read(
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
                        return global::Audra.CaptionedSpeechRequestDeliveryProfileExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audra.CaptionedSpeechRequestDeliveryProfile)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audra.CaptionedSpeechRequestDeliveryProfile);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audra.CaptionedSpeechRequestDeliveryProfile value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audra.CaptionedSpeechRequestDeliveryProfileExtensions.ToValueString(value));
        }
    }
}
