using AdventOfCode2022.Day02;
using AdventOfCode2022.Day02.Enums;
using Shouldly;

namespace AdventOfCode2022.Tests.Day02;

public class RoundTests {
    [Theory]
    [
        InlineData(Shape.Paper, Shape.Paper, RoundOutcome.Draw),
        InlineData(Shape.Paper, Shape.Rock, RoundOutcome.Loss),
        InlineData(Shape.Paper, Shape.Scissors, RoundOutcome.Win),
        InlineData(Shape.Rock, Shape.Paper, RoundOutcome.Win),
        InlineData(Shape.Rock, Shape.Rock, RoundOutcome.Draw),
        InlineData(Shape.Rock, Shape.Scissors, RoundOutcome.Loss),
        InlineData(Shape.Scissors, Shape.Paper, RoundOutcome.Loss),
        InlineData(Shape.Scissors, Shape.Rock, RoundOutcome.Win),
        InlineData(Shape.Scissors, Shape.Scissors, RoundOutcome.Draw)
    ]
    public void Outcome_ReturnsExpectedOutcome(Shape player1, Shape player2, RoundOutcome expected) {
        var round = new Round(player1, player2);
        round.Outcome.ShouldBe(expected);
    }

    [Theory]
    [
        InlineData(Shape.Paper, Shape.Paper, 5),
        InlineData(Shape.Paper, Shape.Rock, 1),
        InlineData(Shape.Paper, Shape.Scissors, 9),
        InlineData(Shape.Rock, Shape.Paper, 8),
        InlineData(Shape.Rock, Shape.Rock, 4),
        InlineData(Shape.Rock, Shape.Scissors, 3),
        InlineData(Shape.Scissors, Shape.Paper, 2),
        InlineData(Shape.Scissors, Shape.Rock, 7),
        InlineData(Shape.Scissors, Shape.Scissors, 6)
    ]
    public void Score_ReturnsExpectedScore(Shape player1, Shape player2, int expected) {
        var round = new Round(player1, player2);
        round.Score.ShouldBe(expected);
    }
}