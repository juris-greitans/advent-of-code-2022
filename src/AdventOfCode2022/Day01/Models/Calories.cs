namespace AdventOfCode2022.Day01.Models;

public class Calories {
    private readonly IList<int> _calories;
    private long _total = 0;

    public Calories() {
        _calories = new List<int>();
    }
    public Calories(IEnumerable<int> calories) {
        _calories = new List<int>(calories ?? new int[]{});
        _total = _calories.Sum();
    }

    public void AddCalories(int calories) {
        _calories.Add(calories);
        _total += calories;
    }

    public long TotalCalories => _total;
}