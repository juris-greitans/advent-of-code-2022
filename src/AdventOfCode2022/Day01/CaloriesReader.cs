using AdventOfCode2022.Day01.Interfaces;
using AdventOfCode2022.Day01.Models;

namespace AdventOfCode2022.Day01;

public class CaloriesReader: ICaloriesReader {

    private readonly TextReader _reader;
    public CaloriesReader(TextReader reader) {
        _reader = reader;
    }

    public async Task<IEnumerable<Calories>> ReadCaloryList()
    {
        var result = new List<Calories>();
        var calories = new Calories();
        for(var item = await _reader.ReadLineAsync(); item != null; item = await _reader.ReadLineAsync()) {
            if (item.Trim().Length == 0) {
                if (calories.TotalCalories > 0) {
                    result.Add(calories);
                }
                calories = new Calories();
                continue;
            }
            calories.AddCalories(int.Parse(item));
        }

        if (calories != null && calories.TotalCalories > 0) {
            result.Add(calories);
        }

        return result;
    }
}