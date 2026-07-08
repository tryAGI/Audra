#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class SpeechCreateSpeechCommandApiCommand
{
    private static Option<string?> IdempotencyKey { get; } = new(
        name: @"--idempotency-key")
    {
        Description = @"Optional idempotency key. When omitted, the SDK generates one for this request.",
    };

    private static Option<global::Audra.CreateSpeechXAudraCommercialUse?> XAudraCommercialUse { get; } = new(
        name: @"--x-audra-commercial-use")
    {
        Description = @"",
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"Plain text, SSML subset, Audra pause tags (`[pause:1.5s]`),
or inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.
",
        Required = true,
    };

    private static Option<string?> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"Voice slug (june, clara, arthur, …) or weighted mix e.g. `june(2)+wren(1)`.
Premium packs use product slugs (e.g. aurora-lead) when enabled.
",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"",
    };

    private static Option<global::Audra.SpeechRequestFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"",
    };

    private static Option<global::Audra.SpeechRequestDeliveryProfile?> DeliveryProfile { get; } = new(
        name: @"--delivery-profile")
    {
        Description = @"Podcast pacing profile (slower speed + paragraph/sentence pauses)",
    };

    private static Option<bool?> Normalize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--normalize",
        description: @"When true (default), normalize URLs, emails, currency, and percent signs before synthesis.
Set false to pass text through unchanged (except pronunciation lexicon).
");

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"BCP-47 language code for the requested voice. When omitted the service
infers the language from the voice slug prefix (en-us, en-gb, ja, zh,
es, pt-br, hi, it, fr-fr, de, nl). Provide this field explicitly when
using designed/community voices that don't carry an unambiguous prefix,
or when you want to force a specific G2P backend regardless of voice name.
",
    };

    private static Option<global::Audra.SpeechRequestRenderMode?> RenderMode { get; } = new(
        name: @"--render-mode")
    {
        Description = @"`fast` (default) = Modal GPU. `standard` = Modal CPU.
Aliases `gpu` / `cpu` accepted.
",
    };

    private static Option<global::Audra.SpeechRequestMode?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"`standard` — default queue placement. `fast` — queue priority, 1.25× credits.
`economy` (0.75× credits, deferred) exists but is **not valid here** — it is
only accepted on `POST /v2/speech/jobs` (async). Sending `mode: ""economy""`
or `economy: true` on this synchronous endpoint returns 400.
",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"create-speech", @"Synthesize speech");
                        command.Options.Add(IdempotencyKey);
                        command.Options.Add(XAudraCommercialUse);
                        command.Options.Add(Model);
                        command.Options.Add(Text);
                        command.Options.Add(Voice);
                        command.Options.Add(Speed);
                        command.Options.Add(Format);
                        command.Options.Add(DeliveryProfile);
                        command.Options.Add(Normalize);
                        command.Options.Add(Language);
                        command.Options.Add(RenderMode);
                        command.Options.Add(Mode);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Audra.SpeechRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Audra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var idempotencyKey = parseResult.GetValue(IdempotencyKey);
                        var xAudraCommercialUse = parseResult.GetValue(XAudraCommercialUse);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var text = parseResult.GetRequiredValue(Text);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var deliveryProfile = CliRuntime.WasSpecified(parseResult, DeliveryProfile) ? parseResult.GetValue(DeliveryProfile) : (__requestBase is { } __DeliveryProfileBaseValue ? __DeliveryProfileBaseValue.DeliveryProfile : default);
                        var normalize = CliRuntime.WasSpecified(parseResult, Normalize) ? parseResult.GetValue(Normalize) : (__requestBase is { } __NormalizeBaseValue ? __NormalizeBaseValue.Normalize : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var renderMode = CliRuntime.WasSpecified(parseResult, RenderMode) ? parseResult.GetValue(RenderMode) : (__requestBase is { } __RenderModeBaseValue ? __RenderModeBaseValue.RenderMode : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Speech.CreateSpeechAsync(
                                    idempotencyKey: idempotencyKey,
                                    xAudraCommercialUse: xAudraCommercialUse,
                                    model: model,
                                    text: text,
                                    voice: voice,
                                    speed: speed,
                                    format: format,
                                    deliveryProfile: deliveryProfile,
                                    normalize: normalize,
                                    language: language,
                                    renderMode: renderMode,
                                    mode: mode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}