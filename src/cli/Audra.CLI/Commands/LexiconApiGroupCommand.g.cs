#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class LexiconApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"lexicon", @"Lexicon endpoint commands.");
                         command.Subcommands.Add(LexiconDeleteLexiconByTermCommandApiCommand.Create());
                         command.Subcommands.Add(LexiconGetLexiconCommandApiCommand.Create());
                         command.Subcommands.Add(LexiconPutLexiconCommandApiCommand.Create());
        return command;
    }
}