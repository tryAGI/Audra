
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhonemizeResponse
    {
        /// <summary>
        /// Text after normalization and pronunciation lexicon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phonemes")]
        public string? Phonemes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_phonemes")]
        public bool? IsPhonemes { get; set; }

        /// <summary>
        /// Active G2P backend (e.g. audra-phonetics)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("british")]
        public bool? British { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_key")]
        public string? VoiceKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_ipa_markup")]
        public bool? SupportsIpaMarkup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemizeResponse" /> class.
        /// </summary>
        /// <param name="input">
        /// Text after normalization and pronunciation lexicon
        /// </param>
        /// <param name="phonemes"></param>
        /// <param name="isPhonemes"></param>
        /// <param name="backend">
        /// Active G2P backend (e.g. audra-phonetics)
        /// </param>
        /// <param name="british"></param>
        /// <param name="voiceKey"></param>
        /// <param name="supportsIpaMarkup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhonemizeResponse(
            string? input,
            string? phonemes,
            bool? isPhonemes,
            string? backend,
            bool? british,
            string? voiceKey,
            bool? supportsIpaMarkup)
        {
            this.Input = input;
            this.Phonemes = phonemes;
            this.IsPhonemes = isPhonemes;
            this.Backend = backend;
            this.British = british;
            this.VoiceKey = voiceKey;
            this.SupportsIpaMarkup = supportsIpaMarkup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemizeResponse" /> class.
        /// </summary>
        public PhonemizeResponse()
        {
        }

    }
}