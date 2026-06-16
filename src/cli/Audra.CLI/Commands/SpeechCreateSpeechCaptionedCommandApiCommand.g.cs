#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class SpeechCreateSpeechCaptionedCommandApiCommand
{
    private static Option<global::Audra.CreateSpeechCaptionedXAudraCommercialUse?> XAudraCommercialUse { get; } = new(
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
        Description = @"",
        Required = true,
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

    private static Option<global::Audra.CaptionedSpeechRequestFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"",
    };

    private static Option<global::Audra.CaptionedSpeechRequestDeliveryProfile?> DeliveryProfile { get; } = new(
        name: @"--delivery-profile")
    {
        Description = @"",
    };

    private static Option<bool?> Normalize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--normalize",
        description: @"");

    private static Option<global::Audra.CaptionedSpeechRequestRenderMode?> RenderMode { get; } = new(
        name: @"--render-mode")
    {
        Description = @"",
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
        var command = new Command(@"create-speech-captioned", @"Synthesize speech with word-level caption timestamps
Returns MP3/WAV plus estimated word timestamps in the `X-Captions-Json` response header.
Timestamps are duration-weighted estimates (not forced alignment). Max **50,000** characters.
");
                        command.Options.Add(XAudraCommercialUse);
                        command.Options.Add(Model);
                        command.Options.Add(Text);
                        command.Options.Add(Voice);
                        command.Options.Add(Speed);
                        command.Options.Add(Format);
                        command.Options.Add(DeliveryProfile);
                        command.Options.Add(Normalize);
                        command.Options.Add(RenderMode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Audra.CaptionedSpeechRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Audra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xAudraCommercialUse = parseResult.GetValue(XAudraCommercialUse);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var text = parseResult.GetRequiredValue(Text);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var deliveryProfile = CliRuntime.WasSpecified(parseResult, DeliveryProfile) ? parseResult.GetValue(DeliveryProfile) : (__requestBase is { } __DeliveryProfileBaseValue ? __DeliveryProfileBaseValue.DeliveryProfile : default);
                        var normalize = CliRuntime.WasSpecified(parseResult, Normalize) ? parseResult.GetValue(Normalize) : (__requestBase is { } __NormalizeBaseValue ? __NormalizeBaseValue.Normalize : default);
                        var renderMode = CliRuntime.WasSpecified(parseResult, RenderMode) ? parseResult.GetValue(RenderMode) : (__requestBase is { } __RenderModeBaseValue ? __RenderModeBaseValue.RenderMode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Speech.CreateSpeechCaptionedAsync(
                                    xAudraCommercialUse: xAudraCommercialUse,
                                    model: model,
                                    text: text,
                                    voice: voice,
                                    speed: speed,
                                    format: format,
                                    deliveryProfile: deliveryProfile,
                                    normalize: normalize,
                                    renderMode: renderMode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}