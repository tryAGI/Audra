#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class SpeechApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"speech", @"Speech endpoint commands.");
                         command.Subcommands.Add(SpeechCreatePhonemizeCommandApiCommand.Create());
                         command.Subcommands.Add(SpeechCreateSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(SpeechCreateSpeechBatchCommandApiCommand.Create());
                         command.Subcommands.Add(SpeechCreateSpeechCaptionedCommandApiCommand.Create());
        return command;
    }
}