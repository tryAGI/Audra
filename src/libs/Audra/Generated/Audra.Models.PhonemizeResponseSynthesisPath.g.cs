
#nullable enable

namespace Audra
{
    /// <summary>
    /// phonemes — direct IPA synthesis; ipa_markup — lexicon [word](/ipa/) in input;<br/>
    /// text — normalized speakable text with runtime G2P.
    /// </summary>
    public enum PhonemizeResponseSynthesisPath
    {
        /// <summary>
        ///
        /// </summary>
        IpaMarkup,
        /// <summary>
        ///
        /// </summary>
        Phonemes,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhonemizeResponseSynthesisPathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhonemizeResponseSynthesisPath value)
        {
            return value switch
            {
                PhonemizeResponseSynthesisPath.IpaMarkup => "ipa_markup",
                PhonemizeResponseSynthesisPath.Phonemes => "phonemes",
                PhonemizeResponseSynthesisPath.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhonemizeResponseSynthesisPath? ToEnum(string value)
        {
            return value switch
            {
                "ipa_markup" => PhonemizeResponseSynthesisPath.IpaMarkup,
                "phonemes" => PhonemizeResponseSynthesisPath.Phonemes,
                "text" => PhonemizeResponseSynthesisPath.Text,
                _ => null,
            };
        }
    }
}