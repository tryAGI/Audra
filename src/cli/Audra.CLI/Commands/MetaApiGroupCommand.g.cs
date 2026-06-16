#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class MetaApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"meta", @"Meta endpoint commands.");
                         command.Subcommands.Add(MetaGetHealthCommandApiCommand.Create());
                         command.Subcommands.Add(MetaGetModelsCommandApiCommand.Create());
                         command.Subcommands.Add(MetaGetStatsPublicCommandApiCommand.Create());
                         command.Subcommands.Add(MetaGetVoicesCommandApiCommand.Create());
        return command;
    }
}