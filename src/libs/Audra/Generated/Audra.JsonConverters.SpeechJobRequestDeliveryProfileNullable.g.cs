#nullable enable

namespace Audra.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechJobRequestDeliveryProfileNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audra.SpeechJobRequestDeliveryProfile?>
    {
        /// <inheritdoc />
        public override global::Audra.SpeechJobRequestDeliveryProfile? Read(
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
                        return global::Audra.SpeechJobRequestDeliveryProfileExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audra.SpeechJobRequestDeliveryProfile)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audra.SpeechJobRequestDeliveryProfile?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audra.SpeechJobRequestDeliveryProfile? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audra.SpeechJobRequestDeliveryProfileExtensions.ToValueString(value.Value));
            }
        }
    }
}
