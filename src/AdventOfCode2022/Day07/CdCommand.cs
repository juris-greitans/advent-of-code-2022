using Directory = AdventOfCode2022.Day07.Models.Directory;

namespace AdventOfCode2022.Day07;

public class CdCommand : ICommand
{
    public override string ToString()
    {
        return "cd";
    }
    public async Task<Directory> Execute(Directory? pwd, TextReader reader, params string[] args)
    {
        Directory? result = null;
        var dirName = args[0];
        switch (dirName)
        {
            case "/":
                result = new Directory(dirName, null);
                break;
            case "..":
                result = pwd?.Parent ?? throw new ArgumentException($"Cannot 'cd {dirName}': no parent directory exists.");
            break;
            default:
                result = pwd.GetChildDirectory(dirName);
                break;
        }
        return result;
    }
}