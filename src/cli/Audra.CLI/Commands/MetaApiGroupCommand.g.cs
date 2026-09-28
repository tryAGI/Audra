#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class MetaApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"meta", @"Meta endpoint commands.");
                         command.Subcommands.Add(MetaGetHealthCommandApiCommand.Create());
                         command.Subcommands.Add(MetaGetModelsCommandApiCommand.Create());
                         command.Subcommands.Add(MetaGetStatsPublicCommandApiCommand.Create());
                         command.Subcommands.Add(MetaGetVoicesCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}