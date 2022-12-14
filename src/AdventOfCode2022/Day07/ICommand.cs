using Directory = AdventOfCode2022.Day07.Models.Directory;

namespace AdventOfCode2022.Day07;

public interface ICommand
{
    Task<Directory> Execute(Directory? pwd, TextReader reader, params string[] args);
}