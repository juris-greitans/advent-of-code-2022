using AdventOfCode2022.Common;
using AdventOfCode2022.Day01;
using AdventOfCode2022.Day02;
using AdventOfCode2022.Day02.Enums;
using AdventOfCode2022.Day03;
using AdventOfCode2022.Day04;
using AdventOfCode2022.Day05;
using AdventOfCode2022.Day06;
using AdventOfCode2022.Day07;

await Day01();
await Day02();
await Day03();
await Day04();
await Day05();
await Day06();
await Day07();

async Task Day01() {
    Console.WriteLine("Day 1");
    using var textReader1 = InputUtils.GetTextReader(1);
    var calorieCounter1 = new CalorieCounter(new CaloriesReader(textReader1));
    Console.WriteLine($"\tMost calories: {await calorieCounter1.GetMostCalories()}");

    using var textReader2 = InputUtils.GetTextReader(1);
    var calorieCounter2 = new CalorieCounter(new CaloriesReader(textReader2));
    Console.WriteLine($"\tSum of top 3 calories: {await calorieCounter2.GetMostCaloriesForTopN(3)}");
}

async Task Day02() {
    Console.WriteLine("Day 2");
    Console.WriteLine($"\tTotal score of Rock Paper Scissors game (version 1): {await RockPaperScissors.GetTotalScore(StrategyGuideFormat.Player1AndPlayer2)}");
    Console.WriteLine($"\tTotal score of Rock Paper Scissors game (version 2): {await RockPaperScissors.GetTotalScore(StrategyGuideFormat.Player1AndOutcome)}");
}

async Task Day03() {
    Console.WriteLine("Day 3");
    Console.WriteLine($"\tSum of priorities of duplicate items: {await RucksackReorganizer.GetPrioritySumOfDuplicateItems()}");
    Console.WriteLine($"\tSum of priorities of group badges: {await RucksackReorganizer.GetPrioritySumOfGroupBadges()}");
}

async Task Day04() {
    Console.WriteLine("Day 4");
    Console.WriteLine($"\tNumber of fully containing assignments: {await CampCleanup.GetFullyContainingAssignments()}");
    Console.WriteLine($"\tNumber of overlapping assignments: {await CampCleanup.GetOverlappingAssignments()}");
}

async Task Day05() {
    Console.WriteLine("Day 5");
    Console.WriteLine($"\tTop crates: {await SupplyStacks.Rearrange(new Crane())}");
    Console.WriteLine($"\tTop crates (CrateMover 9001): {await SupplyStacks.Rearrange(new Crane2())}");
}

async Task Day06() {
    Console.WriteLine("Day 6");
    Console.WriteLine($"\t# of characters before start of packet: {await TuningTrouble.GetNumberOfCharactersBeforePacket(4)}");
    Console.WriteLine($"\t# of characters before start of message: {await TuningTrouble.GetNumberOfCharactersBeforePacket(14)}");
}

async Task Day07() {
    Console.WriteLine("Day 7");
    Console.WriteLine($"\tSum of total sizes of directories with sizes of at most 100000: {await NoSpaceLeftOnDevice.GetTotalSizeOfDirectoriesSmallerThan(100001)}");
    Console.WriteLine($"\tTotal size of smallest directory to delete: {await NoSpaceLeftOnDevice.FreeUpSpace(70000000, 30000000)}");
}