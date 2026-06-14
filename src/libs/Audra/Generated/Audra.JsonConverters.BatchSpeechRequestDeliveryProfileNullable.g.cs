#nullable enable

namespace Audra.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchSpeechRequestDeliveryProfileNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audra.BatchSpeechRequestDeliveryProfile?>
    {
        /// <inheritdoc />
        public override global::Audra.BatchSpeechRequestDeliveryProfile? Read(
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
                        return global::Audra.BatchSpeechRequestDeliveryProfileExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audra.BatchSpeechRequestDeliveryProfile)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audra.BatchSpeechRequestDeliveryProfile?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audra.BatchSpeechRequestDeliveryProfile? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audra.BatchSpeechRequestDeliveryProfileExtensions.ToValueString(value.Value));
            }
        }
    }
}
