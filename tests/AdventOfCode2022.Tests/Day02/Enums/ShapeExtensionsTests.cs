using AdventOfCode2022.Day02.Enums;
using Shouldly;

namespace AdventOfCode2022.Tests.Day02.Enums;

public class ShapeExtensionsTests {
    [Theory]
    [
        InlineData("A", Shape.Rock),
        InlineData("X", Shape.Rock),
        InlineData("B", Shape.Paper),
        InlineData("Y", Shape.Paper),
        InlineData("C", Shape.Scissors),
        InlineData("Z", Shape.Scissors)
    ]
    public void ToShape_ConvertsCorrectly(string value, Shape expected) {
        var actual = value.ToShape();
        actual.ShouldBe(expected);
    }
}