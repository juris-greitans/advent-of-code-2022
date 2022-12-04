using AdventOfCode2022.Common;
using AdventOfCode2022.Day01;
using AdventOfCode2022.Day02;

await Day01();
await Day02();

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
    Console.WriteLine($"\tTotal score of Rock Paper Scissors game (version 1): {await RockPaperScissors.GetTotalScoreVersion1()}");
    Console.WriteLine($"\tTotal score of Rock Paper Scissors game (version 2): {await RockPaperScissors.GetTotalScoreVersion2()}");
}