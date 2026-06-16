#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class SpeechCreatePhonemizeCommandApiCommand
{
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

    private static Option<global::Audra.PhonemizeRequestRenderMode?> RenderMode { get; } = new(
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

                    private static string FormatResponse(ParseResult parseResult, global::Audra.PhonemizeResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Audra.PhonemizeResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-phonemize", @"Preview phoneme output for text (debug / tuning)
Returns the phoneme string Audra Phonetics would use for the given voice.
Supports inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.
Max **10,000** characters. Does not consume credits.
");
                        command.Options.Add(Text);
                        command.Options.Add(Voice);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Audra.PhonemizeRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Audra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var text = parseResult.GetRequiredValue(Text);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var renderMode = CliRuntime.WasSpecified(parseResult, RenderMode) ? parseResult.GetValue(RenderMode) : (__requestBase is { } __RenderModeBaseValue ? __RenderModeBaseValue.RenderMode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Speech.CreatePhonemizeAsync(
                                    text: text,
                                    voice: voice,
                                    renderMode: renderMode,
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