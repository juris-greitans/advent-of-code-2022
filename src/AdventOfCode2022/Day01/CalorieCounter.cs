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
}