using AdventOfCode2022.Day01.Interfaces;

namespace AdventOfCode2022.Day01;

public class CalorieCounter
{
    private readonly ICaloriesReader _reader;

    public CalorieCounter(ICaloriesReader reader) {
        _reader = reader;
    }

    public async Task<long> GetMostCalories() {
        var list = await _reader.ReadCaloryList();
        return list.Select(item => item.TotalCalories).Max();
    }

    public async Task<long> GetMostCaloriesForTopN(int n)
    {
        var top = new long[n];
        var smallestTopIndex = 0;

        var list = await _reader.ReadCaloryList();
        foreach (var item in list)
        {
            if (item.TotalCalories > top[smallestTopIndex]) {
                top[smallestTopIndex] = item.TotalCalories;
                for (var i = 0; i < top.Length; i++)
                {
                    if (top[i] < top[smallestTopIndex]) {
                        smallestTopIndex = i;
                    }
                }
            }
        }
        return top.Sum();
    }
}