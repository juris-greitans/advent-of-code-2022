using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day08;

public static class TreetopTreeHouse
{
    public static async Task<int> GetNumberOfVisibleTrees()
    {
        using var textReader = InputUtils.GetTextReader(8);
        var treeGrid = new TreeGrid();
        await treeGrid.ReadGrid(textReader);
        return treeGrid.GetNumberOfVisibleTrees();
    }

    public static async Task<int> GetBestScenicScore()
    {
        using var textReader = InputUtils.GetTextReader(8);
        var treeGrid = new TreeGrid();
        await treeGrid.ReadGrid(textReader);
        return treeGrid.GetBestScenicScore();
    }
}