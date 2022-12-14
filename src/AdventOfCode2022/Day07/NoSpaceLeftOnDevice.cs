using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day07;

public static class NoSpaceLeftOnDevice
{
    public static async Task<int> GetTotalSizeOfDirectoriesSmallerThan(int limit)
    {
        using var textReader = InputUtils.GetTextReader(7);
        var terminal = new Terminal();
        var tree = await terminal.ParseOutput(textReader);
        return tree.GetTotalSizeOfDirectoriesSmallerThan(limit);
    }

    public static async Task<int> FreeUpSpace(int diskSizeInBytes, int requiredFreeSpaceInBytes)
    {
        using var textReader = InputUtils.GetTextReader(7);
        var terminal = new Terminal();
        var tree = await terminal.ParseOutput(textReader);
        return tree.FreeUpSpace(diskSizeInBytes, requiredFreeSpaceInBytes);
    }
}