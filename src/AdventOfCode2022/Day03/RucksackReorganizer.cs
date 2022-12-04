using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day03;

public static class RucksackReorganizer {
    public static async Task<int> GetPrioritySumOfDuplicateItems() {
        var reader = new RucksackReader(InputUtils.GetTextReader(3));
        var rucksacks = await reader.ReadRucksacks();
        return rucksacks.Select(rucksack => rucksack.GetPriorityOfFirstDuplicateItem()).Sum();
    }

    public static async Task<int> GetPrioritySumOfGroupBadges() {
        var reader = new RucksackReader(InputUtils.GetTextReader(3));
        var rucksacks = await reader.ReadRucksacks();
        var sum = 0;
        for(var i = 0; i < rucksacks.Count(); i += 3) {
            var rucksack1 = rucksacks[i];
            var rucksack2 = rucksacks[i + 1];
            var rucksack3 = rucksacks[i + 2];
            var commonItems = rucksack1.FindMatchingItems(rucksack2.FindMatchingItems(rucksack3.Contents));
            sum += commonItems[0].GetPriority();
        }
        return sum;
    }
}