# Text To Speech

Basic example showing how to synthesize speech with Audra's native v2 API.

This example assumes `using Audra;` is in scope and `apiKey` contains your Audra API key.

```csharp
using var client = new AudraClient(apiKey);

var audio = await client.Speech.CreateSpeechAsync(new SpeechRequest
{
    Model = "audra-core",
    Text = "Hello from Audra.",
    Voice = "june",
    Format = SpeechRequestFormat.Mp3,
});
```