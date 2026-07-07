#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class SpeechCreateSpeechJobsCommandApiCommand
{
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

    private static Option<global::Audra.SpeechJobRequestFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"Optional callback POSTed with `{ job_id, status, chars }` on completion or failure.",
    };

    private static Option<global::Audra.SpeechJobRequestMode?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"`standard` — default queue placement, 1.0× credits.
`fast` — queue priority, 1.25× credits.
`economy` — deferred/best-effort, 0.75× credits (25% discount). Runs on the
next scheduled sweep (default every 12h) or sooner if a worker for the
requested model is already warm from other traffic. Async jobs only —
rejected with 400 on synchronous endpoints (`POST /v2/speech` and similar).
",
    };

    private static Option<bool?> FastMode { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--fast-mode",
        description: @"Alias for mode: ""fast"".");

    private static Option<bool?> Economy { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--economy",
        description: @"Alias for mode: ""economy"".");

    private static Option<global::Audra.SpeechJobRequestDeliveryProfile?> DeliveryProfile { get; } = new(
        name: @"--delivery-profile")
    {
        Description = @"",
    };

    private static Option<global::Audra.SpeechJobRequestScriptEnhance?> ScriptEnhance { get; } = new(
        name: @"--script-enhance")
    {
        Description = @"",
    };

    private static Option<global::Audra.SpeechJobRequestAudioPost?> AudioPost { get; } = new(
        name: @"--audio-post")
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

                    private static string FormatResponse(ParseResult parseResult, global::Audra.SpeechJobResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Audra.SpeechJobResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-speech-jobs", @"Create an async speech render job
Queues text for background rendering — poll `status_url` until `status`
is `completed`, then download `audio_url`. Use for long-form text where a
synchronous response would time out (auto-triggered above ~8k chars on
`POST /v2/speech` unless `X-Audra-Sync: true` is set).

Supports three delivery modes via `mode` (or the `fast_mode`/`priority`/`economy`
boolean aliases): `standard` (default), `fast` (queue priority, 1.25× credits),
and `economy` (deferred/best-effort, 0.75× credits — see `SpeechJobRequest.mode`).
`economy` is **only** available on this async endpoint; `POST /v2/speech` and
other synchronous endpoints reject it with 400.
");
                        command.Options.Add(Model);
                        command.Options.Add(Text);
                        command.Options.Add(Voice);
                        command.Options.Add(Speed);
                        command.Options.Add(Format);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(Mode);
                        command.Options.Add(FastMode);
                        command.Options.Add(Economy);
                        command.Options.Add(DeliveryProfile);
                        command.Options.Add(ScriptEnhance);
                        command.Options.Add(AudioPost);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Audra.SpeechJobRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Audra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var text = parseResult.GetRequiredValue(Text);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                        var fastMode = CliRuntime.WasSpecified(parseResult, FastMode) ? parseResult.GetValue(FastMode) : (__requestBase is { } __FastModeBaseValue ? __FastModeBaseValue.FastMode : default);
                        var economy = CliRuntime.WasSpecified(parseResult, Economy) ? parseResult.GetValue(Economy) : (__requestBase is { } __EconomyBaseValue ? __EconomyBaseValue.Economy : default);
                        var deliveryProfile = CliRuntime.WasSpecified(parseResult, DeliveryProfile) ? parseResult.GetValue(DeliveryProfile) : (__requestBase is { } __DeliveryProfileBaseValue ? __DeliveryProfileBaseValue.DeliveryProfile : default);
                        var scriptEnhance = CliRuntime.WasSpecified(parseResult, ScriptEnhance) ? parseResult.GetValue(ScriptEnhance) : (__requestBase is { } __ScriptEnhanceBaseValue ? __ScriptEnhanceBaseValue.ScriptEnhance : default);
                        var audioPost = CliRuntime.WasSpecified(parseResult, AudioPost) ? parseResult.GetValue(AudioPost) : (__requestBase is { } __AudioPostBaseValue ? __AudioPostBaseValue.AudioPost : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Speech.CreateSpeechJobsAsync(
                                    model: model,
                                    text: text,
                                    voice: voice,
                                    speed: speed,
                                    format: format,
                                    webhookUrl: webhookUrl,
                                    mode: mode,
                                    fastMode: fastMode,
                                    economy: economy,
                                    deliveryProfile: deliveryProfile,
                                    scriptEnhance: scriptEnhance,
                                    audioPost: audioPost,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Audra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}