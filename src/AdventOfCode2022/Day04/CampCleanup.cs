using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day04;

public static class CampCleanup {
    public static async Task<int> GetFullyContainingAssignments() {
        var reader = new AssignmentPairReader(InputUtils.GetTextReader(4));
        var pairs = await reader.ReadAssignmentPairs();
        var overlappingPairs = pairs.Where(pair => pair.Item1.Contains(pair.Item2) || pair.Item2.Contains(pair.Item1));
        return overlappingPairs.Count();
    }
}