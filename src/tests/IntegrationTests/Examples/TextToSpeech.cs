/*
order: 10
title: Text To Speech
slug: text-to-speech

Basic example showing how to synthesize speech with Audra's native v2 API.
*/

namespace Audra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        var audio = await client.Speech.CreateSpeechAsync(new SpeechRequest
        {
            Model = "audra-core",
            Text = "Hello from Audra.",
            Voice = "june",
            Format = SpeechRequestFormat.Mp3,
        });

        audio.Should().NotBeEmpty();
    }
}
