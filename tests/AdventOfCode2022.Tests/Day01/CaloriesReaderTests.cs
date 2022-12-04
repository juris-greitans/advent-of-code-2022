using AdventOfCode2022.Day01;
using Shouldly;

namespace AdventOfCode2022.Tests.Day01;

public class CaloriesReaderTests {

    [Fact]
    public async Task ReadCaloryList_EmptyText_ReturnsEmptyList() {
        var reader = new CaloriesReader(GetTextReader(""));

        var actual = await reader.ReadCaloryList();

        actual.Count().ShouldBe(0);
    }

    [Fact]
    public async Task ReadCaloryList_OneLine_ReturnsListWithOneEntry() {
        var reader = new CaloriesReader(GetTextReader("1000"));

        var actual = await reader.ReadCaloryList();

        actual.Count().ShouldBe(1);
        actual.First().TotalCalories.ShouldBe(1000);
    }

    [Fact]
    public async Task ReadCaloryList_SeveralContinuousLines_ReturnsListWithOneEntry() {
        var reader = new CaloriesReader(GetTextReader("1000\n500\n"));

        var actual = await reader.ReadCaloryList();

        actual.Count().ShouldBe(1);
        actual.First().TotalCalories.ShouldBe(1500);
    }

    [Fact]
    public async Task ReadCaloryList_SeveralLines_ReturnsListWithCorrectNumberOfEntries() {
        var reader = new CaloriesReader(GetTextReader("1000\n500\n\n2000\n"));

        var actual = await reader.ReadCaloryList();

        actual.Count().ShouldBe(2);
        actual.First().TotalCalories.ShouldBe(1500);
        actual.ElementAt(1).TotalCalories.ShouldBe(2000);
    }


    private TextReader GetTextReader(string source) {
        return new StringReader(source);
    }
}