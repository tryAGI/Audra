#nullable enable

namespace Audra.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetHealthResponseTtsG2pEngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audra.GetHealthResponseTtsG2pEngine>
    {
        /// <inheritdoc />
        public override global::Audra.GetHealthResponseTtsG2pEngine Read(
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
                        return global::Audra.GetHealthResponseTtsG2pEngineExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audra.GetHealthResponseTtsG2pEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audra.GetHealthResponseTtsG2pEngine);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audra.GetHealthResponseTtsG2pEngine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audra.GetHealthResponseTtsG2pEngineExtensions.ToValueString(value));
        }
    }
}
