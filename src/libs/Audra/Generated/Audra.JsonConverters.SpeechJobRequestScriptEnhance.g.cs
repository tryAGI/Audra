#nullable enable

namespace Audra.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechJobRequestScriptEnhanceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audra.SpeechJobRequestScriptEnhance>
    {
        /// <inheritdoc />
        public override global::Audra.SpeechJobRequestScriptEnhance Read(
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
                        return global::Audra.SpeechJobRequestScriptEnhanceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audra.SpeechJobRequestScriptEnhance)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audra.SpeechJobRequestScriptEnhance);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audra.SpeechJobRequestScriptEnhance value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audra.SpeechJobRequestScriptEnhanceExtensions.ToValueString(value));
        }
    }
}
