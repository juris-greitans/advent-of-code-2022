using AdventOfCode2022.Day04.Models;
using Shouldly;

namespace AdventOfCode2022.Tests.Day04.Models;

public class AssignmentTests {
    [Theory]
    [
        InlineData(2, 4, 6, 8, false),
        InlineData(2, 3, 4, 5, false),
        InlineData(5, 7, 7, 9, false),
        InlineData(2, 8, 3, 7, true),
        InlineData(6, 6, 4, 6, false),
        InlineData(2, 6, 4, 8, false)
    ]
    public void Contains_ReturnsCorrectValue(int first1, int second1, int first2, int second2, bool expected) {
        var first = new Assignment(first1, second1);
        var second = new Assignment(first2, second2);
        
        first.Contains(second).ShouldBe(expected);
    }

    [Theory]
    [
        InlineData(2, 4, 6, 8, false),
        InlineData(2, 3, 4, 5, false),
        InlineData(5, 7, 7, 9, true),
        InlineData(2, 8, 3, 7, true),
        InlineData(6, 6, 4, 6, true),
        InlineData(2, 6, 4, 8, true)
    ]
    public void Overlaps_ReturnsCorrectValue(int first1, int second1, int first2, int second2, bool expected) {
        var first = new Assignment(first1, second1);
        var second = new Assignment(first2, second2);
        
        first.Overlaps(second).ShouldBe(expected);
    }
}