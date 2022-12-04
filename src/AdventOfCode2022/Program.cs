using AdventOfCode2022.Common;
using AdventOfCode2022.Day01;

Console.WriteLine("Day 1");
using var textReader = InputUtils.GetTextReader(1);
var calorieCounter = new CalorieCounter(new CaloriesReader(textReader));
Console.WriteLine($"Most calories: {await calorieCounter.GetMostCalories()}");
