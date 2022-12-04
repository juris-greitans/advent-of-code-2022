using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day03;

public static class RucksackReorganizer {
    public static async Task<int> GetPrioritySumOfDuplicateItems() {
        var reader = new RucksackReader(InputUtils.GetTextReader(3));
        var rucksacks = await reader.ReadRucksacks();
        return rucksacks.Select(rucksack => rucksack.GetPriorityOfFirstDuplicateItem()).Sum();
    }
}