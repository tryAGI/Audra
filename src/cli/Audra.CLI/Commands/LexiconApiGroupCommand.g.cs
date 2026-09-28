#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class LexiconApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"lexicon", @"Lexicon endpoint commands.");
                         command.Subcommands.Add(LexiconDeleteLexiconByTermCommandApiCommand.Create());
                         command.Subcommands.Add(LexiconGetLexiconCommandApiCommand.Create());
                         command.Subcommands.Add(LexiconPutLexiconCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}