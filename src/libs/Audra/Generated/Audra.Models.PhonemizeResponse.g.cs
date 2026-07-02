
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhonemizeResponse
    {
        /// <summary>
        /// Text after normalization and pronunciation lexicon — what synthesis speaks from.<br/>
        /// When is_phonemes is true, this is the IPA phoneme string passed to the Essential engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// IPA phoneme string when is_phonemes is true. Null on the text path — G2P still runs<br/>
        /// inside synthesis; null does not mean phonemization was skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phonemes")]
        public string? Phonemes { get; set; }

        /// <summary>
        /// True when input is an IPA phoneme string for direct synthesis. False when input is<br/>
        /// normalized text and G2P runs during render.
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
        /// True when Essential inline [word](/ipa/) markup is supported on this worker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_ipa_markup")]
        public bool? SupportsIpaMarkup { get; set; }

        /// <summary>
        /// True when input contains inline IPA markup from the pronunciation lexicon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_ipa_markup")]
        public bool? HasIpaMarkup { get; set; }

        /// <summary>
        /// True when Audra phonetics G2P emitted an unknown-token marker (❓). When true, do not ship<br/>
        /// audio until lexicon or script is fixed; synthesis may fall back to espeak.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unknown_phonemes")]
        public bool? HasUnknownPhonemes { get; set; }

        /// <summary>
        /// phonemes — direct IPA synthesis; ipa_markup — lexicon [word](/ipa/) in input;<br/>
        /// text — normalized speakable text with runtime G2P.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesis_path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.PhonemizeResponseSynthesisPathJsonConverter))]
        public global::Audra.PhonemizeResponseSynthesisPath? SynthesisPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemizeResponse" /> class.
        /// </summary>
        /// <param name="input">
        /// Text after normalization and pronunciation lexicon — what synthesis speaks from.<br/>
        /// When is_phonemes is true, this is the IPA phoneme string passed to the Essential engine.
        /// </param>
        /// <param name="phonemes">
        /// IPA phoneme string when is_phonemes is true. Null on the text path — G2P still runs<br/>
        /// inside synthesis; null does not mean phonemization was skipped.
        /// </param>
        /// <param name="isPhonemes">
        /// True when input is an IPA phoneme string for direct synthesis. False when input is<br/>
        /// normalized text and G2P runs during render.
        /// </param>
        /// <param name="backend">
        /// Active G2P backend (e.g. audra-phonetics)
        /// </param>
        /// <param name="british"></param>
        /// <param name="voiceKey"></param>
        /// <param name="supportsIpaMarkup">
        /// True when Essential inline [word](/ipa/) markup is supported on this worker.
        /// </param>
        /// <param name="hasIpaMarkup">
        /// True when input contains inline IPA markup from the pronunciation lexicon.
        /// </param>
        /// <param name="hasUnknownPhonemes">
        /// True when Audra phonetics G2P emitted an unknown-token marker (❓). When true, do not ship<br/>
        /// audio until lexicon or script is fixed; synthesis may fall back to espeak.
        /// </param>
        /// <param name="synthesisPath">
        /// phonemes — direct IPA synthesis; ipa_markup — lexicon [word](/ipa/) in input;<br/>
        /// text — normalized speakable text with runtime G2P.
        /// </param>
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
            bool? supportsIpaMarkup,
            bool? hasIpaMarkup,
            bool? hasUnknownPhonemes,
            global::Audra.PhonemizeResponseSynthesisPath? synthesisPath)
        {
            this.Input = input;
            this.Phonemes = phonemes;
            this.IsPhonemes = isPhonemes;
            this.Backend = backend;
            this.British = british;
            this.VoiceKey = voiceKey;
            this.SupportsIpaMarkup = supportsIpaMarkup;
            this.HasIpaMarkup = hasIpaMarkup;
            this.HasUnknownPhonemes = hasUnknownPhonemes;
            this.SynthesisPath = synthesisPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemizeResponse" /> class.
        /// </summary>
        public PhonemizeResponse()
        {
        }

    }
}