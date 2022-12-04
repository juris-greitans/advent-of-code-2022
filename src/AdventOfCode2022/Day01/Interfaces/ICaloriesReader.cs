using AdventOfCode2022.Day01.Models;

namespace AdventOfCode2022.Day01.Interfaces;

public interface ICaloriesReader {
    Task<IEnumerable<Calories>> ReadCaloryList();
}