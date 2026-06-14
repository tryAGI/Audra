
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Audra.JsonConverters.SpeechRequestFormatJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestFormatNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestDeliveryProfileJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestDeliveryProfileNullableJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestFormatJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestFormatNullableJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestDeliveryProfileJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestDeliveryProfileNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackJsonConverter),

            typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechXAudraCommercialUseJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechXAudraCommercialUseNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechBatchXAudraCommercialUseJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechBatchXAudraCommercialUseNullableJsonConverter),

            typeof(global::Audra.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SignupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechRequestFormat), TypeInfoPropertyName = "SpeechRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechRequestDeliveryProfile), TypeInfoPropertyName = "SpeechRequestDeliveryProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSpeechRequestFormat), TypeInfoPropertyName = "BatchSpeechRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSpeechRequestDeliveryProfile), TypeInfoPropertyName = "BatchSpeechRequestDeliveryProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.BatchSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.PublicStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateAccountsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutRequestPack), TypeInfoPropertyName = "CreateBillingCheckoutRequestPack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechXAudraCommercialUse), TypeInfoPropertyName = "CreateSpeechXAudraCommercialUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechBatchXAudraCommercialUse), TypeInfoPropertyName = "CreateSpeechBatchXAudraCommercialUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetHealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.BatchSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}