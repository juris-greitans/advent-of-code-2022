using AdventOfCode2022.Common;
using AdventOfCode2022.Day01;

await Day01();

async Task Day01() {
    Console.WriteLine("Day 1");
    using var textReader1 = InputUtils.GetTextReader(1);
    var calorieCounter1 = new CalorieCounter(new CaloriesReader(textReader1));
    Console.WriteLine($"\tMost calories: {await calorieCounter1.GetMostCalories()}");

    using var textReader2 = InputUtils.GetTextReader(1);
    var calorieCounter2 = new CalorieCounter(new CaloriesReader(textReader2));
    Console.WriteLine($"\tSum of top 3 calories: {await calorieCounter2.GetMostCaloriesForTopN(3)}");
}