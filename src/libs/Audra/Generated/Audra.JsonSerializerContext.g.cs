
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

            typeof(global::Audra.JsonConverters.SpeechRequestRenderModeJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestRenderModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestModeJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestFormatJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestFormatNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestModeJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestDeliveryProfileJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestDeliveryProfileNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestAudioPostJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobRequestAudioPostNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobResponseModeJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobResponseModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobStatusResponseStatusJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobStatusResponseStatusNullableJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobStatusResponseModeJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechJobStatusResponseModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CaptionedSpeechRequestFormatJsonConverter),

            typeof(global::Audra.JsonConverters.CaptionedSpeechRequestFormatNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CaptionedSpeechRequestDeliveryProfileJsonConverter),

            typeof(global::Audra.JsonConverters.CaptionedSpeechRequestDeliveryProfileNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CaptionedSpeechRequestRenderModeJsonConverter),

            typeof(global::Audra.JsonConverters.CaptionedSpeechRequestRenderModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.PhonemizeRequestRenderModeJsonConverter),

            typeof(global::Audra.JsonConverters.PhonemizeRequestRenderModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.PhonemizeResponseSynthesisPathJsonConverter),

            typeof(global::Audra.JsonConverters.PhonemizeResponseSynthesisPathNullableJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSegmentEnergyJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSegmentEnergyNullableJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestFormatJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestFormatNullableJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestDeliveryProfileJsonConverter),

            typeof(global::Audra.JsonConverters.BatchSpeechRequestDeliveryProfileNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackJsonConverter),

            typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechXAudraCommercialUseJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechXAudraCommercialUseNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechCaptionedXAudraCommercialUseJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechCaptionedXAudraCommercialUseNullableJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechRequestRenderMode), TypeInfoPropertyName = "SpeechRequestRenderMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechRequestMode), TypeInfoPropertyName = "SpeechRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobRequestFormat), TypeInfoPropertyName = "SpeechJobRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobRequestMode), TypeInfoPropertyName = "SpeechJobRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobRequestDeliveryProfile), TypeInfoPropertyName = "SpeechJobRequestDeliveryProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobRequestAudioPost), TypeInfoPropertyName = "SpeechJobRequestAudioPost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobResponseMode), TypeInfoPropertyName = "SpeechJobResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobStatusResponseStatus), TypeInfoPropertyName = "SpeechJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechJobStatusResponseMode), TypeInfoPropertyName = "SpeechJobStatusResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CaptionedSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CaptionedSpeechRequestFormat), TypeInfoPropertyName = "CaptionedSpeechRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CaptionedSpeechRequestDeliveryProfile), TypeInfoPropertyName = "CaptionedSpeechRequestDeliveryProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CaptionedSpeechRequestRenderMode), TypeInfoPropertyName = "CaptionedSpeechRequestRenderMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.PhonemizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.PhonemizeRequestRenderMode), TypeInfoPropertyName = "PhonemizeRequestRenderMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.WordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CaptionsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.PhonemizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.PhonemizeResponseSynthesisPath), TypeInfoPropertyName = "PhonemizeResponseSynthesisPath2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSegmentEnergy), TypeInfoPropertyName = "BatchSegmentEnergy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSpeechRequestFormat), TypeInfoPropertyName = "BatchSpeechRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.BatchSpeechRequestDeliveryProfile), TypeInfoPropertyName = "BatchSpeechRequestDeliveryProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.BatchSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.LexiconEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.LexiconPutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.LexiconEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.LexiconResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.VoiceProbeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.PublicStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateAccountsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutRequestPack), TypeInfoPropertyName = "CreateBillingCheckoutRequestPack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechXAudraCommercialUse), TypeInfoPropertyName = "CreateSpeechXAudraCommercialUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechCaptionedXAudraCommercialUse), TypeInfoPropertyName = "CreateSpeechCaptionedXAudraCommercialUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechBatchXAudraCommercialUse), TypeInfoPropertyName = "CreateSpeechBatchXAudraCommercialUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetHealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.BatchSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.LexiconEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}