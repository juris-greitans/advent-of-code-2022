using AdventOfCode2022.Day07.Models;
using Directory = AdventOfCode2022.Day07.Models.Directory;

namespace AdventOfCode2022.Day07;

public class Terminal
{
    public async Task<DirectoryTree> ParseOutput(TextReader reader) {
        var tree = new DirectoryTree();
        Directory? pwd = null;
        var line = await reader.ReadLineAsync();
        while(line != null)
        {
            if (line.StartsWith("$")) {
                var parts = line.Split();
                ICommand? command = null;
                switch (parts[1]) {
                    case "cd":
                        command = new CdCommand();
                        break;
                    case "ls":
                        command = new LsCommand();
                        break;
                    default:
                        throw new NotImplementedException($"Unknown command '{parts[1]}'.");
                }
                var args = parts.Length > 2 ? parts[2..] : new string[]{};
                pwd = await command.Execute(pwd, reader, args);
                if (pwd.IsRoot) {
                    tree.Root = pwd;
                }
            }
            line = await reader.ReadLineAsync();
        }
        return tree;
    }
}