#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class VoicesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"voices", @"Voices endpoint commands.");
                         command.Subcommands.Add(VoicesGetVoicesBySlugProbeCommandApiCommand.Create());
        return command;
    }
}