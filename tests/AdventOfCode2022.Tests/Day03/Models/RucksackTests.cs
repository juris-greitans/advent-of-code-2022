using AdventOfCode2022.Day03.Models;
using Shouldly;

namespace AdventOfCode2022.Tests.Day03.Models;

public class RucksackTests {

    [Theory]
    [
        InlineData("abcdefghijkf", 'f'),
        InlineData("abCdefghijkC", 'C')
    ]
    public void FindFirstDuplicateItem_FindsCorrectItem(string contents, char expected) {
        var rucksack = new Rucksack(contents);
        rucksack.FindFirstDuplicateItem().ShouldBe(expected);
    }

    [Theory]
    [
        InlineData("abcdefghijka", 1),
        InlineData("abCdefghijkC", 29)
    ]
    public void GetPriorityOfFirstDuplicateItem_ReturnsCorrectValue(string contents, int expected) {
        var rucksack = new Rucksack(contents);
        rucksack.GetPriorityOfFirstDuplicateItem().ShouldBe(expected);
    }
}