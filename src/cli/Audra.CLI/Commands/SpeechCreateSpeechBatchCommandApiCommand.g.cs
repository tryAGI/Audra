#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class SpeechCreateSpeechBatchCommandApiCommand
{
    private static Option<string?> IdempotencyKey { get; } = new(
        name: @"--idempotency-key")
    {
        Description = @"Optional idempotency key. When omitted, the SDK generates one for this request.",
    };

    private static Option<global::Audra.CreateSpeechBatchXAudraCommercialUse?> XAudraCommercialUse { get; } = new(
        name: @"--x-audra-commercial-use")
    {
        Description = @"",
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
    };

    private static Option<string?> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"",
    };

    private static Option<int?> CrossfadeMs { get; } = new(
        name: @"--crossfade-ms")
    {
        Description = @"Crossfade duration between segments (ms). Pauses under 300ms use crossfade instead of inserted silence for smoother podcast beats.
",
    };

    private static Option<global::Audra.BatchSpeechRequestFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"",
    };

    private static Option<global::Audra.BatchSpeechRequestDeliveryProfile?> DeliveryProfile { get; } = new(
        name: @"--delivery-profile")
    {
        Description = @"",
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"BCP-47 language code. When omitted the service infers the language from
the voice slug prefix.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Audra.BatchSegment>> Segments { get; } = new(
        name: @"--segments")
    {
        Description = @"",
        Required = true,
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
        var command = new Command(@"create-speech-batch", @"Synthesize speech from pre-chunked segments");
                        command.Options.Add(IdempotencyKey);
                        command.Options.Add(XAudraCommercialUse);
                        command.Options.Add(Model);
                        command.Options.Add(Voice);
                        command.Options.Add(Speed);
                        command.Options.Add(CrossfadeMs);
                        command.Options.Add(Format);
                        command.Options.Add(DeliveryProfile);
                        command.Options.Add(Language);
                        command.Options.Add(Segments);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Audra.BatchSpeechRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Audra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var idempotencyKey = parseResult.GetValue(IdempotencyKey);
                        var xAudraCommercialUse = parseResult.GetValue(XAudraCommercialUse);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var crossfadeMs = CliRuntime.WasSpecified(parseResult, CrossfadeMs) ? parseResult.GetValue(CrossfadeMs) : (__requestBase is { } __CrossfadeMsBaseValue ? __CrossfadeMsBaseValue.CrossfadeMs : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var deliveryProfile = CliRuntime.WasSpecified(parseResult, DeliveryProfile) ? parseResult.GetValue(DeliveryProfile) : (__requestBase is { } __DeliveryProfileBaseValue ? __DeliveryProfileBaseValue.DeliveryProfile : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var segments = parseResult.GetRequiredValue(Segments);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Speech.CreateSpeechBatchAsync(
                                    idempotencyKey: idempotencyKey,
                                    xAudraCommercialUse: xAudraCommercialUse,
                                    model: model,
                                    voice: voice,
                                    speed: speed,
                                    crossfadeMs: crossfadeMs,
                                    format: format,
                                    deliveryProfile: deliveryProfile,
                                    language: language,
                                    segments: segments,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}