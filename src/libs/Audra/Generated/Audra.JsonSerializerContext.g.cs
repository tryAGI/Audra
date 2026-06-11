
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

            typeof(global::Audra.JsonConverters.SpeechRequestRenderModeJsonConverter),

            typeof(global::Audra.JsonConverters.SpeechRequestRenderModeNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackJsonConverter),

            typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechXAudraCommercialUseJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechXAudraCommercialUseNullableJsonConverter),

            typeof(global::Audra.JsonConverters.GetHealthResponseTtsG2pEngineJsonConverter),

            typeof(global::Audra.JsonConverters.GetHealthResponseTtsG2pEngineNullableJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechJobsResponseStatusJsonConverter),

            typeof(global::Audra.JsonConverters.CreateSpeechJobsResponseStatusNullableJsonConverter),

            typeof(global::Audra.JsonConverters.AllOfJsonConverter<global::Audra.SpeechRequest, global::Audra.CreateSpeechJobsRequest2>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.SpeechRequestRenderMode), TypeInfoPropertyName = "SpeechRequestRenderMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateAccountsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutRequestPack), TypeInfoPropertyName = "CreateBillingCheckoutRequestPack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.AllOf<global::Audra.SpeechRequest, global::Audra.CreateSpeechJobsRequest2>), TypeInfoPropertyName = "AllOfSpeechRequestCreateSpeechJobsRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechJobsRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateAuthGoogleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateAccountsKeyRecoveryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateAccountsKeyRecoveryConfirmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechXAudraCommercialUse), TypeInfoPropertyName = "CreateSpeechXAudraCommercialUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetHealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetHealthResponseTts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetHealthResponseTtsG2p))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetHealthResponseTtsG2pEngine), TypeInfoPropertyName = "GetHealthResponseTtsG2pEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audra.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.GetModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateBillingCheckoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audra.CreateSpeechJobsResponseStatus), TypeInfoPropertyName = "CreateSpeechJobsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audra.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}